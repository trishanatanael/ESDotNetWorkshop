namespace ESDotNetWorkshop
{
    partial class Ex1_2
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
            this.lbxMovieList = new System.Windows.Forms.ListBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxMovieList
            // 
            this.lbxMovieList.FormattingEnabled = true;
            this.lbxMovieList.ItemHeight = 25;
            this.lbxMovieList.Location = new System.Drawing.Point(45, 33);
            this.lbxMovieList.Name = "lbxMovieList";
            this.lbxMovieList.Size = new System.Drawing.Size(310, 179);
            this.lbxMovieList.TabIndex = 0;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(45, 237);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(310, 68);
            this.btnRetrieve.TabIndex = 1;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // Ex1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 401);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lbxMovieList);
            this.Name = "Ex1_2";
            this.Text = "List of Movies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMovieList;
        private System.Windows.Forms.Button btnRetrieve;
    }
}