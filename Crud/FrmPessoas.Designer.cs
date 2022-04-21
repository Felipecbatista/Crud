
namespace Crud
{
    partial class FrmPessoas
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(28, 114);
            this.txtTelefone.MaxLength = 100;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(228, 20);
            this.txtTelefone.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 60);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 20);
            this.txtNome.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(263, 202);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 43);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(147, 202);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(96, 43);
            this.btnExluir.TabIndex = 11;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = true;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(28, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 43);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(26, 98);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome: ";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(268, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(97, 25);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // FrmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 311);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPessoas";
            this.Load += new System.EventHandler(this.FrmPessoas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
    }
}