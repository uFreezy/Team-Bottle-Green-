﻿namespace BottleGreen.Main
{
    partial class BottleGreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OracleToMssql = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PDF_Reports = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_end = new System.Windows.Forms.TextBox();
            this.tx_start = new System.Windows.Forms.TextBox();
            this.btn_ToMongo = new System.Windows.Forms.Button();
            this.btn_JsonReports = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_SqliteToExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "ZIP To MSSQL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OracleToMssql);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Problem 2";
            // 
            // btn_OracleToMssql
            // 
            this.btn_OracleToMssql.Location = new System.Drawing.Point(6, 108);
            this.btn_OracleToMssql.Name = "btn_OracleToMssql";
            this.btn_OracleToMssql.Size = new System.Drawing.Size(88, 40);
            this.btn_OracleToMssql.TabIndex = 0;
            this.btn_OracleToMssql.Text = "Oracle to MSSQL";
            this.btn_OracleToMssql.UseVisualStyleBackColor = true;
            this.btn_OracleToMssql.Click += new System.EventHandler(this.btn_OracleToMssql_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(436, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 205);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Problem 6";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "XML File To MSSQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.XMLtoMSSQL_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.endDateLabel);
            this.groupBox3.Controls.Add(this.endDate);
            this.groupBox3.Controls.Add(this.startDateLabel);
            this.groupBox3.Controls.Add(this.startDate);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(224, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 205);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Problem 4";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(6, 63);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "end date:";
            this.endDateLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(6, 79);
            this.endDate.Multiline = true;
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(88, 20);
            this.endDate.TabIndex = 1;
            this.endDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 20);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(54, 13);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "start date:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(6, 36);
            this.startDate.Multiline = true;
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(88, 20);
            this.startDate.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "MSSQL to XML File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MsqlToXML_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PDF_Reports);
            this.groupBox4.Location = new System.Drawing.Point(118, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 205);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Problem 3";
            // 
            // PDF_Reports
            // 
            this.PDF_Reports.Location = new System.Drawing.Point(6, 158);
            this.PDF_Reports.Name = "PDF_Reports";
            this.PDF_Reports.Size = new System.Drawing.Size(88, 40);
            this.PDF_Reports.TabIndex = 0;
            this.PDF_Reports.Text = "PDF Reports";
            this.PDF_Reports.UseVisualStyleBackColor = true;
            this.PDF_Reports.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tx_end);
            this.groupBox5.Controls.Add(this.tx_start);
            this.groupBox5.Controls.Add(this.btn_ToMongo);
            this.groupBox5.Controls.Add(this.btn_JsonReports);
            this.groupBox5.Location = new System.Drawing.Point(330, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 205);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Problem 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "end date:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "start date:";
            // 
            // tx_end
            // 
            this.tx_end.Location = new System.Drawing.Point(6, 79);
            this.tx_end.Name = "tx_end";
            this.tx_end.Size = new System.Drawing.Size(88, 20);
            this.tx_end.TabIndex = 1;
            // 
            // tx_start
            // 
            this.tx_start.Location = new System.Drawing.Point(6, 36);
            this.tx_start.Name = "tx_start";
            this.tx_start.Size = new System.Drawing.Size(88, 20);
            this.tx_start.TabIndex = 0;
            this.tx_start.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btn_ToMongo
            // 
            this.btn_ToMongo.Location = new System.Drawing.Point(6, 158);
            this.btn_ToMongo.Name = "btn_ToMongo";
            this.btn_ToMongo.Size = new System.Drawing.Size(88, 40);
            this.btn_ToMongo.TabIndex = 3;
            this.btn_ToMongo.Text = "Reports To MONGODB";
            this.btn_ToMongo.UseVisualStyleBackColor = true;
            this.btn_ToMongo.Click += new System.EventHandler(this.btn_ToMongo_Click);
            // 
            // btn_JsonReports
            // 
            this.btn_JsonReports.Location = new System.Drawing.Point(6, 114);
            this.btn_JsonReports.Name = "btn_JsonReports";
            this.btn_JsonReports.Size = new System.Drawing.Size(88, 39);
            this.btn_JsonReports.TabIndex = 2;
            this.btn_JsonReports.Text = "Create JSON Reports";
            this.btn_JsonReports.UseVisualStyleBackColor = true;
            this.btn_JsonReports.Click += new System.EventHandler(this.btn_JsonReports_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(548, 246);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 38);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_SqliteToExcel);
            this.groupBox6.Location = new System.Drawing.Point(542, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(100, 205);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Problem 8";
            // 
            // btn_SqliteToExcel
            // 
            this.btn_SqliteToExcel.Location = new System.Drawing.Point(6, 158);
            this.btn_SqliteToExcel.Name = "btn_SqliteToExcel";
            this.btn_SqliteToExcel.Size = new System.Drawing.Size(88, 40);
            this.btn_SqliteToExcel.TabIndex = 0;
            this.btn_SqliteToExcel.Text = "SQLite To Excel";
            this.btn_SqliteToExcel.UseVisualStyleBackColor = true;
            this.btn_SqliteToExcel.Click += new System.EventHandler(this.btn_SqliteToExcel_Click);
            // 
            // BottleGreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BottleGreen";
            this.Text = "Team BottleGreen";
            this.Load += new System.EventHandler(this.BottleGreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button PDF_Reports;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_OracleToMssql;
        private System.Windows.Forms.Button btn_JsonReports;
        private System.Windows.Forms.Button btn_ToMongo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_end;
        private System.Windows.Forms.TextBox tx_start;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_SqliteToExcel;
    }
}

