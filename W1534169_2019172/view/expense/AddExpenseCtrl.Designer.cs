namespace W1534169_2019172.view.expense
{
    partial class AddExpenseCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpenseCtrl));
            this.txtExpName = new System.Windows.Forms.TextBox();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.btnAddPayee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpName
            // 
            this.txtExpName.Location = new System.Drawing.Point(57, 9);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(129, 20);
            this.txtExpName.TabIndex = 0;
            this.txtExpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpName_KeyPress);
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Location = new System.Drawing.Point(271, 9);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(142, 20);
            this.txtExpAmount.TabIndex = 1;
            this.txtExpAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpAmount_KeyPress);
            // 
            // btnAddPayee
            // 
            this.btnAddPayee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPayee.Location = new System.Drawing.Point(454, 6);
            this.btnAddPayee.Name = "btnAddPayee";
            this.btnAddPayee.Size = new System.Drawing.Size(106, 23);
            this.btnAddPayee.TabIndex = 2;
            this.btnAddPayee.Text = "Add Payee";
            this.btnAddPayee.UseVisualStyleBackColor = false;
            this.btnAddPayee.Click += new System.EventHandler(this.btnAddPayee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // ExpenseCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPayee);
            this.Controls.Add(this.txtExpAmount);
            this.Controls.Add(this.txtExpName);
            this.Name = "ExpenseCtrl";
            this.Size = new System.Drawing.Size(577, 37);
            this.Load += new System.EventHandler(this.ExpenseCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpName;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.Button btnAddPayee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
