using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Futeba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random _random = new Random();
        DataTable _players = new DataTable();

        private void Randomize()
        {
            var times = _players.Rows.Count/6;
            var timeLevel = 0;
            foreach (DataRow players in _players.Rows)
            {
                timeLevel += int.Parse(players["level"].ToString());
            }

            timeLevel = timeLevel / times;

            var sort = "level desc";
            for (var i = 1; i < 7; i++)
            {
                var expression = $"position = {i}";
                var foundRows = _players.Select(expression);

                var playersName = "";
                var iCount = 1;
                foreach (var row in foundRows)
                {
                    if (row["time"].ToString() != string.Empty)continue;
                    playersName += $"{row["name"]},";
                }

                var array = playersName.Split(',');

                Shuffle(array);
                foreach (var value in array)
                {
                    if (string.IsNullOrEmpty(value)) continue;
                    foreach (DataRow players in _players.Rows)
                    {
                        if (value == players["name"].ToString())
                            players["time"] = iCount;
                    }
                    if (iCount == times)
                        break;

                    iCount++;
                }
            }

            var time1 = new DataTable();
            time1.Columns.Add("name", typeof(string));
            time1.Columns.Add("level", typeof(int));
            var time2 = new DataTable();
            time2.Columns.Add("name", typeof(string));
            time2.Columns.Add("level", typeof(int));
            var time3 = new DataTable();
            time3.Columns.Add("name", typeof(string));
            time3.Columns.Add("level", typeof(int));

            for (var i = 1; i <= 3; i++)
            {
                var expression = $"time = {i}";
                var foundRows = _players.Select(expression);
                
                foreach (var rows in foundRows)
                {
                    if (rows["time"].ToString() == "1")
                    {
                        var row = time1.NewRow();
                        row["name"] = rows["name"];
                        row["level"] = rows["level"];
                        time1.Rows.Add(row);
                    }

                    if (rows["time"].ToString() == "2")
                    {
                        var row = time2.NewRow();
                        row["name"] = rows["name"];
                        row["level"] = rows["level"];
                        time2.Rows.Add(row);
                    }

                    if (rows["time"].ToString() == "3")
                    {
                        var row = time3.NewRow();
                        row["name"] = rows["name"];
                        row["level"] = rows["level"];
                        time3.Rows.Add(row);
                    }
                }
            }

            gridtime1.DataSource = time1;
            gridTime2.DataSource = time2;
            gridTime3.DataSource = time3;
        }

        private void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (var i = array.Length; i > 1; i--)
            {
                var j = random.Next(i);
                var tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _players.Columns.Add("name", typeof (string));
            _players.Columns.Add("position", typeof(string));
            _players.Columns.Add("level", typeof(int));
            _players.Columns.Add("time", typeof(string));

            var row = _players.NewRow();
            row["name"] = "GOLEIRO 1";
            row["position"] = "1";
            row["level"] = 5;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "GOLEIRO 2";
            row["position"] = "1";
            row["level"] = 7;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "GOLEIRO 3";
            row["position"] = "1";
            row["level"] = 3;
            _players.Rows.Add(row);



            row = _players.NewRow();
            row["name"] = "NATAL";
            row["position"] = "2";
            row["level"] = 3;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "SOARES";
            row["position"] = "2";
            row["level"] = 6;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "BOCA";
            row["position"] = "2";
            row["level"] = 1;
            _players.Rows.Add(row);



            row = _players.NewRow();
            row["name"] = "PET";
            row["position"] = "3";
            row["level"] = 10;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "JUNIOR";
            row["position"] = "3";
            row["level"] = 4;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "NEGO";
            row["position"] = "3";
            row["level"] = 7;
            _players.Rows.Add(row);



            row = _players.NewRow();
            row["name"] = "NEY";
            row["position"] = "4";
            row["level"] = 5;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "BOI";
            row["position"] = "4";
            row["level"] = 7;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "DRI";
            row["position"] = "4";
            row["level"] = 3;
            _players.Rows.Add(row);



            row = _players.NewRow();
            row["name"] = "CHRISTOFOLETTI";
            row["position"] = "5";
            row["level"] = 3;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "SAFADAO";
            row["position"] = "5";
            row["level"] = 6;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "DU";
            row["position"] = "5";
            row["level"] = 1;
            _players.Rows.Add(row);



            row = _players.NewRow();
            row["name"] = "PIMENTA";
            row["position"] = "6";
            row["level"] = 10;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "BOY";
            row["position"] = "6";
            row["level"] = 4;
            _players.Rows.Add(row);

            row = _players.NewRow();
            row["name"] = "CHRIS";
            row["position"] = "6";
            row["level"] = 7;
            _players.Rows.Add(row);


        }
    }
}
