namespace ADONETDisconnectModel
{
    partial class ReadDataFromXMLDocument
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
            this.dtgXML = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXML)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgXML
            // 
            this.dtgXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgXML.Location = new System.Drawing.Point(0, 0);
            this.dtgXML.Name = "dtgXML";
            this.dtgXML.Size = new System.Drawing.Size(633, 375);
            this.dtgXML.TabIndex = 0;
            // 
            // ReadDataFromXMLDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.dtgXML);
            this.Name = "ReadDataFromXMLDocument";
            this.Text = "ReadDataFromXMLDocument";
            this.Load += new System.EventHandler(this.ReadDataFromXMLDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgXML;
    }
}