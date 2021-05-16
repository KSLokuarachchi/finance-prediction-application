namespace W1534169_2019172.view.income
{
    partial class AddIncomeCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncomeCtrl));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPayer = new System.Windows.Forms.Button();
            this.txtIncAmount = new System.Windows.Forms.TextBox();
            this.txtIncName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btnAddPayer
            // 
            this.btnAddPayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPayer.Location = new System.Drawing.Point(452, 7);
            this.btnAddPayer.Name = "btnAddPayer";
            this.btnAddPayer.Size = new System.Drawing.Size(106, 23);
            this.btnAddPayer.TabIndex = 7;
            this.btnAddPayer.Text = "Add Payer";
            this.btnAddPayer.UseVisualStyleBackColor = false;
            this.btnAddPayer.Click += new System.EventHandler(this.btnAddPayer_Click);
            // 
            // txtIncAmount
            // 
            this.txtIncAmount.Location = new System.Drawing.Point(269, 10);
            this.txtIncAmount.Name = "txtIncAmount";
            this.txtIncAmount.Size = new System.Drawing.Size(142, 20);
            this.txtIncAmount.TabIndex = 6;
            this.txtIncAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncAmount_KeyPress);
            // 
            // txtIncName
            // 
            this.txtIncName.Location = new System.Drawing.Point(55, 10);
            this.txtIncName.Name = "txtIncName";
            this.txtIncName.Size = new System.Drawing.Size(129, 20);
            this.txtIncName.TabIndex = 5;
            this.txtIncName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncName_KeyPress);
            // 
            // IncomeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPayer);
            this.Controls.Add(this.txtIncAmount);
            this.Controls.Add(this.txtIncName);
            this.Name = "IncomeCtrl";
            this.Size = new System.Drawing.Size(577, 37);
            this.Load += new System.EventHandler(this.IncomeCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPayer;
        private System.Windows.Forms.TextBox txtIncAmount;
        private System.Windows.Forms.TextBox txtIncName;
    }
}
