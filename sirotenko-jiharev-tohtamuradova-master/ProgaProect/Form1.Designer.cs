namespace ProgaProect
{
    partial class MainForm
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.SearchGB = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToDTP = new System.Windows.Forms.DateTimePicker();
            this.FromDTP = new System.Windows.Forms.DateTimePicker();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.RoomNumberNUM = new System.Windows.Forms.NumericUpDown();
            this.PaspNumberTB = new System.Windows.Forms.TextBox();
            this.BirthdateDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.OtchTB = new System.Windows.Forms.TextBox();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CanselBTN = new System.Windows.Forms.Button();
            this.DataGB = new System.Windows.Forms.GroupBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.AddBTN = new System.Windows.Forms.Button();
            this.MenuGB = new System.Windows.Forms.GroupBox();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.InfoBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SearchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumberNUM)).BeginInit();
            this.DataGB.SuspendLayout();
            this.MenuGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToResizeColumns = false;
            this.DataTable.AllowUserToResizeRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(12, 12);
            this.DataTable.MultiSelect = false;
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(643, 268);
            this.DataTable.TabIndex = 0;
            // 
            // SearchGB
            // 
            this.SearchGB.Controls.Add(this.label9);
            this.SearchGB.Controls.Add(this.label8);
            this.SearchGB.Controls.Add(this.label7);
            this.SearchGB.Controls.Add(this.label6);
            this.SearchGB.Controls.Add(this.SearchBTN);
            this.SearchGB.Controls.Add(this.ClearBTN);
            this.SearchGB.Controls.Add(this.label5);
            this.SearchGB.Controls.Add(this.label4);
            this.SearchGB.Controls.Add(this.label3);
            this.SearchGB.Controls.Add(this.label2);
            this.SearchGB.Controls.Add(this.ToDTP);
            this.SearchGB.Controls.Add(this.FromDTP);
            this.SearchGB.Controls.Add(this.TypeCB);
            this.SearchGB.Controls.Add(this.RoomNumberNUM);
            this.SearchGB.Controls.Add(this.PaspNumberTB);
            this.SearchGB.Controls.Add(this.BirthdateDTP);
            this.SearchGB.Controls.Add(this.label1);
            this.SearchGB.Controls.Add(this.OtchTB);
            this.SearchGB.Controls.Add(this.SurnameTb);
            this.SearchGB.Controls.Add(this.NameTB);
            this.SearchGB.Controls.Add(this.CanselBTN);
            this.SearchGB.Location = new System.Drawing.Point(35, 286);
            this.SearchGB.Name = "SearchGB";
            this.SearchGB.Size = new System.Drawing.Size(328, 216);
            this.SearchGB.TabIndex = 1;
            this.SearchGB.TabStop = false;
            this.SearchGB.Text = "Поиск";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "по";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Время пребывания:  с";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Тип номера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Комната №";
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(247, 16);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 30);
            this.SearchBTN.TabIndex = 0;
            this.SearchBTN.Text = "Искать";
            this.SearchBTN.UseVisualStyleBackColor = true;
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(247, 64);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 30);
            this.ClearBTN.TabIndex = 1;
            this.ClearBTN.Text = "Очистить";
            this.ClearBTN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Фамилия";
            // 
            // ToDTP
            // 
            this.ToDTP.Location = new System.Drawing.Point(139, 192);
            this.ToDTP.Name = "ToDTP";
            this.ToDTP.Size = new System.Drawing.Size(138, 20);
            this.ToDTP.TabIndex = 12;
            // 
            // FromDTP
            // 
            this.FromDTP.Location = new System.Drawing.Point(139, 170);
            this.FromDTP.Name = "FromDTP";
            this.FromDTP.Size = new System.Drawing.Size(138, 20);
            this.FromDTP.TabIndex = 11;
            this.FromDTP.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // TypeCB
            // 
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(235, 145);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(74, 21);
            this.TypeCB.TabIndex = 10;
            // 
            // RoomNumberNUM
            // 
            this.RoomNumberNUM.Location = new System.Drawing.Point(98, 146);
            this.RoomNumberNUM.Name = "RoomNumberNUM";
            this.RoomNumberNUM.Size = new System.Drawing.Size(57, 20);
            this.RoomNumberNUM.TabIndex = 9;
            this.RoomNumberNUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaspNumberTB
            // 
            this.PaspNumberTB.Location = new System.Drawing.Point(98, 120);
            this.PaspNumberTB.Name = "PaspNumberTB";
            this.PaspNumberTB.Size = new System.Drawing.Size(138, 20);
            this.PaspNumberTB.TabIndex = 8;
            // 
            // BirthdateDTP
            // 
            this.BirthdateDTP.Location = new System.Drawing.Point(98, 94);
            this.BirthdateDTP.Name = "BirthdateDTP";
            this.BirthdateDTP.Size = new System.Drawing.Size(138, 20);
            this.BirthdateDTP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // OtchTB
            // 
            this.OtchTB.Location = new System.Drawing.Point(98, 68);
            this.OtchTB.Name = "OtchTB";
            this.OtchTB.Size = new System.Drawing.Size(138, 20);
            this.OtchTB.TabIndex = 5;
            // 
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(98, 16);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(138, 20);
            this.SurnameTb.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(98, 42);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(138, 20);
            this.NameTB.TabIndex = 3;
            // 
            // CanselBTN
            // 
            this.CanselBTN.Location = new System.Drawing.Point(247, 110);
            this.CanselBTN.Name = "CanselBTN";
            this.CanselBTN.Size = new System.Drawing.Size(75, 31);
            this.CanselBTN.TabIndex = 2;
            this.CanselBTN.Text = "Сбросить";
            this.CanselBTN.UseVisualStyleBackColor = true;
            // 
            // DataGB
            // 
            this.DataGB.Controls.Add(this.DeleteBTN);
            this.DataGB.Controls.Add(this.ChangeBTN);
            this.DataGB.Controls.Add(this.AddBTN);
            this.DataGB.Location = new System.Drawing.Point(432, 286);
            this.DataGB.Name = "DataGB";
            this.DataGB.Size = new System.Drawing.Size(186, 132);
            this.DataGB.TabIndex = 2;
            this.DataGB.TabStop = false;
            this.DataGB.Text = "Редактирование данных";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(6, 99);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(174, 23);
            this.DeleteBTN.TabIndex = 2;
            this.DeleteBTN.Text = "Удаление данных";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Location = new System.Drawing.Point(6, 61);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(174, 23);
            this.ChangeBTN.TabIndex = 1;
            this.ChangeBTN.Text = "Изменение данных";
            this.ChangeBTN.UseVisualStyleBackColor = true;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(6, 19);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(174, 23);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Добавление данных";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // MenuGB
            // 
            this.MenuGB.Controls.Add(this.ExitBTN);
            this.MenuGB.Controls.Add(this.InfoBTN);
            this.MenuGB.Location = new System.Drawing.Point(394, 426);
            this.MenuGB.Name = "MenuGB";
            this.MenuGB.Size = new System.Drawing.Size(261, 76);
            this.MenuGB.TabIndex = 3;
            this.MenuGB.TabStop = false;
            this.MenuGB.Text = "Меню";
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(145, 19);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(110, 51);
            this.ExitBTN.TabIndex = 1;
            this.ExitBTN.Text = "Выход";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // InfoBTN
            // 
            this.InfoBTN.Location = new System.Drawing.Point(6, 19);
            this.InfoBTN.Name = "InfoBTN";
            this.InfoBTN.Size = new System.Drawing.Size(110, 51);
            this.InfoBTN.TabIndex = 0;
            this.InfoBTN.Text = "Справка";
            this.InfoBTN.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 514);
            this.Controls.Add(this.MenuGB);
            this.Controls.Add(this.DataGB);
            this.Controls.Add(this.SearchGB);
            this.Controls.Add(this.DataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных для гостиницы";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.SearchGB.ResumeLayout(false);
            this.SearchGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumberNUM)).EndInit();
            this.DataGB.ResumeLayout(false);
            this.MenuGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.GroupBox SearchGB;
        private System.Windows.Forms.TextBox OtchTB;
        private System.Windows.Forms.TextBox SurnameTb;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button CanselBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.GroupBox DataGB;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button ChangeBTN;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.GroupBox MenuGB;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button InfoBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ToDTP;
        private System.Windows.Forms.DateTimePicker FromDTP;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.NumericUpDown RoomNumberNUM;
        private System.Windows.Forms.TextBox PaspNumberTB;
        private System.Windows.Forms.DateTimePicker BirthdateDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

