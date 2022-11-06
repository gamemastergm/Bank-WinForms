namespace Bank
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupConta = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Emprest = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Deposito = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.btn_Saque = new System.Windows.Forms.Button();
            this.groupClienteCadastro = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbox_StatusCivil = new System.Windows.Forms.ComboBox();
            this.cbox_Sexo = new System.Windows.Forms.ComboBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_Null = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acessarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_senhaContaRe = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_senhaConta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupConta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupClienteCadastro.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.group_Null);
            this.groupBox1.Controls.Add(this.groupConta);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupClienteCadastro);
            this.groupBox1.Location = new System.Drawing.Point(18, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 332);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair da Conta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupConta
            // 
            this.groupConta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupConta.Controls.Add(this.button3);
            this.groupConta.Controls.Add(this.label12);
            this.groupConta.Controls.Add(this.btn_Emprest);
            this.groupConta.Controls.Add(this.groupBox3);
            this.groupConta.Controls.Add(this.groupBox2);
            this.groupConta.Controls.Add(this.btn_Deposito);
            this.groupConta.Controls.Add(this.btn_Transfer);
            this.groupConta.Controls.Add(this.btn_Saque);
            this.groupConta.Enabled = false;
            this.groupConta.Location = new System.Drawing.Point(56, 21);
            this.groupConta.Name = "groupConta";
            this.groupConta.Size = new System.Drawing.Size(360, 292);
            this.groupConta.TabIndex = 19;
            this.groupConta.TabStop = false;
            this.groupConta.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Bem-vindo ";
            // 
            // btn_Emprest
            // 
            this.btn_Emprest.Location = new System.Drawing.Point(25, 192);
            this.btn_Emprest.Name = "btn_Emprest";
            this.btn_Emprest.Size = new System.Drawing.Size(110, 29);
            this.btn_Emprest.TabIndex = 2;
            this.btn_Emprest.Text = "Emprestimo";
            this.btn_Emprest.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(214, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 180);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extrato";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 145);
            this.label10.TabIndex = 3;
            this.label10.Text = "-----------------------------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(214, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 58);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "R$ 00,00";
            // 
            // btn_Deposito
            // 
            this.btn_Deposito.Location = new System.Drawing.Point(25, 84);
            this.btn_Deposito.Name = "btn_Deposito";
            this.btn_Deposito.Size = new System.Drawing.Size(110, 29);
            this.btn_Deposito.TabIndex = 4;
            this.btn_Deposito.Text = "Depositar";
            this.btn_Deposito.UseVisualStyleBackColor = true;
            this.btn_Deposito.Click += new System.EventHandler(this.btn_Deposito_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(25, 157);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(110, 29);
            this.btn_Transfer.TabIndex = 1;
            this.btn_Transfer.Text = "Transferencia";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            // 
            // btn_Saque
            // 
            this.btn_Saque.Location = new System.Drawing.Point(25, 122);
            this.btn_Saque.Name = "btn_Saque";
            this.btn_Saque.Size = new System.Drawing.Size(110, 29);
            this.btn_Saque.TabIndex = 0;
            this.btn_Saque.Text = "Sacar";
            this.btn_Saque.UseVisualStyleBackColor = true;
            // 
            // groupClienteCadastro
            // 
            this.groupClienteCadastro.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupClienteCadastro.Controls.Add(this.button6);
            this.groupClienteCadastro.Controls.Add(this.cbox_StatusCivil);
            this.groupClienteCadastro.Controls.Add(this.cbox_Sexo);
            this.groupClienteCadastro.Controls.Add(this.txt_Endereco);
            this.groupClienteCadastro.Controls.Add(this.txt_Telefone);
            this.groupClienteCadastro.Controls.Add(this.label7);
            this.groupClienteCadastro.Controls.Add(this.label9);
            this.groupClienteCadastro.Controls.Add(this.label8);
            this.groupClienteCadastro.Controls.Add(this.label6);
            this.groupClienteCadastro.Controls.Add(this.label5);
            this.groupClienteCadastro.Controls.Add(this.txt_Idade);
            this.groupClienteCadastro.Controls.Add(this.label4);
            this.groupClienteCadastro.Controls.Add(this.txt_Senha);
            this.groupClienteCadastro.Controls.Add(this.label3);
            this.groupClienteCadastro.Controls.Add(this.txt_CPF);
            this.groupClienteCadastro.Controls.Add(this.txt_Nome);
            this.groupClienteCadastro.Controls.Add(this.label2);
            this.groupClienteCadastro.Location = new System.Drawing.Point(56, 21);
            this.groupClienteCadastro.Name = "groupClienteCadastro";
            this.groupClienteCadastro.Size = new System.Drawing.Size(360, 292);
            this.groupClienteCadastro.TabIndex = 4;
            this.groupClienteCadastro.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(249, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 31);
            this.button6.TabIndex = 18;
            this.button6.Text = "Concluir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.CadastroContaCliente);
            // 
            // cbox_StatusCivil
            // 
            this.cbox_StatusCivil.FormattingEnabled = true;
            this.cbox_StatusCivil.Items.AddRange(new object[] {
            "Solteiro/a",
            "Casado/a",
            "divorciado/a",
            "viúvo/a"});
            this.cbox_StatusCivil.Location = new System.Drawing.Point(108, 162);
            this.cbox_StatusCivil.Name = "cbox_StatusCivil";
            this.cbox_StatusCivil.Size = new System.Drawing.Size(137, 24);
            this.cbox_StatusCivil.TabIndex = 17;
            // 
            // cbox_Sexo
            // 
            this.cbox_Sexo.FormattingEnabled = true;
            this.cbox_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não informar"});
            this.cbox_Sexo.Location = new System.Drawing.Point(108, 132);
            this.cbox_Sexo.Name = "cbox_Sexo";
            this.cbox_Sexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbox_Sexo.Size = new System.Drawing.Size(137, 24);
            this.cbox_Sexo.TabIndex = 16;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(108, 221);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(192, 22);
            this.txt_Endereco.TabIndex = 12;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(108, 192);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(137, 22);
            this.txt_Telefone.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado Civil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "idade";
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(108, 104);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(137, 22);
            this.txt_Idade.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(108, 76);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(137, 22);
            this.txt_Senha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "cpf";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(108, 48);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(137, 22);
            this.txt_CPF.TabIndex = 2;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(108, 20);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(137, 22);
            this.txt_Nome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // group_Null
            // 
            this.group_Null.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.group_Null.Enabled = false;
            this.group_Null.Location = new System.Drawing.Point(56, 21);
            this.group_Null.Name = "group_Null";
            this.group_Null.Size = new System.Drawing.Size(360, 292);
            this.group_Null.TabIndex = 20;
            this.group_Null.TabStop = false;
            this.group_Null.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarContaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.encerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(116, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(570, 40);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acessarContaToolStripMenuItem
            // 
            this.acessarContaToolStripMenuItem.Name = "acessarContaToolStripMenuItem";
            this.acessarContaToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.acessarContaToolStripMenuItem.Text = "Cadastrar Cliente";
            this.acessarContaToolStripMenuItem.Click += new System.EventHandler(this.acessarContaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 36);
            this.toolStripMenuItem1.Text = "Acessar Conta";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem2.Text = "Conta Corrente";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem3.Text = "Conta Poupança";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.encerrarToolStripMenuItem.Text = "Deletar Conta";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txt_senhaContaRe);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txt_senhaConta);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(56, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 290);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "Concluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Digite novamente a senha";
            // 
            // txt_senhaContaRe
            // 
            this.txt_senhaContaRe.Location = new System.Drawing.Point(191, 101);
            this.txt_senhaContaRe.Name = "txt_senhaContaRe";
            this.txt_senhaContaRe.Size = new System.Drawing.Size(137, 22);
            this.txt_senhaContaRe.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "Digite uma senha";
            // 
            // txt_senhaConta
            // 
            this.txt_senhaConta.Location = new System.Drawing.Point(191, 73);
            this.txt_senhaConta.Name = "txt_senhaConta";
            this.txt_senhaConta.Size = new System.Drawing.Size(137, 22);
            this.txt_senhaConta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupConta.ResumeLayout(false);
            this.groupConta.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupClienteCadastro.ResumeLayout(false);
            this.groupClienteCadastro.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupClienteCadastro;
        private System.Windows.Forms.ComboBox cbox_StatusCivil;
        private System.Windows.Forms.ComboBox cbox_Sexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupConta;
        private System.Windows.Forms.Button btn_Emprest;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Button btn_Saque;
        private System.Windows.Forms.Button btn_Deposito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox group_Null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acessarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_senhaContaRe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_senhaConta;
    }
}

