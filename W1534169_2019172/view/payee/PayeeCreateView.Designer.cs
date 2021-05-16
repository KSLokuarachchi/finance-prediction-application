namespace W1534169_2019172.view.payee
{
    partial class PayeeCreateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayeeCreateView));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayeeNote = new System.Windows.Forms.TextBox();
            this.txtPayeeName = new System.Windows.Forms.TextBox();
            this.btnAddPayee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txtPayeeNote
            // 
            this.txtPayeeNote.Location = new System.Drawing.Point(72, 82);
            this.txtPayeeNote.Name = "txtPayeeNote";
            this.txtPayeeNote.Size = new System.Drawing.Size(202, 20);
            this.txtPayeeNote.TabIndex = 6;
            // 
            // txtPayeeName
            // 
            this.txtPayeeName.Location = new System.Drawing.Point(72, 41);
            this.txtPayeeName.Name = "txtPayeeName";
            this.txtPayeeName.Size = new System.Drawing.Size(202, 20);
            this.txtPayeeName.TabIndex = 5;
            // 
            // btnAddPayee
            // 
            this.btnAddPayee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPayee.Location = new System.Drawing.Point(126, 141);
            this.btnAddPayee.Name = "btnAddPayee";
            this.btnAddPayee.Size = new System.Drawing.Size(75, 23);
            this.btnAddPayee.TabIndex = 9;
            this.btnAddPayee.Text = "Add";
            this.btnAddPayee.UseVisualStyleBackColor = false;
            this.btnAddPayee.Click += new System.EventHandler(this.btnAddPayee_Click);
            // 
            // PayeeCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(309, 176);
            this.Controls.Add(this.btnAddPayee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayeeNote);
            this.Controls.Add(this.txtPayeeName);
            this.Name = "PayeeCreateView";
            this.Text = "PayeeCreateView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayeeNote;
        private System.Windows.Forms.TextBox txtPayeeName;
        private System.Windows.Forms.Button btnAddPayee;
    }
}