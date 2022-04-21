
namespace Crud
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.bntIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.AllowUserToAddRows = false;
            this.dgrid.AllowUserToDeleteRows = false;
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Location = new System.Drawing.Point(12, 12);
            this.dgrid.Name = "dgrid";
            this.dgrid.ReadOnly = true;
            this.dgrid.Size = new System.Drawing.Size(511, 413);
            this.dgrid.TabIndex = 0;
            this.dgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellContentClick);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(34, 444);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(178, 40);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Alterar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // bntIncluir
            // 
            this.bntIncluir.Location = new System.Drawing.Point(309, 444);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bntIncluir.Size = new System.Drawing.Size(178, 40);
            this.bntIncluir.TabIndex = 3;
            this.bntIncluir.Text = "Incluir";
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 496);
            this.Controls.Add(this.bntIncluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgrid);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button bntIncluir;
    }
}

