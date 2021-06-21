

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwingTrade));
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslPesquisar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(302, 641);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtCodigoAcao
            // 
            this.txtCodigoAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAcao.Location = new System.Drawing.Point(381, 99);
            this.txtCodigoAcao.Name = "txtCodigoAcao";
            this.txtCodigoAcao.Size = new System.Drawing.Size(139, 26);
            this.txtCodigoAcao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código da Ação";
            // 
            // mskDataCompra
            // 
            this.mskDataCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCompra.Location = new System.Drawing.Point(382, 183);
            this.mskDataCompra.Mask = "00/00/0000";
            this.mskDataCompra.Name = "mskDataCompra";
            this.mskDataCompra.Size = new System.Drawing.Size(139, 26);
            this.mskDataCompra.TabIndex = 4;
            this.mskDataCompra.ValidatingType = typeof(System.DateTime);
            // 
            // txtQtdCompra
            // 
            this.txtQtdCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdCompra.Location = new System.Drawing.Point(592, 183);
            this.txtQtdCompra.Name = "txtQtdCompra";
            this.txtQtdCompra.Size = new System.Drawing.Size(139, 26);
            this.txtQtdCompra.TabIndex = 5;
            // 
            // txtValorUnitarioCompra
            // 
            this.txtValorUnitarioCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorUnitarioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitarioCompra.Location = new System.Drawing.Point(817, 183);
            this.txtValorUnitarioCompra.Name = "txtValorUnitarioCompra";
            this.txtValorUnitarioCompra.Size = new System.Drawing.Size(139, 26);
            this.txtValorUnitarioCompra.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data da compra";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade comprada";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(813, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor unitário da compra";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1043, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor total";
            // 
            // txtValorTotalCompra
            // 
            this.txtValorTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalCompra.Location = new System.Drawing.Point(1047, 183);
            this.txtValorTotalCompra.Name = "txtValorTotalCompra";
            this.txtValorTotalCompra.Size = new System.Drawing.Size(139, 26);
            this.txtValorTotalCompra.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1043, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor total";
            // 
            // txtValorTotalVenda
            // 
            this.txtValorTotalVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalVenda.Location = new System.Drawing.Point(1047, 279);
            this.txtValorTotalVenda.Name = "txtValorTotalVenda";
            this.txtValorTotalVenda.Size = new System.Drawing.Size(139, 26);
            this.txtValorTotalVenda.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(812, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor unitário da venda";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade vendida";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data da venda";
            // 
            // txtValorUnitarioVenda
            // 
            this.txtValorUnitarioVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorUnitarioVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitarioVenda.Location = new System.Drawing.Point(817, 279);
            this.txtValorUnitarioVenda.Name = "txtValorUnitarioVenda";
            this.txtValorUnitarioVenda.Size = new System.Drawing.Size(139, 26);
            this.txtValorUnitarioVenda.TabIndex = 14;
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdVenda.Location = new System.Drawing.Point(593, 279);
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(139, 26);
            this.txtQtdVenda.TabIndex = 13;
            // 
            // mskDataVenda
            // 
            this.mskDataVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataVenda.Location = new System.Drawing.Point(382, 279);
            this.mskDataVenda.Mask = "00/00/0000";
            this.mskDataVenda.Name = "mskDataVenda";
            this.mskDataVenda.Size = new System.Drawing.Size(139, 26);
            this.mskDataVenda.TabIndex = 12;
            this.mskDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // txtTaxaCorretagem
            // 
            this.txtTaxaCorretagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaxaCorretagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaCorretagem.Location = new System.Drawing.Point(382, 376);
            this.txtTaxaCorretagem.Name = "txtTaxaCorretagem";
            this.txtTaxaCorretagem.Size = new System.Drawing.Size(139, 26);
            this.txtTaxaCorretagem.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Taxas de corretagem";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(589, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "DARF";
            // 
            // txtDarf
            // 
            this.txtDarf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDarf.Location = new System.Drawing.Point(593, 376);
            this.txtDarf.Name = "txtDarf";
            this.txtDarf.Size = new System.Drawing.Size(139, 26);
            this.txtDarf.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(813, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Lucro";
            // 
            // txtLucro
            // 
            this.txtLucro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucro.Location = new System.Drawing.Point(817, 376);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(139, 26);
            this.txtLucro.TabIndex = 24;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrar,
            this.tsbSalvar,
            this.tsbEditar,
            this.tsbCancelar,
            this.toolStripSeparator1,
            this.tslPesquisar,
            this.toolStripTextBox1,
            this.tsbPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(418, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastrar.Image")));
            this.tsbCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCadastrar.Text = "toolStripButton1";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "toolStripButton1";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton1";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslPesquisar
            // 
            this.tslPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslPesquisar.Name = "tslPesquisar";
            this.tslPesquisar.Size = new System.Drawing.Size(183, 22);
            this.tslPesquisar.Text = "Digite o código da ação: ";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbPesquisar
            // 
            this.tsbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisar.Image")));
            this.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisar.Name = "tsbPesquisar";
            this.tsbPesquisar.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisar.Text = "toolStripButton1";
            // 
            // SwingTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCadastrar;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslPesquisar;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton tsbPesquisar;
    }
}