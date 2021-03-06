﻿namespace ESDotNetWorkshop
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
            this.btnRetrieveAllSciFicbyWarner = new System.Windows.Forms.Button();
            this.btnTotalActMov = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnTotalStockofActMov = new System.Windows.Forms.Button();
            this.btnAvgPriceComMov = new System.Windows.Forms.Button();
            this.btnRetrieveRRated3Col = new System.Windows.Forms.Button();
            this.btnTotalStockofMov = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnRetrieveAllbyWaltDisney = new System.Windows.Forms.Button();
            this.btnRetrieveAll4Col = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetrieveAll
            // 
            this.btnRetrieveAll.Location = new System.Drawing.Point(40, 111);
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
            this.dgvAllMovies.Location = new System.Drawing.Point(481, 105);
            this.dgvAllMovies.Name = "dgvAllMovies";
            this.dgvAllMovies.RowTemplate.Height = 33;
            this.dgvAllMovies.Size = new System.Drawing.Size(1733, 1274);
            this.dgvAllMovies.TabIndex = 1;
            // 
            // btnByMovTitleAsc
            // 
            this.btnByMovTitleAsc.Location = new System.Drawing.Point(40, 172);
            this.btnByMovTitleAsc.Name = "btnByMovTitleAsc";
            this.btnByMovTitleAsc.Size = new System.Drawing.Size(397, 55);
            this.btnByMovTitleAsc.TabIndex = 2;
            this.btnByMovTitleAsc.Text = "Movies (Sort by Movie Title ASC)";
            this.btnByMovTitleAsc.UseVisualStyleBackColor = true;
            this.btnByMovTitleAsc.Click += new System.EventHandler(this.btnByMovTitleAsc_Click);
            // 
            // btnByRPDesc
            // 
            this.btnByRPDesc.Location = new System.Drawing.Point(40, 233);
            this.btnByRPDesc.Name = "btnByRPDesc";
            this.btnByRPDesc.Size = new System.Drawing.Size(397, 55);
            this.btnByRPDesc.TabIndex = 3;
            this.btnByRPDesc.Text = "Movies (Sort by Rental Price DESC)";
            this.btnByRPDesc.UseVisualStyleBackColor = true;
            this.btnByRPDesc.Click += new System.EventHandler(this.btnByRPDesc_Click);
            // 
            // btnRetrieveRRated
            // 
            this.btnRetrieveRRated.Location = new System.Drawing.Point(40, 294);
            this.btnRetrieveRRated.Name = "btnRetrieveRRated";
            this.btnRetrieveRRated.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveRRated.TabIndex = 4;
            this.btnRetrieveRRated.Text = "Retrieve All \'R\' Rated";
            this.btnRetrieveRRated.UseVisualStyleBackColor = true;
            this.btnRetrieveRRated.Click += new System.EventHandler(this.btnRetrieveRRated_Click);
            // 
            // btnRetrieveAllSciFicbyWarner
            // 
            this.btnRetrieveAllSciFicbyWarner.Location = new System.Drawing.Point(40, 355);
            this.btnRetrieveAllSciFicbyWarner.Name = "btnRetrieveAllSciFicbyWarner";
            this.btnRetrieveAllSciFicbyWarner.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveAllSciFicbyWarner.TabIndex = 5;
            this.btnRetrieveAllSciFicbyWarner.Text = "Retrieve All SciFic by Warner";
            this.btnRetrieveAllSciFicbyWarner.UseVisualStyleBackColor = true;
            this.btnRetrieveAllSciFicbyWarner.Click += new System.EventHandler(this.btnRetrieveAllSciFicbyWarner_Click);
            // 
            // btnTotalActMov
            // 
            this.btnTotalActMov.Location = new System.Drawing.Point(40, 416);
            this.btnTotalActMov.Name = "btnTotalActMov";
            this.btnTotalActMov.Size = new System.Drawing.Size(397, 55);
            this.btnTotalActMov.TabIndex = 6;
            this.btnTotalActMov.Text = "Total Action Movies";
            this.btnTotalActMov.UseVisualStyleBackColor = true;
            this.btnTotalActMov.Click += new System.EventHandler(this.btnTotalActMov_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(476, 44);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(194, 25);
            this.lblShow.TabIndex = 7;
            this.lblShow.Text = "Will be shown here";
            // 
            // btnTotalStockofActMov
            // 
            this.btnTotalStockofActMov.Location = new System.Drawing.Point(40, 477);
            this.btnTotalStockofActMov.Name = "btnTotalStockofActMov";
            this.btnTotalStockofActMov.Size = new System.Drawing.Size(397, 55);
            this.btnTotalStockofActMov.TabIndex = 8;
            this.btnTotalStockofActMov.Text = "Total Stock of Action Movies";
            this.btnTotalStockofActMov.UseVisualStyleBackColor = true;
            this.btnTotalStockofActMov.Click += new System.EventHandler(this.btnTotalStockofActMov_Click);
            // 
            // btnAvgPriceComMov
            // 
            this.btnAvgPriceComMov.Location = new System.Drawing.Point(40, 538);
            this.btnAvgPriceComMov.Name = "btnAvgPriceComMov";
            this.btnAvgPriceComMov.Size = new System.Drawing.Size(397, 55);
            this.btnAvgPriceComMov.TabIndex = 9;
            this.btnAvgPriceComMov.Text = "Avg. Price for Comedy Movie";
            this.btnAvgPriceComMov.UseVisualStyleBackColor = true;
            this.btnAvgPriceComMov.Click += new System.EventHandler(this.btnAvgPriceComMov_Click);
            // 
            // btnRetrieveRRated3Col
            // 
            this.btnRetrieveRRated3Col.Location = new System.Drawing.Point(40, 599);
            this.btnRetrieveRRated3Col.Name = "btnRetrieveRRated3Col";
            this.btnRetrieveRRated3Col.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveRRated3Col.TabIndex = 10;
            this.btnRetrieveRRated3Col.Text = "Retrieve All \'R\' Rated (3 Columns Only)";
            this.btnRetrieveRRated3Col.UseVisualStyleBackColor = true;
            this.btnRetrieveRRated3Col.Click += new System.EventHandler(this.btnRetrieveRRated3Col_Click);
            // 
            // btnTotalStockofMov
            // 
            this.btnTotalStockofMov.Location = new System.Drawing.Point(40, 660);
            this.btnTotalStockofMov.Name = "btnTotalStockofMov";
            this.btnTotalStockofMov.Size = new System.Drawing.Size(397, 55);
            this.btnTotalStockofMov.TabIndex = 11;
            this.btnTotalStockofMov.Text = "Total Stock of Movies";
            this.btnTotalStockofMov.UseVisualStyleBackColor = true;
            this.btnTotalStockofMov.Click += new System.EventHandler(this.btnTotalStockofMov_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(40, 857);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(397, 51);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnRetrieveAllbyWaltDisney
            // 
            this.btnRetrieveAllbyWaltDisney.Location = new System.Drawing.Point(40, 914);
            this.btnRetrieveAllbyWaltDisney.Name = "btnRetrieveAllbyWaltDisney";
            this.btnRetrieveAllbyWaltDisney.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveAllbyWaltDisney.TabIndex = 13;
            this.btnRetrieveAllbyWaltDisney.Text = "Retrieve All by Walt Disney";
            this.btnRetrieveAllbyWaltDisney.UseVisualStyleBackColor = true;
            this.btnRetrieveAllbyWaltDisney.Click += new System.EventHandler(this.btnRetrieveAllbyWaltDisney_Click);
            // 
            // btnRetrieveAll4Col
            // 
            this.btnRetrieveAll4Col.Location = new System.Drawing.Point(40, 975);
            this.btnRetrieveAll4Col.Name = "btnRetrieveAll4Col";
            this.btnRetrieveAll4Col.Size = new System.Drawing.Size(397, 55);
            this.btnRetrieveAll4Col.TabIndex = 14;
            this.btnRetrieveAll4Col.Text = "Retrieve All in 4 Columns";
            this.btnRetrieveAll4Col.UseVisualStyleBackColor = true;
            this.btnRetrieveAll4Col.Click += new System.EventHandler(this.btnRetrieveAll4Col_Click);
            // 
            // EFPractice1Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2259, 1419);
            this.Controls.Add(this.btnRetrieveAll4Col);
            this.Controls.Add(this.btnRetrieveAllbyWaltDisney);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnTotalStockofMov);
            this.Controls.Add(this.btnRetrieveRRated3Col);
            this.Controls.Add(this.btnAvgPriceComMov);
            this.Controls.Add(this.btnTotalStockofActMov);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnTotalActMov);
            this.Controls.Add(this.btnRetrieveAllSciFicbyWarner);
            this.Controls.Add(this.btnRetrieveRRated);
            this.Controls.Add(this.btnByRPDesc);
            this.Controls.Add(this.btnByMovTitleAsc);
            this.Controls.Add(this.dgvAllMovies);
            this.Controls.Add(this.btnRetrieveAll);
            this.Name = "EFPractice1Winform";
            this.Text = "Retrieve All in Grid (4 Columns)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveAll;
        private System.Windows.Forms.DataGridView dgvAllMovies;
        private System.Windows.Forms.Button btnByMovTitleAsc;
        private System.Windows.Forms.Button btnByRPDesc;
        private System.Windows.Forms.Button btnRetrieveRRated;
        private System.Windows.Forms.Button btnRetrieveAllSciFicbyWarner;
        private System.Windows.Forms.Button btnTotalActMov;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnTotalStockofActMov;
        private System.Windows.Forms.Button btnAvgPriceComMov;
        private System.Windows.Forms.Button btnRetrieveRRated3Col;
        private System.Windows.Forms.Button btnTotalStockofMov;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnRetrieveAllbyWaltDisney;
        private System.Windows.Forms.Button btnRetrieveAll4Col;
    }
}