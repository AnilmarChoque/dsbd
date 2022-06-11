
namespace BancoDeDados
{
    partial class Form1
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
            this.txtCodigoRegistro = new System.Windows.Forms.TextBox();
            this.txtCalibre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDataFabric = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCodigoRegistro = new System.Windows.Forms.Label();
            this.lblCalibre = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataFabric = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtCodigoRegistro
            // 
            this.txtCodigoRegistro.Location = new System.Drawing.Point(132, 64);
            this.txtCodigoRegistro.MaxLength = 8;
            this.txtCodigoRegistro.Name = "txtCodigoRegistro";
            this.txtCodigoRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoRegistro.TabIndex = 0;
            // 
            // txtCalibre
            // 
            this.txtCalibre.Location = new System.Drawing.Point(132, 90);
            this.txtCalibre.MaxLength = 4;
            this.txtCalibre.Name = "txtCalibre";
            this.txtCalibre.Size = new System.Drawing.Size(100, 20);
            this.txtCalibre.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(132, 116);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtDataFabric
            // 
            this.txtDataFabric.Location = new System.Drawing.Point(132, 142);
            this.txtDataFabric.Name = "txtDataFabric";
            this.txtDataFabric.Size = new System.Drawing.Size(100, 20);
            this.txtDataFabric.TabIndex = 3;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(132, 168);
            this.txtFornecedor.MaxLength = 30;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 4;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(132, 194);
            this.txtLote.MaxLength = 6;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(142, 246);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 41);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(368, 246);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 41);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(29, 246);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 41);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodigoRegistro
            // 
            this.lblCodigoRegistro.AutoSize = true;
            this.lblCodigoRegistro.Location = new System.Drawing.Point(31, 71);
            this.lblCodigoRegistro.Name = "lblCodigoRegistro";
            this.lblCodigoRegistro.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoRegistro.TabIndex = 9;
            this.lblCodigoRegistro.Text = "Codigo de registro:";
            // 
            // lblCalibre
            // 
            this.lblCalibre.AutoSize = true;
            this.lblCalibre.Location = new System.Drawing.Point(31, 97);
            this.lblCalibre.Name = "lblCalibre";
            this.lblCalibre.Size = new System.Drawing.Size(42, 13);
            this.lblCalibre.TabIndex = 10;
            this.lblCalibre.Text = "Calibre:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(31, 123);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor:";
            // 
            // lblDataFabric
            // 
            this.lblDataFabric.AutoSize = true;
            this.lblDataFabric.Location = new System.Drawing.Point(31, 145);
            this.lblDataFabric.Name = "lblDataFabric";
            this.lblDataFabric.Size = new System.Drawing.Size(101, 13);
            this.lblDataFabric.TabIndex = 12;
            this.lblDataFabric.Text = "Data de fabticação:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(31, 171);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 13;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(31, 201);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 14;
            this.lblLote.Text = "Lote:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(255, 246);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(107, 41);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(326, 90);
            this.maskedTextBox1.Mask = "000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 16;
            this.maskedTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 307);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblDataFabric);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCalibre);
            this.Controls.Add(this.lblCodigoRegistro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtDataFabric);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCalibre);
            this.Controls.Add(this.txtCodigoRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoRegistro;
        private System.Windows.Forms.TextBox txtCalibre;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDataFabric;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCodigoRegistro;
        private System.Windows.Forms.Label lblCalibre;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDataFabric;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

