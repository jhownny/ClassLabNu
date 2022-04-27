namespace ComercialSys91
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserirCli = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btlDesativar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpData_Cad = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnIdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btlListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.txtNun = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 137);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 31);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(53, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(385, 138);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(240, 137);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(115, 20);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Mail";
            // 
            // btnInserirCli
            // 
            this.btnInserirCli.Location = new System.Drawing.Point(43, 240);
            this.btnInserirCli.Name = "btnInserirCli";
            this.btnInserirCli.Size = new System.Drawing.Size(87, 30);
            this.btnInserirCli.TabIndex = 8;
            this.btnInserirCli.Text = "&Inserir";
            this.btnInserirCli.UseVisualStyleBackColor = true;
            this.btnInserirCli.Click += new System.EventHandler(this.btnInserirCli_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(154, 240);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 30);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btlDesativar
            // 
            this.btlDesativar.Location = new System.Drawing.Point(443, 240);
            this.btlDesativar.Name = "btlDesativar";
            this.btlDesativar.Size = new System.Drawing.Size(87, 30);
            this.btlDesativar.TabIndex = 12;
            this.btlDesativar.Text = "&Desativar";
            this.btlDesativar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(292, 198);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data de Cadastro";
            // 
            // dtpData_Cad
            // 
            this.dtpData_Cad.Enabled = false;
            this.dtpData_Cad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData_Cad.Location = new System.Drawing.Point(240, 47);
            this.dtpData_Cad.Name = "dtpData_Cad";
            this.dtpData_Cad.Size = new System.Drawing.Size(115, 20);
            this.dtpData_Cad.TabIndex = 16;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdCli,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnAtivo});
            this.dgvClientes.Location = new System.Drawing.Point(43, 315);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(433, 157);
            this.dgvClientes.TabIndex = 17;
            // 
            // clnIdCli
            // 
            this.clnIdCli.Frozen = true;
            this.clnIdCli.HeaderText = "Id";
            this.clnIdCli.Name = "clnIdCli";
            this.clnIdCli.ReadOnly = true;
            this.clnIdCli.Width = 50;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 130;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 90;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 130;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 30;
            // 
            // btlListar
            // 
            this.btlListar.Location = new System.Drawing.Point(350, 240);
            this.btlListar.Name = "btlListar";
            this.btlListar.Size = new System.Drawing.Size(87, 30);
            this.btlListar.TabIndex = 18;
            this.btlListar.Text = "&Listar Todos";
            this.btlListar.UseVisualStyleBackColor = true;
            this.btlListar.Click += new System.EventHandler(this.btlListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(77, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 24);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtLogra);
            this.groupBox1.Controls.Add(this.txtNun);
            this.groupBox1.Controls.Add(this.txtUf);
            this.groupBox1.Controls.Add(this.txtCom);
            this.groupBox1.Controls.Add(this.txtCid);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Location = new System.Drawing.Point(561, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 253);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Tipo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 215);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(278, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "UF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Numero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Logradouro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Complemento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(152, 47);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(220, 20);
            this.txtLogra.TabIndex = 7;
            // 
            // txtNun
            // 
            this.txtNun.Location = new System.Drawing.Point(272, 89);
            this.txtNun.Name = "txtNun";
            this.txtNun.Size = new System.Drawing.Size(100, 20);
            this.txtNun.TabIndex = 6;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(239, 174);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 20);
            this.txtUf.TabIndex = 5;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(164, 91);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(88, 20);
            this.txtCom.TabIndex = 4;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(29, 89);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 20);
            this.txtCid.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(152, 144);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(29, 47);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 1;
            this.txtCep.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Location = new System.Drawing.Point(588, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 137);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(97, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Telefone";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(94, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Telefone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "DDD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "DDD";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(60, 87);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 5;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(6, 87);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(48, 20);
            this.textBox10.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(60, 39);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(180, 86);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(180, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btlListar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dtpData_Cad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btlDesativar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserirCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserirCli;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btlDesativar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpData_Cad;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.Button btlListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.TextBox txtNun;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

