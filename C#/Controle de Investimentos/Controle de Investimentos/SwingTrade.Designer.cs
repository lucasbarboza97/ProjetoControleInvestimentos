

namespace Controle_de_Investimentos
{
    partial class SwingTrade
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodigoAcao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDataCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtQtdCompra = new System.Windows.Forms.TextBox();
            this.txtValorUnitarioCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorTotalCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotalVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorUnitarioVenda = new System.Windows.Forms.TextBox();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.mskDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaCorretagem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDarf = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(302, 654);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtCodigoAcao
            // 
            this.txtCodigoAcao.Location = new System.Drawing.Point(381, 77);
            this.txtCodigoAcao.Name = "txtCodigoAcao";
            this.txtCodigoAcao.Size = new System.Drawing.Size(139, 20);
            this.txtCodigoAcao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código da Ação";
            // 
            // mskDataCompra
            // 
            this.mskDataCompra.Location = new System.Drawing.Point(381, 161);
            this.mskDataCompra.Mask = "00/00/0000";
            this.mskDataCompra.Name = "mskDataCompra";
            this.mskDataCompra.Size = new System.Drawing.Size(139, 20);
            this.mskDataCompra.TabIndex = 4;
            this.mskDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // txtQtdCompra
            // 
            this.txtQtdCompra.Location = new System.Drawing.Point(592, 161);
            this.txtQtdCompra.Name = "txtQtdCompra";
            this.txtQtdCompra.Size = new System.Drawing.Size(139, 20);
            this.txtQtdCompra.TabIndex = 5;
            // 
            // txtValorUnitarioCompra
            // 
            this.txtValorUnitarioCompra.Location = new System.Drawing.Point(816, 161);
            this.txtValorUnitarioCompra.Name = "txtValorUnitarioCompra";
            this.txtValorUnitarioCompra.Size = new System.Drawing.Size(139, 20);
            this.txtValorUnitarioCompra.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data da compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade comprada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor unitário da compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1044, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor total";
            // 
            // txtValorTotalCompra
            // 
            this.txtValorTotalCompra.Location = new System.Drawing.Point(1047, 161);
            this.txtValorTotalCompra.Name = "txtValorTotalCompra";
            this.txtValorTotalCompra.Size = new System.Drawing.Size(139, 20);
            this.txtValorTotalCompra.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1044, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor total";
            // 
            // txtValorTotalVenda
            // 
            this.txtValorTotalVenda.Location = new System.Drawing.Point(1047, 257);
            this.txtValorTotalVenda.Name = "txtValorTotalVenda";
            this.txtValorTotalVenda.Size = new System.Drawing.Size(139, 20);
            this.txtValorTotalVenda.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(813, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor unitário da venda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade vendida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data da venda";
            // 
            // txtValorUnitarioVenda
            // 
            this.txtValorUnitarioVenda.Location = new System.Drawing.Point(816, 257);
            this.txtValorUnitarioVenda.Name = "txtValorUnitarioVenda";
            this.txtValorUnitarioVenda.Size = new System.Drawing.Size(139, 20);
            this.txtValorUnitarioVenda.TabIndex = 14;
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.Location = new System.Drawing.Point(592, 257);
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(139, 20);
            this.txtQtdVenda.TabIndex = 13;
            // 
            // mskDataVenda
            // 
            this.mskDataVenda.Location = new System.Drawing.Point(381, 257);
            this.mskDataVenda.Mask = "00/00/0000";
            this.mskDataVenda.Name = "mskDataVenda";
            this.mskDataVenda.Size = new System.Drawing.Size(139, 20);
            this.mskDataVenda.TabIndex = 12;
            this.mskDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // txtTaxaCorretagem
            // 
            this.txtTaxaCorretagem.Location = new System.Drawing.Point(381, 354);
            this.txtTaxaCorretagem.Name = "txtTaxaCorretagem";
            this.txtTaxaCorretagem.Size = new System.Drawing.Size(139, 20);
            this.txtTaxaCorretagem.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Taxas de corretagem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "DARF";
            // 
            // txtDarf
            // 
            this.txtDarf.Location = new System.Drawing.Point(592, 354);
            this.txtDarf.Name = "txtDarf";
            this.txtDarf.Size = new System.Drawing.Size(139, 20);
            this.txtDarf.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(813, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Lucro";
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(816, 354);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(139, 20);
            this.txtLucro.TabIndex = 24;
            // 
            // SwingTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDarf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTaxaCorretagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorTotalVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValorUnitarioVenda);
            this.Controls.Add(this.txtQtdVenda);
            this.Controls.Add(this.mskDataVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorTotalCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorUnitarioCompra);
            this.Controls.Add(this.txtQtdCompra);
            this.Controls.Add(this.mskDataCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoAcao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SwingTrade";
            this.Text = "Swing Trade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SwingTrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodigoAcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDataCompra;
        private System.Windows.Forms.TextBox txtQtdCompra;
        private System.Windows.Forms.TextBox txtValorUnitarioCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorTotalCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotalVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorUnitarioVenda;
        private System.Windows.Forms.TextBox txtQtdVenda;
        private System.Windows.Forms.MaskedTextBox mskDataVenda;
        private System.Windows.Forms.TextBox txtTaxaCorretagem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDarf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLucro;
    }
}