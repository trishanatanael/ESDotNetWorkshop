namespace ESDotNetWorkshop
{
    partial class Ex1_3Difficult
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
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblMemberCategory = new System.Windows.Forms.Label();
            this.tbxCustID = new System.Windows.Forms.TextBox();
            this.tbxCustName = new System.Windows.Forms.TextBox();
            this.tbxMemberCategory = new System.Windows.Forms.TextBox();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.btnFirstCustomer = new System.Windows.Forms.Button();
            this.btnPreviousCustomer = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNextCustomer = new System.Windows.Forms.Button();
            this.btnLastCustomer = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tspStatus = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(95, 173);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(136, 25);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "Customer ID:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(95, 240);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(172, 25);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Customer Name:";
            // 
            // lblMemberCategory
            // 
            this.lblMemberCategory.AutoSize = true;
            this.lblMemberCategory.Location = new System.Drawing.Point(95, 318);
            this.lblMemberCategory.Name = "lblMemberCategory";
            this.lblMemberCategory.Size = new System.Drawing.Size(189, 25);
            this.lblMemberCategory.TabIndex = 2;
            this.lblMemberCategory.Text = "Member Category:";
            // 
            // tbxCustID
            // 
            this.tbxCustID.Location = new System.Drawing.Point(290, 167);
            this.tbxCustID.Name = "tbxCustID";
            this.tbxCustID.Size = new System.Drawing.Size(244, 31);
            this.tbxCustID.TabIndex = 3;
            // 
            // tbxCustName
            // 
            this.tbxCustName.Location = new System.Drawing.Point(290, 234);
            this.tbxCustName.Name = "tbxCustName";
            this.tbxCustName.Size = new System.Drawing.Size(244, 31);
            this.tbxCustName.TabIndex = 4;
            // 
            // tbxMemberCategory
            // 
            this.tbxMemberCategory.Location = new System.Drawing.Point(290, 312);
            this.tbxMemberCategory.Name = "tbxMemberCategory";
            this.tbxMemberCategory.Size = new System.Drawing.Size(244, 31);
            this.tbxMemberCategory.TabIndex = 5;
            // 
            // tbxFind
            // 
            this.tbxFind.Location = new System.Drawing.Point(100, 78);
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(244, 31);
            this.tbxFind.TabIndex = 6;
            // 
            // btnFirstCustomer
            // 
            this.btnFirstCustomer.Location = new System.Drawing.Point(100, 362);
            this.btnFirstCustomer.Name = "btnFirstCustomer";
            this.btnFirstCustomer.Size = new System.Drawing.Size(105, 73);
            this.btnFirstCustomer.TabIndex = 7;
            this.btnFirstCustomer.Text = "<<";
            this.btnFirstCustomer.UseVisualStyleBackColor = true;
            this.btnFirstCustomer.Click += new System.EventHandler(this.btnFirstCustomer_Click);
            // 
            // btnPreviousCustomer
            // 
            this.btnPreviousCustomer.Location = new System.Drawing.Point(211, 362);
            this.btnPreviousCustomer.Name = "btnPreviousCustomer";
            this.btnPreviousCustomer.Size = new System.Drawing.Size(105, 73);
            this.btnPreviousCustomer.TabIndex = 8;
            this.btnPreviousCustomer.Text = "<";
            this.btnPreviousCustomer.UseVisualStyleBackColor = true;
            this.btnPreviousCustomer.Click += new System.EventHandler(this.btnPreviousCustomer_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(601, 125);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 73);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(601, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 73);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(601, 283);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 73);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 73);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNextCustomer
            // 
            this.btnNextCustomer.Location = new System.Drawing.Point(322, 362);
            this.btnNextCustomer.Name = "btnNextCustomer";
            this.btnNextCustomer.Size = new System.Drawing.Size(103, 73);
            this.btnNextCustomer.TabIndex = 13;
            this.btnNextCustomer.Text = ">";
            this.btnNextCustomer.UseVisualStyleBackColor = true;
            this.btnNextCustomer.Click += new System.EventHandler(this.btnNextCustomer_Click);
            // 
            // btnLastCustomer
            // 
            this.btnLastCustomer.Location = new System.Drawing.Point(431, 362);
            this.btnLastCustomer.Name = "btnLastCustomer";
            this.btnLastCustomer.Size = new System.Drawing.Size(103, 73);
            this.btnLastCustomer.TabIndex = 14;
            this.btnLastCustomer.Text = ">>";
            this.btnLastCustomer.UseVisualStyleBackColor = true;
            this.btnLastCustomer.Click += new System.EventHandler(this.btnLastCustomer_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(431, 57);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(103, 73);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tspStatus
            // 
            this.tspStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tspStatus.Location = new System.Drawing.Point(0, 0);
            this.tspStatus.Name = "tspStatus";
            this.tspStatus.Size = new System.Drawing.Size(808, 25);
            this.tspStatus.TabIndex = 16;
            this.tspStatus.Text = "toolStrip1";
            // 
            // Ex1_3Difficult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 581);
            this.Controls.Add(this.tspStatus);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnLastCustomer);
            this.Controls.Add(this.btnNextCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPreviousCustomer);
            this.Controls.Add(this.btnFirstCustomer);
            this.Controls.Add(this.tbxFind);
            this.Controls.Add(this.tbxMemberCategory);
            this.Controls.Add(this.tbxCustName);
            this.Controls.Add(this.tbxCustID);
            this.Controls.Add(this.lblMemberCategory);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustID);
            this.Name = "Ex1_3Difficult";
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.Ex1_3Difficult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblMemberCategory;
        private System.Windows.Forms.TextBox tbxCustID;
        private System.Windows.Forms.TextBox tbxCustName;
        private System.Windows.Forms.TextBox tbxMemberCategory;
        private System.Windows.Forms.TextBox tbxFind;
        private System.Windows.Forms.Button btnFirstCustomer;
        private System.Windows.Forms.Button btnPreviousCustomer;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNextCustomer;
        private System.Windows.Forms.Button btnLastCustomer;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ToolStrip tspStatus;
    }
}