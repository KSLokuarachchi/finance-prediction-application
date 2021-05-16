namespace W1534169_2019172.view.expense
{
    partial class AllExpensesListCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllExpensesListCtrl));
            this.lblExpAmount = new System.Windows.Forms.Label();
            this.lblExpName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExpAmount
            // 
            this.lblExpAmount.AutoSize = true;
            this.lblExpAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblExpAmount.Location = new System.Drawing.Point(628, 12);
            this.lblExpAmount.Name = "lblExpAmount";
            this.lblExpAmount.Size = new System.Drawing.Size(86, 13);
            this.lblExpAmount.TabIndex = 8;
            this.lblExpAmount.Text = "Expense amount";
            // 
            // lblExpName
            // 
            this.lblExpName.AutoSize = true;
            this.lblExpName.BackColor = System.Drawing.Color.Transparent;
            this.lblExpName.Location = new System.Drawing.Point(320, 12);
            this.lblExpName.Name = "lblExpName";
            this.lblExpName.Size = new System.Drawing.Size(77, 13);
            this.lblExpName.TabIndex = 7;
            this.lblExpName.Text = "Expense name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(24, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Expense date";
            // 
            // AllExpensesListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblExpAmount);
            this.Controls.Add(this.lblExpName);
            this.Controls.Add(this.lblDate);
            this.Name = "AllExpensesListCtrl";
            this.Size = new System.Drawing.Size(717, 41);
            this.Load += new System.EventHandler(this.AllExpensesListCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpAmount;
        private System.Windows.Forms.Label lblExpName;
        private System.Windows.Forms.Label lblDate;
    }
}
