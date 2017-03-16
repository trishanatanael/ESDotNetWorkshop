namespace ESDotNetWorkshop
{
    partial class frmRetrieveAll
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
            this.btnRetrieveAll = new System.Windows.Forms.Button();
            this.dgvAllMovies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetrieveAll
            // 
            this.btnRetrieveAll.Location = new System.Drawing.Point(22, 35);
            this.btnRetrieveAll.Name = "btnRetrieveAll";
            this.btnRetrieveAll.Size = new System.Drawing.Size(583, 55);
            this.btnRetrieveAll.TabIndex = 0;
            this.btnRetrieveAll.Text = "Retrieve All";
            this.btnRetrieveAll.UseVisualStyleBackColor = true;
            // 
            // dgvAllMovies
            // 
            this.dgvAllMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMovies.Location = new System.Drawing.Point(22, 96);
            this.dgvAllMovies.Name = "dgvAllMovies";
            this.dgvAllMovies.RowTemplate.Height = 33;
            this.dgvAllMovies.Size = new System.Drawing.Size(583, 388);
            this.dgvAllMovies.TabIndex = 1;
            // 
            // frmRetrieveAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 515);
            this.Controls.Add(this.dgvAllMovies);
            this.Controls.Add(this.btnRetrieveAll);
            this.Name = "frmRetrieveAll";
            this.Text = "Retrieve All From Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveAll;
        private System.Windows.Forms.DataGridView dgvAllMovies;
    }
}