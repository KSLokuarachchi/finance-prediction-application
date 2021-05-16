namespace W1534169_2019172.view.income
{
    partial class AddIncomeOptionsCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncomeOptionsCtrl));
            this.txtIncomesAmount = new System.Windows.Forms.ComboBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIncomesAmount
            // 
            this.txtIncomesAmount.FormattingEnabled = true;
            this.txtIncomesAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtIncomesAmount.Location = new System.Drawing.Point(435, 57);
            this.txtIncomesAmount.Name = "txtIncomesAmount";
            this.txtIncomesAmount.Size = new System.Drawing.Size(44, 21);
            this.txtIncomesAmount.TabIndex = 19;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddIncome.Location = new System.Drawing.Point(496, 55);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(29, 23);
            this.btnAddIncome.TabIndex = 18;
            this.btnAddIncome.Text = "Go";
            this.btnAddIncome.UseVisualStyleBackColor = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(98, 17);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Please specify the amount of incomes you want to add for the day";
            // 
            // AddIncomeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtIncomesAmount);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddIncomeCtrl";
            this.Size = new System.Drawing.Size(722, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtIncomesAmount;
        public System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
