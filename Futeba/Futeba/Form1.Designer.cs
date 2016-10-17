namespace Futeba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandomize = new System.Windows.Forms.Button();
            this.gridtime1 = new System.Windows.Forms.DataGridView();
            this.gridTime2 = new System.Windows.Forms.DataGridView();
            this.gridTime3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridtime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTime3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(12, 12);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Tirar Time";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // gridtime1
            // 
            this.gridtime1.AllowUserToAddRows = false;
            this.gridtime1.AllowUserToDeleteRows = false;
            this.gridtime1.AllowUserToResizeColumns = false;
            this.gridtime1.AllowUserToResizeRows = false;
            this.gridtime1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtime1.Location = new System.Drawing.Point(12, 59);
            this.gridtime1.Name = "gridtime1";
            this.gridtime1.RowHeadersVisible = false;
            this.gridtime1.Size = new System.Drawing.Size(215, 180);
            this.gridtime1.TabIndex = 1;
            // 
            // gridTime2
            // 
            this.gridTime2.AllowUserToAddRows = false;
            this.gridTime2.AllowUserToDeleteRows = false;
            this.gridTime2.AllowUserToResizeColumns = false;
            this.gridTime2.AllowUserToResizeRows = false;
            this.gridTime2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTime2.Location = new System.Drawing.Point(233, 59);
            this.gridTime2.Name = "gridTime2";
            this.gridTime2.RowHeadersVisible = false;
            this.gridTime2.Size = new System.Drawing.Size(215, 180);
            this.gridTime2.TabIndex = 1;
            // 
            // gridTime3
            // 
            this.gridTime3.AllowUserToAddRows = false;
            this.gridTime3.AllowUserToDeleteRows = false;
            this.gridTime3.AllowUserToResizeColumns = false;
            this.gridTime3.AllowUserToResizeRows = false;
            this.gridTime3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTime3.Location = new System.Drawing.Point(454, 59);
            this.gridTime3.Name = "gridTime3";
            this.gridTime3.RowHeadersVisible = false;
            this.gridTime3.Size = new System.Drawing.Size(215, 180);
            this.gridTime3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 251);
            this.Controls.Add(this.gridTime3);
            this.Controls.Add(this.gridTime2);
            this.Controls.Add(this.gridtime1);
            this.Controls.Add(this.btnRandomize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridtime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTime3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.DataGridView gridtime1;
        private System.Windows.Forms.DataGridView gridTime2;
        private System.Windows.Forms.DataGridView gridTime3;
    }
}

