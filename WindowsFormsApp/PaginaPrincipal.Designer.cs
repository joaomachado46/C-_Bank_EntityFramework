namespace WindowsFormsApp
{
    partial class PaginaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.textBoxMov = new System.Windows.Forms.TextBox();
            this.textBoxDadosCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Movimentos = new System.Windows.Forms.Button();
            this.panelLevantamento = new System.Windows.Forms.Panel();
            this.textBoxNumCartaoMov = new System.Windows.Forms.TextBox();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLevantamento = new System.Windows.Forms.TextBox();
            this.panelEmprestimo = new System.Windows.Forms.Panel();
            this.textBoxEmailEmprestimo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.comboBoxMeses = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoEmprestimo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dadosconta = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLevantamento = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLevantamento.SuspendLayout();
            this.panelEmprestimo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(469, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BEM VINDO AO SEU BANCO";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(567, 107);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 29);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoCliente.Location = new System.Drawing.Point(756, 107);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(189, 29);
            this.btnNovoCliente.TabIndex = 2;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(38, 107);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(240, 27);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(310, 107);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(223, 27);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(310, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.Transparent;
            this.panelCliente.Controls.Add(this.textBoxMov);
            this.panelCliente.Controls.Add(this.textBoxDadosCliente);
            this.panelCliente.Controls.Add(this.panel2);
            this.panelCliente.Controls.Add(this.panel3);
            this.panelCliente.Location = new System.Drawing.Point(12, 177);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(1402, 566);
            this.panelCliente.TabIndex = 7;
            // 
            // textBoxMov
            // 
            this.textBoxMov.BackColor = System.Drawing.Color.Navy;
            this.textBoxMov.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMov.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMov.Location = new System.Drawing.Point(51, 363);
            this.textBoxMov.Multiline = true;
            this.textBoxMov.Name = "textBoxMov";
            this.textBoxMov.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMov.Size = new System.Drawing.Size(470, 169);
            this.textBoxMov.TabIndex = 8;
            // 
            // textBoxDadosCliente
            // 
            this.textBoxDadosCliente.BackColor = System.Drawing.Color.Navy;
            this.textBoxDadosCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxDadosCliente.Location = new System.Drawing.Point(26, 94);
            this.textBoxDadosCliente.Multiline = true;
            this.textBoxDadosCliente.Name = "textBoxDadosCliente";
            this.textBoxDadosCliente.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDadosCliente.Size = new System.Drawing.Size(505, 202);
            this.textBoxDadosCliente.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.Movimentos);
            this.panel2.Controls.Add(this.panelLevantamento);
            this.panel2.Controls.Add(this.panelEmprestimo);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(604, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 506);
            this.panel2.TabIndex = 1;
            // 
            // Movimentos
            // 
            this.Movimentos.Location = new System.Drawing.Point(207, 434);
            this.Movimentos.Name = "Movimentos";
            this.Movimentos.Size = new System.Drawing.Size(379, 29);
            this.Movimentos.TabIndex = 9;
            this.Movimentos.Text = "Movimentos";
            this.Movimentos.UseVisualStyleBackColor = true;
            this.Movimentos.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelLevantamento
            // 
            this.panelLevantamento.BackColor = System.Drawing.Color.Navy;
            this.panelLevantamento.Controls.Add(this.textBoxNumCartaoMov);
            this.panelLevantamento.Controls.Add(this.textBoxDeposito);
            this.panelLevantamento.Controls.Add(this.btnDeposito);
            this.panelLevantamento.Controls.Add(this.label10);
            this.panelLevantamento.Controls.Add(this.label9);
            this.panelLevantamento.Controls.Add(this.label8);
            this.panelLevantamento.Controls.Add(this.textBoxLevantamento);
            this.panelLevantamento.Location = new System.Drawing.Point(405, 40);
            this.panelLevantamento.Name = "panelLevantamento";
            this.panelLevantamento.Size = new System.Drawing.Size(382, 348);
            this.panelLevantamento.TabIndex = 8;
            // 
            // textBoxNumCartaoMov
            // 
            this.textBoxNumCartaoMov.Location = new System.Drawing.Point(63, 83);
            this.textBoxNumCartaoMov.Name = "textBoxNumCartaoMov";
            this.textBoxNumCartaoMov.Size = new System.Drawing.Size(238, 30);
            this.textBoxNumCartaoMov.TabIndex = 7;
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(92, 225);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(183, 30);
            this.textBoxDeposito.TabIndex = 5;
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackColor = System.Drawing.Color.Navy;
            this.btnDeposito.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeposito.Location = new System.Drawing.Point(63, 282);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(255, 29);
            this.btnDeposito.TabIndex = 6;
            this.btnDeposito.Text = "Efectuar Pedido";
            this.btnDeposito.UseVisualStyleBackColor = false;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(92, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Montante a depositar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(383, 60);
            this.label9.TabIndex = 3;
            this.label9.Text = "Consulte na tabela ao lado o número do cartão\r\ne indique o número para a qual que" +
    " fazer a operação. \r\nObrigado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(92, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Montante a levantar:";
            // 
            // textBoxLevantamento
            // 
            this.textBoxLevantamento.Location = new System.Drawing.Point(92, 158);
            this.textBoxLevantamento.Name = "textBoxLevantamento";
            this.textBoxLevantamento.Size = new System.Drawing.Size(183, 30);
            this.textBoxLevantamento.TabIndex = 1;
            // 
            // panelEmprestimo
            // 
            this.panelEmprestimo.BackColor = System.Drawing.Color.Navy;
            this.panelEmprestimo.Controls.Add(this.textBoxEmailEmprestimo);
            this.panelEmprestimo.Controls.Add(this.button1);
            this.panelEmprestimo.Controls.Add(this.label7);
            this.panelEmprestimo.Controls.Add(this.textBoxValor);
            this.panelEmprestimo.Controls.Add(this.comboBoxMeses);
            this.panelEmprestimo.Controls.Add(this.comboBoxTipoEmprestimo);
            this.panelEmprestimo.Controls.Add(this.label6);
            this.panelEmprestimo.Controls.Add(this.label5);
            this.panelEmprestimo.Controls.Add(this.label4);
            this.panelEmprestimo.Location = new System.Drawing.Point(9, 40);
            this.panelEmprestimo.Name = "panelEmprestimo";
            this.panelEmprestimo.Size = new System.Drawing.Size(363, 348);
            this.panelEmprestimo.TabIndex = 6;
            // 
            // textBoxEmailEmprestimo
            // 
            this.textBoxEmailEmprestimo.Location = new System.Drawing.Point(199, 208);
            this.textBoxEmailEmprestimo.Name = "textBoxEmailEmprestimo";
            this.textBoxEmailEmprestimo.Size = new System.Drawing.Size(151, 30);
            this.textBoxEmailEmprestimo.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(54, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Efectuar Pedido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(15, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 46);
            this.label7.TabIndex = 10;
            this.label7.Text = "Digite novamente\r\no seu email:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(198, 132);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(149, 30);
            this.textBoxValor.TabIndex = 8;
            // 
            // comboBoxMeses
            // 
            this.comboBoxMeses.FormattingEnabled = true;
            this.comboBoxMeses.Items.AddRange(new object[] {
            "24",
            "48",
            "94",
            "120"});
            this.comboBoxMeses.Location = new System.Drawing.Point(199, 69);
            this.comboBoxMeses.Name = "comboBoxMeses";
            this.comboBoxMeses.Size = new System.Drawing.Size(151, 31);
            this.comboBoxMeses.TabIndex = 7;
            // 
            // comboBoxTipoEmprestimo
            // 
            this.comboBoxTipoEmprestimo.FormattingEnabled = true;
            this.comboBoxTipoEmprestimo.Items.AddRange(new object[] {
            "Conta Simples",
            "Crédito Automóvel",
            "Crédito Habitação",
            "Crédito Pessoal"});
            this.comboBoxTipoEmprestimo.Location = new System.Drawing.Point(198, 13);
            this.comboBoxTipoEmprestimo.Name = "comboBoxTipoEmprestimo";
            this.comboBoxTipoEmprestimo.Size = new System.Drawing.Size(151, 31);
            this.comboBoxTipoEmprestimo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(14, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor Pretendido: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Meses: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de conta:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.dadosconta);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnLevantamento);
            this.panel3.Controls.Add(this.btnEmprestimo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1402, 65);
            this.panel3.TabIndex = 0;
            // 
            // dadosconta
            // 
            this.dadosconta.AutoSize = true;
            this.dadosconta.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.dadosconta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dadosconta.Location = new System.Drawing.Point(129, 19);
            this.dadosconta.Name = "dadosconta";
            this.dadosconta.Size = new System.Drawing.Size(260, 28);
            this.dadosconta.TabIndex = 0;
            this.dadosconta.Text = "Dados da sua/as conta/as.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnLevantamento
            // 
            this.btnLevantamento.FlatAppearance.BorderSize = 2;
            this.btnLevantamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevantamento.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLevantamento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLevantamento.Location = new System.Drawing.Point(1144, 16);
            this.btnLevantamento.Name = "btnLevantamento";
            this.btnLevantamento.Size = new System.Drawing.Size(146, 38);
            this.btnLevantamento.TabIndex = 4;
            this.btnLevantamento.Text = "Levantamento";
            this.btnLevantamento.UseVisualStyleBackColor = true;
            this.btnLevantamento.Click += new System.EventHandler(this.btnLevantamento_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmprestimo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEmprestimo.Location = new System.Drawing.Point(721, 16);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(190, 38);
            this.btnEmprestimo.TabIndex = 3;
            this.btnEmprestimo.Text = "Empréstimo/Conta";
            this.btnEmprestimo.UseVisualStyleBackColor = false;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(966, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Terminar Sessão";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 58);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
       
            this.pictureBox1.Location = new System.Drawing.Point(21, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1410, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnLogin);
        
            this.Name = "PaginaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelLevantamento.ResumeLayout(false);
            this.panelLevantamento.PerformLayout();
            this.panelEmprestimo.ResumeLayout(false);
            this.panelEmprestimo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label dadosconta;
        private System.Windows.Forms.TextBox textBoxDadosCliente;
        private System.Windows.Forms.Button btnLevantamento;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Panel panelEmprestimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoEmprestimo;
        private System.Windows.Forms.ComboBox comboBoxMeses;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmailEmprestimo;
        private System.Windows.Forms.Panel panelLevantamento;
        private System.Windows.Forms.TextBox textBoxLevantamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.TextBox textBoxNumCartaoMov;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Movimentos;
        private System.Windows.Forms.TextBox textBoxMov;
    }
}

