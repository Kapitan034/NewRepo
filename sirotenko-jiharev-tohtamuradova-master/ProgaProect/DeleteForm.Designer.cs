namespace ProgaProect
{
    partial class DeleteForm
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
            this.DeleteDataTable = new System.Windows.Forms.DataGridView();
            this.DeleteLbl = new System.Windows.Forms.Label();
            this.DeleteItemBTN = new System.Windows.Forms.Button();
            this.DeleteExitBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDataTable
            // 
            this.DeleteDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteDataTable.Location = new System.Drawing.Point(12, 12);
            this.DeleteDataTable.Name = "DeleteDataTable";
            this.DeleteDataTable.Size = new System.Drawing.Size(643, 268);
            this.DeleteDataTable.TabIndex = 0;
            // 
            // DeleteLbl
            // 
            this.DeleteLbl.AutoSize = true;
            this.DeleteLbl.Location = new System.Drawing.Point(95, 297);
            this.DeleteLbl.Name = "DeleteLbl";
            this.DeleteLbl.Size = new System.Drawing.Size(463, 13);
            this.DeleteLbl.TabIndex = 3;
            this.DeleteLbl.Text = "Выберите с помощью курсора и клавиш Ctrl и Shift  строки, которые необходимо удал" +
    "ить.";
            // 
            // DeleteItemBTN
            // 
            this.DeleteItemBTN.Location = new System.Drawing.Point(98, 342);
            this.DeleteItemBTN.Name = "DeleteItemBTN";
            this.DeleteItemBTN.Size = new System.Drawing.Size(128, 50);
            this.DeleteItemBTN.TabIndex = 4;
            this.DeleteItemBTN.Text = "Удалить";
            this.DeleteItemBTN.UseVisualStyleBackColor = true;
            this.DeleteItemBTN.Click += new System.EventHandler(this.DeleteItemBTN_Click);
            // 
            // DeleteExitBTN
            // 
            this.DeleteExitBTN.Location = new System.Drawing.Point(430, 342);
            this.DeleteExitBTN.Name = "DeleteExitBTN";
            this.DeleteExitBTN.Size = new System.Drawing.Size(128, 50);
            this.DeleteExitBTN.TabIndex = 5;
            this.DeleteExitBTN.Text = "Выход";
            this.DeleteExitBTN.UseVisualStyleBackColor = true;
            this.DeleteExitBTN.Click += new System.EventHandler(this.DeleteExitBTN_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 413);
            this.Controls.Add(this.DeleteExitBTN);
            this.Controls.Add(this.DeleteItemBTN);
            this.Controls.Add(this.DeleteLbl);
            this.Controls.Add(this.DeleteDataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление данных";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeleteDataTable;
        private System.Windows.Forms.Label DeleteLbl;
        private System.Windows.Forms.Button DeleteItemBTN;
        private System.Windows.Forms.Button DeleteExitBTN;
    }
}