namespace Emprestimos
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.IdItem = new System.Windows.Forms.Label();
            this.nomeItem = new System.Windows.Forms.Label();
            this.grupoItem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descItem = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.descItem);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.grupoItem);
            this.panel1.Controls.Add(this.nomeItem);
            this.panel1.Controls.Add(this.IdItem);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(475, 290);
            this.panel1.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(76, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(76, 82);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 0;
            // 
            // IdItem
            // 
            this.IdItem.AutoSize = true;
            this.IdItem.Location = new System.Drawing.Point(35, 33);
            this.IdItem.Name = "IdItem";
            this.IdItem.Size = new System.Drawing.Size(21, 13);
            this.IdItem.TabIndex = 1;
            this.IdItem.Text = "ID:";
            // 
            // nomeItem
            // 
            this.nomeItem.AutoSize = true;
            this.nomeItem.Location = new System.Drawing.Point(35, 59);
            this.nomeItem.Name = "nomeItem";
            this.nomeItem.Size = new System.Drawing.Size(38, 13);
            this.nomeItem.TabIndex = 1;
            this.nomeItem.Text = "Nome:";
            // 
            // grupoItem
            // 
            this.grupoItem.AutoSize = true;
            this.grupoItem.Location = new System.Drawing.Point(35, 85);
            this.grupoItem.Name = "grupoItem";
            this.grupoItem.Size = new System.Drawing.Size(39, 13);
            this.grupoItem.TabIndex = 1;
            this.grupoItem.Text = "Grupo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // descItem
            // 
            this.descItem.AutoSize = true;
            this.descItem.Location = new System.Drawing.Point(35, 127);
            this.descItem.Name = "descItem";
            this.descItem.Size = new System.Drawing.Size(58, 13);
            this.descItem.TabIndex = 3;
            this.descItem.Text = "Descrição:";
            this.descItem.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 152);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(362, 78);
            this.txtDescricao.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 316);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Adicionar Item";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label descItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label grupoItem;
        private System.Windows.Forms.Label nomeItem;
        private System.Windows.Forms.Label IdItem;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}