namespace W1534169_2019172.view.payee
{
    partial class PayeeUpdateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayeeUpdateView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayeeNoteUpdated = new System.Windows.Forms.TextBox();
            this.txtPayeeNameUpdated = new System.Windows.Forms.TextBox();
            this.btnUpdatePayee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name";
            // 
            // txtPayeeNoteUpdated
            // 
            this.txtPayeeNoteUpdated.Location = new System.Drawing.Point(105, 89);
            this.txtPayeeNoteUpdated.Name = "txtPayeeNoteUpdated";
            this.txtPayeeNoteUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtPayeeNoteUpdated.TabIndex = 28;
            // 
            // txtPayeeNameUpdated
            // 
            this.txtPayeeNameUpdated.Location = new System.Drawing.Point(105, 39);
            this.txtPayeeNameUpdated.Name = "txtPayeeNameUpdated";
            this.txtPayeeNameUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtPayeeNameUpdated.TabIndex = 27;
            // 
            // btnUpdatePayee
            // 
            this.btnUpdatePayee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdatePayee.Location = new System.Drawing.Point(140, 149);
            this.btnUpdatePayee.Name = "btnUpdatePayee";
            this.btnUpdatePayee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePayee.TabIndex = 26;
            this.btnUpdatePayee.Text = "Update";
            this.btnUpdatePayee.UseVisualStyleBackColor = false;
            this.btnUpdatePayee.Click += new System.EventHandler(this.btnUpdatePayee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Note";
            // 
            // PayeeUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayeeNoteUpdated);
            this.Controls.Add(this.txtPayeeNameUpdated);
            this.Controls.Add(this.btnUpdatePayee);
            this.Controls.Add(this.label3);
            this.Name = "PayeeUpdateView";
            this.Text = "PayeeUpdateView";
            this.Load += new System.EventHandler(this.PayeeUpdateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayeeNoteUpdated;
        private System.Windows.Forms.TextBox txtPayeeNameUpdated;
        private System.Windows.Forms.Button btnUpdatePayee;
        private System.Windows.Forms.Label label3;
    }
}