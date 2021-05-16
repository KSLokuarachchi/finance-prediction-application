namespace W1534169_2019172.view.expense
{
    partial class ExpensesEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesEditView));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.txtNameUpdated = new System.Windows.Forms.TextBox();
            this.txtAmountUpdated = new System.Windows.Forms.TextBox();
            this.txtDateUpdated = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amount";
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateExpense.Location = new System.Drawing.Point(144, 195);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateExpense.TabIndex = 19;
            this.btnUpdateExpense.Text = "Update";
            this.btnUpdateExpense.UseVisualStyleBackColor = false;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // txtNameUpdated
            // 
            this.txtNameUpdated.Location = new System.Drawing.Point(109, 85);
            this.txtNameUpdated.Name = "txtNameUpdated";
            this.txtNameUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtNameUpdated.TabIndex = 21;
            // 
            // txtAmountUpdated
            // 
            this.txtAmountUpdated.Location = new System.Drawing.Point(109, 135);
            this.txtAmountUpdated.Name = "txtAmountUpdated";
            this.txtAmountUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtAmountUpdated.TabIndex = 22;
            // 
            // txtDateUpdated
            // 
            this.txtDateUpdated.Location = new System.Drawing.Point(109, 35);
            this.txtDateUpdated.Name = "txtDateUpdated";
            this.txtDateUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtDateUpdated.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // EditExpensesView
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
            this.Name = "EditExpensesView";
            this.Text = "EditExpensesView";
            this.Load += new System.EventHandler(this.EditExpensesView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.TextBox txtNameUpdated;
        private System.Windows.Forms.TextBox txtAmountUpdated;
        private System.Windows.Forms.DateTimePicker txtDateUpdated;
        private System.Windows.Forms.Label label1;
    }
}