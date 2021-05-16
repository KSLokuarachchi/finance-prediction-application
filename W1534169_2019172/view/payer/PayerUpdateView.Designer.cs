namespace W1534169_2019172.view.payer
{
    partial class PayerUpdateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayerUpdateView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayerNoteUpdated = new System.Windows.Forms.TextBox();
            this.txtPayerNameUpdated = new System.Windows.Forms.TextBox();
            this.btnUpdatePayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // txtPayerNoteUpdated
            // 
            this.txtPayerNoteUpdated.Location = new System.Drawing.Point(114, 89);
            this.txtPayerNoteUpdated.Name = "txtPayerNoteUpdated";
            this.txtPayerNoteUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtPayerNoteUpdated.TabIndex = 33;
            // 
            // txtPayerNameUpdated
            // 
            this.txtPayerNameUpdated.Location = new System.Drawing.Point(114, 39);
            this.txtPayerNameUpdated.Name = "txtPayerNameUpdated";
            this.txtPayerNameUpdated.Size = new System.Drawing.Size(200, 20);
            this.txtPayerNameUpdated.TabIndex = 32;
            // 
            // btnUpdatePayer
            // 
            this.btnUpdatePayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdatePayer.Location = new System.Drawing.Point(149, 149);
            this.btnUpdatePayer.Name = "btnUpdatePayer";
            this.btnUpdatePayer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePayer.TabIndex = 31;
            this.btnUpdatePayer.Text = "Update";
            this.btnUpdatePayer.UseVisualStyleBackColor = false;
            this.btnUpdatePayer.Click += new System.EventHandler(this.btnUpdatePayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Note";
            // 
            // PayerUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayerNoteUpdated);
            this.Controls.Add(this.txtPayerNameUpdated);
            this.Controls.Add(this.btnUpdatePayer);
            this.Controls.Add(this.label3);
            this.Name = "PayerUpdateView";
            this.Text = "PayerUpdateView";
            this.Load += new System.EventHandler(this.PayerUpdateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayerNoteUpdated;
        private System.Windows.Forms.TextBox txtPayerNameUpdated;
        private System.Windows.Forms.Button btnUpdatePayer;
        private System.Windows.Forms.Label label3;
    }
}