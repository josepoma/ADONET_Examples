namespace ADONETDisconnectModel
{
    partial class DisplayingDataFromExcelSheets
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
            this.dtgExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgExcel
            // 
            this.dtgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgExcel.Location = new System.Drawing.Point(0, 0);
            this.dtgExcel.Name = "dtgExcel";
            this.dtgExcel.Size = new System.Drawing.Size(700, 403);
            this.dtgExcel.TabIndex = 0;
            // 
            // DisplayingDataFromExcelSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 403);
            this.Controls.Add(this.dtgExcel);
            this.Name = "DisplayingDataFromExcelSheets";
            this.Text = "DisplayingDataFromExcelSheets";
            this.Load += new System.EventHandler(this.DisplayingDataFromExcelSheets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgExcel;
    }
}