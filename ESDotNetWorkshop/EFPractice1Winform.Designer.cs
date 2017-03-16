namespace ESDotNetWorkshop
{
    partial class EFPractice1Winform
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
            this.btnByMovTitleAsc = new System.Windows.Forms.Button();
            this.btnByRPDesc = new System.Windows.Forms.Button();
            this.btnRetrieveRRated = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetrieveAll
            // 
            this.btnRetrieveAll.Location = new System.Drawing.Point(52, 44);
            this.btnRetrieveAll.Name = "btnRetrieveAll";
            this.btnRetrieveAll.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveAll.TabIndex = 0;
            this.btnRetrieveAll.Text = "Retrieve All";
            this.btnRetrieveAll.UseVisualStyleBackColor = true;
            this.btnRetrieveAll.Click += new System.EventHandler(this.btnRetrieveAll_Click);
            // 
            // dgvAllMovies
            // 
            this.dgvAllMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMovies.Location = new System.Drawing.Point(497, 44);
            this.dgvAllMovies.Name = "dgvAllMovies";
            this.dgvAllMovies.RowTemplate.Height = 33;
            this.dgvAllMovies.Size = new System.Drawing.Size(1573, 1196);
            this.dgvAllMovies.TabIndex = 1;
            // 
            // btnByMovTitleAsc
            // 
            this.btnByMovTitleAsc.Location = new System.Drawing.Point(52, 105);
            this.btnByMovTitleAsc.Name = "btnByMovTitleAsc";
            this.btnByMovTitleAsc.Size = new System.Drawing.Size(397, 55);
            this.btnByMovTitleAsc.TabIndex = 2;
            this.btnByMovTitleAsc.Text = "Movies (Sort by Movie Title ASC)";
            this.btnByMovTitleAsc.UseVisualStyleBackColor = true;
            this.btnByMovTitleAsc.Click += new System.EventHandler(this.btnByMovTitleAsc_Click);
            // 
            // btnByRPDesc
            // 
            this.btnByRPDesc.Location = new System.Drawing.Point(52, 166);
            this.btnByRPDesc.Name = "btnByRPDesc";
            this.btnByRPDesc.Size = new System.Drawing.Size(397, 55);
            this.btnByRPDesc.TabIndex = 3;
            this.btnByRPDesc.Text = "Movies (Sort by Rental Price DESC)";
            this.btnByRPDesc.UseVisualStyleBackColor = true;
            this.btnByRPDesc.Click += new System.EventHandler(this.btnByRPDesc_Click);
            // 
            // btnRetrieveRRated
            // 
            this.btnRetrieveRRated.Location = new System.Drawing.Point(52, 227);
            this.btnRetrieveRRated.Name = "btnRetrieveRRated";
            this.btnRetrieveRRated.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveRRated.TabIndex = 4;
            this.btnRetrieveRRated.Text = "Retrieve All \'R\' Rated";
            this.btnRetrieveRRated.UseVisualStyleBackColor = true;
            this.btnRetrieveRRated.Click += new System.EventHandler(this.btnRetrieveRRated_Click);
            // 
            // EFPractice1Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2107, 1285);
            this.Controls.Add(this.btnRetrieveRRated);
            this.Controls.Add(this.btnByRPDesc);
            this.Controls.Add(this.btnByMovTitleAsc);
            this.Controls.Add(this.dgvAllMovies);
            this.Controls.Add(this.btnRetrieveAll);
            this.Name = "EFPractice1Winform";
            this.Text = "Retrieve All From Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveAll;
        private System.Windows.Forms.DataGridView dgvAllMovies;
        private System.Windows.Forms.Button btnByMovTitleAsc;
        private System.Windows.Forms.Button btnByRPDesc;
        private System.Windows.Forms.Button btnRetrieveRRated;
    }
}