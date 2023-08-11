namespace PrjSifrão
{
    partial class Form1
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtRendaMensal = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblDataNasc = new Label();
            lblRendaMensal = new Label();
            btnCadastrar = new Button();
            lblTipoConta = new Label();
            dtDataNasc = new DateTimePicker();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(208, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(208, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(79, 103);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(208, 23);
            txtCpf.TabIndex = 2;
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.Location = new Point(158, 161);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.Size = new Size(129, 23);
            txtRendaMensal.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(26, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            lblId.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 82);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(26, 111);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(25, 140);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(98, 15);
            lblDataNasc.TabIndex = 8;
            lblDataNasc.Text = "Data Nascimento";
            // 
            // lblRendaMensal
            // 
            lblRendaMensal.AutoSize = true;
            lblRendaMensal.Location = new Point(25, 169);
            lblRendaMensal.Name = "lblRendaMensal";
            lblRendaMensal.Size = new Size(111, 15);
            lblRendaMensal.TabIndex = 9;
            lblRendaMensal.Text = "Renda Mensal (R$) :";
            lblRendaMensal.Click += lblRendaMensal_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(191, 207);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblTipoConta
            // 
            lblTipoConta.AutoSize = true;
            lblTipoConta.Location = new Point(36, 215);
            lblTipoConta.Name = "lblTipoConta";
            lblTipoConta.Size = new Size(62, 15);
            lblTipoConta.TabIndex = 11;
            lblTipoConta.Text = "TipoConta";
            // 
            // dtDataNasc
            // 
            dtDataNasc.Location = new Point(158, 132);
            dtDataNasc.Name = "dtDataNasc";
            dtDataNasc.Size = new Size(200, 23);
            dtDataNasc.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 255);
            Controls.Add(dtDataNasc);
            Controls.Add(lblTipoConta);
            Controls.Add(btnCadastrar);
            Controls.Add(lblRendaMensal);
            Controls.Add(lblDataNasc);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtRendaMensal;
        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblDataNasc;
        private Label lblRendaMensal;
        private Button btnCadastrar;
        private Label lblTipoConta;
        private DateTimePicker dtDataNasc;
    }
}