namespace Proj._Lista___Agenda___WFA.Forms
{
    partial class AgendaForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cmbTipoTelefone;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            cmbTipoTelefone = new ComboBox();
            dtpNascimento = new DateTimePicker();
            dgvContatos = new DataGridView();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            btnAlterar = new Button();
            btnRemover = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(125, 106);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(120, 23);
            txtTelefone.TabIndex = 2;
            // 
            // cmbTipoTelefone
            // 
            cmbTipoTelefone.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoTelefone.Items.AddRange(new object[] { "Celular", "Fixo" });
            cmbTipoTelefone.Location = new Point(255, 106);
            cmbTipoTelefone.Name = "cmbTipoTelefone";
            cmbTipoTelefone.Size = new Size(70, 23);
            cmbTipoTelefone.TabIndex = 3;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(125, 146);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 4;
            // 
            // dgvContatos
            // 
            dgvContatos.Location = new Point(49, 181);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.ReadOnly = true;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(400, 200);
            dgvContatos.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(349, 21);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(100, 30);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(349, 61);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 30);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(349, 101);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(100, 30);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(349, 141);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(100, 30);
            btnRemover.TabIndex = 9;
            btnRemover.Text = "Remover";
            btnRemover.Click += btnRemover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 114);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 149);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 13;
            label4.Text = "Data Nascimento";
            // 
            // AgendaForm
            // 
            ClientSize = new Size(480, 400);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(cmbTipoTelefone);
            Controls.Add(dtpNascimento);
            Controls.Add(dgvContatos);
            Controls.Add(btnAdicionar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAlterar);
            Controls.Add(btnRemover);
            Name = "AgendaForm";
            Text = "Agenda";
            Load += AgendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
