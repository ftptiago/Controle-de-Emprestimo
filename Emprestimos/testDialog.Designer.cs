namespace Emprestimos
{
    partial class testDialog
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
            this.txtOnForm3 = new System.Windows.Forms.TextBox();
            this.DialogResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOnForm4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOnForm3
            // 
            this.txtOnForm3.Location = new System.Drawing.Point(21, 41);
            this.txtOnForm3.Name = "txtOnForm3";
            this.txtOnForm3.Size = new System.Drawing.Size(90, 20);
            this.txtOnForm3.TabIndex = 0;
            this.txtOnForm3.TextChanged += new System.EventHandler(this.TestDialog_Load);
            this.txtOnForm3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnForm3_KeyPress);
            // 
            // DialogResult
            // 
            this.DialogResult.Location = new System.Drawing.Point(211, 161);
            this.DialogResult.Name = "DialogResult";
            this.DialogResult.Size = new System.Drawing.Size(67, 23);
            this.DialogResult.TabIndex = 2;
            this.DialogResult.Text = "Enviar";
            this.DialogResult.UseVisualStyleBackColor = true;
            this.DialogResult.Click += new System.EventHandler(this.DialogResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código de Pessoa";
            // 
            // txtOnForm4
            // 
            this.txtOnForm4.Location = new System.Drawing.Point(21, 96);
            this.txtOnForm4.Multiline = true;
            this.txtOnForm4.Name = "txtOnForm4";
            this.txtOnForm4.Size = new System.Drawing.Size(257, 59);
            this.txtOnForm4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Obs:";
            // 
            // testDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOnForm4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DialogResult);
            this.Controls.Add(this.txtOnForm3);
            this.Name = "testDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.TestDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOnForm3;
        private System.Windows.Forms.Button DialogResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOnForm4;
        private System.Windows.Forms.Label label2;
    }
}