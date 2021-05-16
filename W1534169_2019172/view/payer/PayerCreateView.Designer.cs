namespace W1534169_2019172.view.payer
{
    partial class PayerCreateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayerCreateView));
            this.btnAddPayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayerNote = new System.Windows.Forms.TextBox();
            this.txtPayerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddPayer
            // 
            this.btnAddPayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPayer.Location = new System.Drawing.Point(126, 143);
            this.btnAddPayer.Name = "btnAddPayer";
            this.btnAddPayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPayer.TabIndex = 14;
            this.btnAddPayer.Text = "Add";
            this.btnAddPayer.UseVisualStyleBackColor = false;
            this.btnAddPayer.Click += new System.EventHandler(this.btnAddPayer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // txtPayerNote
            // 
            this.txtPayerNote.Location = new System.Drawing.Point(72, 84);
            this.txtPayerNote.Name = "txtPayerNote";
            this.txtPayerNote.Size = new System.Drawing.Size(202, 20);
            this.txtPayerNote.TabIndex = 11;
            // 
            // txtPayerName
            // 
            this.txtPayerName.Location = new System.Drawing.Point(72, 43);
            this.txtPayerName.Name = "txtPayerName";
            this.txtPayerName.Size = new System.Drawing.Size(202, 20);
            this.txtPayerName.TabIndex = 10;
            // 
            // PayerCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(309, 176);
            this.Controls.Add(this.btnAddPayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayerNote);
            this.Controls.Add(this.txtPayerName);
            this.Name = "PayerCreateView";
            this.Text = "PayerCreateView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayerNote;
        private System.Windows.Forms.TextBox txtPayerName;
    }
}