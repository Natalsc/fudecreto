using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Futeba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string Connection = "Data Source=localhost;User=aggersa;password=1800Dz10;Initial Catalog=futeba;MultipleActiveResultSets=True";

        private DataTable FeedPlayers()
        {
            /*              
             CREATE TABLE player(
                playerid BIGINT IDENTITY(1,1) NOT NULL,
                name VARCHAR(100) NOT NULL,
                positionid BIGINT NOT NULL,
                playerlevel SMALLINT NOT NULL,
                status VARCHAR(1) NOT NULL,
                PRIMARY KEY(playerid)
                );
            */
            gridtime1.DataSource = null;
            gridTime2.DataSource = null;
            gridTime3.DataSource = null;
            gridRestante.DataSource = null;

            var players = new DataTable();

            using (var sqlConnection = new SqlConnection(Connection))
            {
                sqlConnection.Open();
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT * FROM player WHERE status = 1";
                    using (var sqlDa = new SqlDataAdapter())
                    {
                        sqlDa.SelectCommand = sqlCommand;
                        sqlDa.Fill(players);
                    }
                }
            }
            return players;
        } 

        private void Randomize()
        {
            var players = FeedPlayers();

            var times = players.Rows.Count / 5;
            players = shuffleTable(players, players.Rows.Count);

            var countDefense = 0;
            var levelDefense = 0;
            var foundDefence = players.Select($"positionid = 1");
            foreach (var row in foundDefence)
            {
                countDefense++;
                levelDefense += int.Parse(row["playerlevel"].ToString());
            }

            levelDefense = levelDefense / times;

            var countAttack = 0;
            var levelAttack = 0;
            var foundAttack = players.Select($"positionid = 2");
            foreach (var row in foundAttack)
            {
                countAttack++;
                levelAttack += int.Parse(row["playerlevel"].ToString());
            }

            levelAttack = levelAttack / times;

            var tableTimes = new DataTable();
            tableTimes.Columns.Add("name", typeof(string));
            tableTimes.Columns.Add("time", typeof(int));

            for (var i = 1; i <= times; i++)
            {
                var defenseTime = 0;
                countDefense = 0;
                foreach (var row in foundDefence)
                {
                    if (row["name"].ToString() == "dontuse") continue;
                    if (countDefense > 1) continue;
                    defenseTime += int.Parse(row["playerlevel"].ToString());
                    if ((levelDefense * 1.1) >= defenseTime)
                    {
                        var line = tableTimes.NewRow();
                        line["name"] = row["name"];
                        line["time"] = i;
                        tableTimes.Rows.Add(line);
                        countDefense++;
                        row["name"] = "dontuse";
                    }
                    else
                        defenseTime -= int.Parse(row["playerlevel"].ToString());
                }

                var attackTime = 0;
                countAttack = 0;
                foreach (var row in foundAttack)
                {
                    if (row["name"].ToString() == "dontuse") continue;
                    if (countAttack > 2) continue;
                    attackTime += int.Parse(row["playerlevel"].ToString());
                    if ((levelAttack * 1.1) >= attackTime)
                    {
                        var line = tableTimes.NewRow();
                        line["name"] = row["name"];
                        line["time"] = i;
                        tableTimes.Rows.Add(line);
                        countAttack++;
                        row["name"] = "dontuse";
                    }
                    else
                        attackTime -= int.Parse(row["playerlevel"].ToString());
                }
            }

            foreach (var row in foundAttack)
            {
                if (row["name"].ToString() == "dontuse") continue;
                var line = tableTimes.NewRow();
                line["name"] = row["name"];
                line["time"] = times+1;
                tableTimes.Rows.Add(line);
            }

            foreach (var row in foundDefence)
            {
                if(row["name"].ToString() == "dontuse") continue;
                if (row["name"].ToString() == "dontuse") continue;
                var line = tableTimes.NewRow();
                line["name"] = row["name"];
                line["time"] = times + 1;
                tableTimes.Rows.Add(line);
            }

            var time1 = new DataTable();
            time1.Columns.Add("name", typeof(string));
            var time2 = new DataTable();
            time2.Columns.Add("name", typeof(string));
            var time3 = new DataTable();
            time3.Columns.Add("name", typeof(string));
            var time4 = new DataTable();
            time4.Columns.Add("name", typeof(string));

            foreach (DataRow rows in tableTimes.Rows)
            {
                if (rows["time"].ToString() == "1")
                {
                    var row = time1.NewRow();
                    row["name"] = rows["name"];
                    time1.Rows.Add(row);
                }

                if (rows["time"].ToString() == "2")
                {
                    var row = time2.NewRow();
                    row["name"] = rows["name"];
                    time2.Rows.Add(row);
                }

                if (rows["time"].ToString() == "3")
                {
                    var row = time3.NewRow();
                    row["name"] = rows["name"];
                    time3.Rows.Add(row);
                }

                if (rows["time"].ToString() == "4")
                {
                    var row = time4.NewRow();
                    row["name"] = rows["name"];
                    time4.Rows.Add(row);
                }
            }


            gridtime1.DataSource = time1;
            gridTime2.DataSource = time2;
            gridTime3.DataSource = time3;
            gridRestante.DataSource = time4;
        }

        private DataTable shuffleTable(DataTable inputTable, int shuffleIterations)
        {
            var rnd = new Random();
            // Remove and throw to the end random rows until we have done so n*3 times (shuffles the dataset)
            for (var i = 0; i < shuffleIterations; i++)
            {
                var index = rnd.Next(0, inputTable.Rows.Count - 1);
                inputTable.Rows.Add(inputTable.Rows[index].ItemArray);
                inputTable.Rows.RemoveAt(index);
            }
            return inputTable;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
