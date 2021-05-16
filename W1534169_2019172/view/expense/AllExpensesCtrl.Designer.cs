namespace W1534169_2019172.view.expense
{
    partial class AllExpensesCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllExpensesCtrl));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblExpName = new System.Windows.Forms.Label();
            this.lblExpAmount = new System.Windows.Forms.Label();
            this.btnEditPayee = new System.Windows.Forms.Button();
            this.btnUpdateExp = new System.Windows.Forms.Button();
            this.btnDeleteExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(21, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 0;
            // 
            // lblExpName
            // 
            this.lblExpName.AutoSize = true;
            this.lblExpName.BackColor = System.Drawing.Color.Transparent;
            this.lblExpName.Location = new System.Drawing.Point(198, 18);
            this.lblExpName.Name = "lblExpName";
            this.lblExpName.Size = new System.Drawing.Size(0, 13);
            this.lblExpName.TabIndex = 1;
            // 
            // lblExpAmount
            // 
            this.lblExpAmount.AutoSize = true;
            this.lblExpAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblExpAmount.Location = new System.Drawing.Point(332, 18);
            this.lblExpAmount.Name = "lblExpAmount";
            this.lblExpAmount.Size = new System.Drawing.Size(0, 13);
            this.lblExpAmount.TabIndex = 2;
            // 
            // btnEditPayee
            // 
            this.btnEditPayee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditPayee.Location = new System.Drawing.Point(435, 13);
            this.btnEditPayee.Name = "btnEditPayee";
            this.btnEditPayee.Size = new System.Drawing.Size(75, 23);
            this.btnEditPayee.TabIndex = 3;
            this.btnEditPayee.Text = "Payee";
            this.btnEditPayee.UseVisualStyleBackColor = false;
            this.btnEditPayee.Click += new System.EventHandler(this.btnEditPayee_Click);
            // 
            // btnUpdateExp
            // 
            this.btnUpdateExp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateExp.Location = new System.Drawing.Point(553, 13);
            this.btnUpdateExp.Name = "btnUpdateExp";
            this.btnUpdateExp.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateExp.TabIndex = 4;
            this.btnUpdateExp.Text = "Edit";
            this.btnUpdateExp.UseVisualStyleBackColor = false;
            this.btnUpdateExp.Click += new System.EventHandler(this.btnUpdateExp_Click);
            // 
            // btnDeleteExp
            // 
            this.btnDeleteExp.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteExp.Location = new System.Drawing.Point(634, 13);
            this.btnDeleteExp.Name = "btnDeleteExp";
            this.btnDeleteExp.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteExp.TabIndex = 5;
            this.btnDeleteExp.Text = "Delete";
            this.btnDeleteExp.UseVisualStyleBackColor = false;
            this.btnDeleteExp.Click += new System.EventHandler(this.btnDeleteExp_Click);
            // 
            // AllExpensesCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnDeleteExp);
            this.Controls.Add(this.btnUpdateExp);
            this.Controls.Add(this.btnEditPayee);
            this.Controls.Add(this.lblExpAmount);
            this.Controls.Add(this.lblExpName);
            this.Controls.Add(this.lblDate);
            this.Name = "AllExpensesCtrl";
            this.Size = new System.Drawing.Size(722, 47);
            this.Load += new System.EventHandler(this.AllExpensesCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblExpName;
        private System.Windows.Forms.Label lblExpAmount;
        private System.Windows.Forms.Button btnEditPayee;
        private System.Windows.Forms.Button btnUpdateExp;
        private System.Windows.Forms.Button btnDeleteExp;
    }
}
