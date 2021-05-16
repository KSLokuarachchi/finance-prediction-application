namespace W1534169_2019172.view.income
{
    partial class AllIncomesCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllIncomesCtrl));
            this.btnDeleteInc = new System.Windows.Forms.Button();
            this.btnUpdateInc = new System.Windows.Forms.Button();
            this.btnEditPayer = new System.Windows.Forms.Button();
            this.lblIncAmount = new System.Windows.Forms.Label();
            this.lblIncName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteInc
            // 
            this.btnDeleteInc.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteInc.Location = new System.Drawing.Point(630, 12);
            this.btnDeleteInc.Name = "btnDeleteInc";
            this.btnDeleteInc.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteInc.TabIndex = 11;
            this.btnDeleteInc.Text = "Delete";
            this.btnDeleteInc.UseVisualStyleBackColor = false;
            this.btnDeleteInc.Click += new System.EventHandler(this.btnDeleteInc_Click);
            // 
            // btnUpdateInc
            // 
            this.btnUpdateInc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateInc.Location = new System.Drawing.Point(549, 12);
            this.btnUpdateInc.Name = "btnUpdateInc";
            this.btnUpdateInc.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateInc.TabIndex = 10;
            this.btnUpdateInc.Text = "Edit";
            this.btnUpdateInc.UseVisualStyleBackColor = false;
            this.btnUpdateInc.Click += new System.EventHandler(this.btnUpdateInc_Click);
            // 
            // btnEditPayer
            // 
            this.btnEditPayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditPayer.Location = new System.Drawing.Point(431, 12);
            this.btnEditPayer.Name = "btnEditPayer";
            this.btnEditPayer.Size = new System.Drawing.Size(75, 23);
            this.btnEditPayer.TabIndex = 9;
            this.btnEditPayer.Text = "Payer";
            this.btnEditPayer.UseVisualStyleBackColor = false;
            this.btnEditPayer.Click += new System.EventHandler(this.btnEditPayer_Click);
            // 
            // lblIncAmount
            // 
            this.lblIncAmount.AutoSize = true;
            this.lblIncAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblIncAmount.Location = new System.Drawing.Point(328, 17);
            this.lblIncAmount.Name = "lblIncAmount";
            this.lblIncAmount.Size = new System.Drawing.Size(0, 13);
            this.lblIncAmount.TabIndex = 8;
            // 
            // lblIncName
            // 
            this.lblIncName.AutoSize = true;
            this.lblIncName.BackColor = System.Drawing.Color.Transparent;
            this.lblIncName.Location = new System.Drawing.Point(194, 17);
            this.lblIncName.Name = "lblIncName";
            this.lblIncName.Size = new System.Drawing.Size(0, 13);
            this.lblIncName.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(17, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 6;
            // 
            // AllIncomesCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnDeleteInc);
            this.Controls.Add(this.btnUpdateInc);
            this.Controls.Add(this.btnEditPayer);
            this.Controls.Add(this.lblIncAmount);
            this.Controls.Add(this.lblIncName);
            this.Controls.Add(this.lblDate);
            this.Name = "AllIncomesCtrl";
            this.Size = new System.Drawing.Size(722, 47);
            this.Load += new System.EventHandler(this.AllIncomesCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteInc;
        private System.Windows.Forms.Button btnUpdateInc;
        private System.Windows.Forms.Button btnEditPayer;
        private System.Windows.Forms.Label lblIncAmount;
        private System.Windows.Forms.Label lblIncName;
        private System.Windows.Forms.Label lblDate;
    }
}
