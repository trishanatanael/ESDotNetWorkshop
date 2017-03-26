namespace ESDotNetWorkshop
{
    partial class Ex1_3
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
            this.lblVidCode = new System.Windows.Forms.Label();
            this.lblMovTitle = new System.Windows.Forms.Label();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.tbxVidCode = new System.Windows.Forms.TextBox();
            this.tbxMovTitle = new System.Windows.Forms.TextBox();
            this.tbxRentalPrice = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxMovieDetails = new System.Windows.Forms.GroupBox();
            this.gbxMovieDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVidCode
            // 
            this.lblVidCode.AutoSize = true;
            this.lblVidCode.Location = new System.Drawing.Point(68, 68);
            this.lblVidCode.Name = "lblVidCode";
            this.lblVidCode.Size = new System.Drawing.Size(202, 25);
            this.lblVidCode.TabIndex = 0;
            this.lblVidCode.Text = "Type a Video Code:";
            // 
            // lblMovTitle
            // 
            this.lblMovTitle.AutoSize = true;
            this.lblMovTitle.Location = new System.Drawing.Point(74, 38);
            this.lblMovTitle.Name = "lblMovTitle";
            this.lblMovTitle.Size = new System.Drawing.Size(123, 25);
            this.lblMovTitle.TabIndex = 1;
            this.lblMovTitle.Text = "Movie Title:";
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Location = new System.Drawing.Point(62, 101);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(135, 25);
            this.lblRentalPrice.TabIndex = 2;
            this.lblRentalPrice.Text = "Rental Price:";
            // 
            // tbxVidCode
            // 
            this.tbxVidCode.Location = new System.Drawing.Point(319, 62);
            this.tbxVidCode.Name = "tbxVidCode";
            this.tbxVidCode.Size = new System.Drawing.Size(345, 31);
            this.tbxVidCode.TabIndex = 3;
            // 
            // tbxMovTitle
            // 
            this.tbxMovTitle.Location = new System.Drawing.Point(243, 32);
            this.tbxMovTitle.Name = "tbxMovTitle";
            this.tbxMovTitle.Size = new System.Drawing.Size(345, 31);
            this.tbxMovTitle.TabIndex = 4;
            // 
            // tbxRentalPrice
            // 
            this.tbxRentalPrice.Location = new System.Drawing.Point(243, 101);
            this.tbxRentalPrice.Name = "tbxRentalPrice";
            this.tbxRentalPrice.Size = new System.Drawing.Size(345, 31);
            this.tbxRentalPrice.TabIndex = 5;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(670, 52);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(223, 51);
            this.btnRetrieve.TabIndex = 6;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(597, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(217, 51);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gbxMovieDetails
            // 
            this.gbxMovieDetails.Controls.Add(this.btnUpdate);
            this.gbxMovieDetails.Controls.Add(this.lblMovTitle);
            this.gbxMovieDetails.Controls.Add(this.lblRentalPrice);
            this.gbxMovieDetails.Controls.Add(this.tbxRentalPrice);
            this.gbxMovieDetails.Controls.Add(this.tbxMovTitle);
            this.gbxMovieDetails.Location = new System.Drawing.Point(73, 173);
            this.gbxMovieDetails.Name = "gbxMovieDetails";
            this.gbxMovieDetails.Size = new System.Drawing.Size(820, 232);
            this.gbxMovieDetails.TabIndex = 8;
            this.gbxMovieDetails.TabStop = false;
            this.gbxMovieDetails.Text = "Movie Details";
            // 
            // Ex1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 605);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.tbxVidCode);
            this.Controls.Add(this.lblVidCode);
            this.Controls.Add(this.gbxMovieDetails);
            this.Name = "Ex1_3";
            this.Text = "Movie Data Screen";

            this.gbxMovieDetails.ResumeLayout(false);
            this.gbxMovieDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVidCode;
        private System.Windows.Forms.Label lblMovTitle;
        private System.Windows.Forms.Label lblRentalPrice;
        private System.Windows.Forms.TextBox tbxVidCode;
        private System.Windows.Forms.TextBox tbxMovTitle;
        private System.Windows.Forms.TextBox tbxRentalPrice;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxMovieDetails;
    }
}