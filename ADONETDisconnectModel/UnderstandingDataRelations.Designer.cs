namespace ADONETDisconnectModel
{
    partial class UnderstandingDataRelations
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
            this.dtgParent = new System.Windows.Forms.DataGridView();
            this.dtgChild = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChild)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgParent
            // 
            this.dtgParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParent.Location = new System.Drawing.Point(12, 12);
            this.dtgParent.Name = "dtgParent";
            this.dtgParent.Size = new System.Drawing.Size(694, 185);
            this.dtgParent.TabIndex = 0;
            this.dtgParent.SelectionChanged += new System.EventHandler(this.dtgParent_SelectionChanged);
            // 
            // dtgChild
            // 
            this.dtgChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChild.Location = new System.Drawing.Point(12, 214);
            this.dtgChild.Name = "dtgChild";
            this.dtgChild.Size = new System.Drawing.Size(694, 208);
            this.dtgChild.TabIndex = 1;
            this.dtgChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CargarProductosporCategoria);
            // 
            // UnderstandingDataRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 434);
            this.Controls.Add(this.dtgChild);
            this.Controls.Add(this.dtgParent);
            this.Name = "UnderstandingDataRelations";
            this.Text = "UnderstandingDataRelations";
            this.Load += new System.EventHandler(this.UnderstandingDataRelations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgParent;
        private System.Windows.Forms.DataGridView dtgChild;
    }
}