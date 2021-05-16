namespace W1534169_2019172.view.income
{
    partial class EditIncomesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIncomesView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateUpdated = new System.Windows.Forms.DateTimePicker();
            this.txtAmountUpdated = new System.Windows.Forms.TextBox();
            this.txtNameUpdated = new System.Windows.Forms.TextBox();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // txtDateUpdated
            // 
            this.txtDateUpdated.Location = new System.Drawing.Point(112, 35);
            this.txtDateUpdated.Name = "txtDateUpdated";
            this.txtDateUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtDateUpdated.TabIndex = 30;
            // 
            // txtAmountUpdated
            // 
            this.txtAmountUpdated.Location = new System.Drawing.Point(112, 135);
            this.txtAmountUpdated.Name = "txtAmountUpdated";
            this.txtAmountUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtAmountUpdated.TabIndex = 29;
            // 
            // txtNameUpdated
            // 
            this.txtNameUpdated.Location = new System.Drawing.Point(112, 85);
            this.txtNameUpdated.Name = "txtNameUpdated";
            this.txtNameUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtNameUpdated.TabIndex = 28;
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateExpense.Location = new System.Drawing.Point(147, 195);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateExpense.TabIndex = 27;
            this.btnUpdateExpense.Text = "Update";
            this.btnUpdateExpense.UseVisualStyleBackColor = false;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date";
            // 
            // EditIncomesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateUpdated);
            this.Controls.Add(this.txtAmountUpdated);
            this.Controls.Add(this.txtNameUpdated);
            this.Controls.Add(this.btnUpdateExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditIncomesView";
            this.Text = "EditIncomesView";
            this.Load += new System.EventHandler(this.EditIncomesView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDateUpdated;
        private System.Windows.Forms.TextBox txtAmountUpdated;
        private System.Windows.Forms.TextBox txtNameUpdated;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}