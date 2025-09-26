using System;
using System.Linq;
using System.Windows.Forms;
using Proj._Lista___Agenda___WFA.Models;

namespace Proj._Lista___Agenda___WFA.Forms
{
    public partial class AgendaForm : Form
    {
        private string emailSelecionado = null; 

        private Contatos agenda = new Contatos();

        public AgendaForm()
        {
            InitializeComponent();
        }

        private void AgendaForm_Load(object sender, EventArgs e)
        {
            // Inicializa contatos de teste
            for (int i = 1; i <= 3; i++)
            {
                Data dt = new Data(1, 1, 2000 + i);
                Contato contato = new Contato($"email{i}@teste.com", $"Contato {i}", dt);
                contato.AdicionarTelefone(new Telefone("Celular", $"1199999{i:0000}", true));
                agenda.adicionar(contato);
            }

            AtualizarGrid();
        }

        private bool EmailPreenchido()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório para pesquisar!");
                txtEmail.Focus();
                return false;
            }
            return true;
        }


        private bool CamposPreenchidos()
        {
            
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório!");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório!");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("O campo Telefone é obrigatório!");
                txtTelefone.Focus();
                return false;
            }

            if (cmbTipoTelefone.SelectedItem == null)
            {
                MessageBox.Show("Selecione o Tipo de Telefone!");
                cmbTipoTelefone.Focus();
                return false;
            }

            return true;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (!CamposPreenchidos()) return;
            try
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                DateTime dt = dtpNascimento.Value;
                Data data = new Data(dt.Day, dt.Month, dt.Year);

                Contato contato = new Contato(email, nome, data);
                string tipo = cmbTipoTelefone.SelectedItem?.ToString() ?? "Celular";
                string numero = txtTelefone.Text;
                contato.AdicionarTelefone(new Telefone(tipo, numero, true));

                if (agenda.adicionar(contato))
                    MessageBox.Show("Contato adicionado com sucesso!");
                else
                    MessageBox.Show("Já existe um contato com esse email.");

                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
            LimparTextBox();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!EmailPreenchido()) return;

            string email = txtEmail.Text;
            Contato temp = new Contato { Email = email };
            Contato encontrado = agenda.pesquisar(temp);

            if (encontrado != null)
            {
                emailSelecionado = encontrado.Email; // <-- armazena o email antigo
                txtNome.Text = encontrado.Nome;
                dtpNascimento.Value = new DateTime(encontrado.DtNasc.Ano, encontrado.DtNasc.Mes, encontrado.DtNasc.Dia);

                if (encontrado.Telefones.Count > 0)
                {
                    txtTelefone.Text = encontrado.Telefones[0].Numero;
                    cmbTipoTelefone.SelectedItem = encontrado.Telefones[0].Tipo;
                }

                MessageBox.Show("Contato encontrado!");
                AtualizarGrid(encontrado); // mostra somente o contato pesquisado
            }
    

        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailSelecionado))
            {
                MessageBox.Show("Pesquise primeiro o contato que deseja alterar.");
                return;
            }

            Contato temp = new Contato { Email = emailSelecionado };
            Contato encontrado = agenda.pesquisar(temp);

            if (encontrado == null)
            {
                MessageBox.Show("Contato não encontrado.");
                return;
            }

            // Atualiza todos os campos, inclusive o email
            encontrado.Nome = txtNome.Text;
            encontrado.Email = txtEmail.Text; // aqui é possível alterar o email
            DateTime dt = dtpNascimento.Value;
            encontrado.DtNasc = new Data(dt.Day, dt.Month, dt.Year);

            encontrado.Telefones.Clear();
            encontrado.AdicionarTelefone(new Telefone(cmbTipoTelefone.SelectedItem.ToString(), txtTelefone.Text, true));

            agenda.alterar(encontrado);

            MessageBox.Show("Contato alterado com sucesso!");
            AtualizarGrid();
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {


            string email = txtEmail.Text;
            Contato temp = new Contato { Email = email };

            if (!CamposPreenchidos()) return;
            if (agenda.remover(temp))
                MessageBox.Show("Contato removido com sucesso!");
            else
                MessageBox.Show("Contato não encontrado.");

            AtualizarGrid();
            LimparTextBox();
        }

        private void AtualizarGrid(Contato contatoFiltrado = null)
        {
            dgvContatos.DataSource = null;

            if (contatoFiltrado != null)
            {
                dgvContatos.DataSource = new[]
                {
            new
            {
                contatoFiltrado.Nome,
                contatoFiltrado.Email,
                Nascimento = contatoFiltrado.DtNasc.ToString(),
                Telefone = contatoFiltrado.Telefones.Count > 0 ? contatoFiltrado.Telefones[0].Numero : ""
            }
        }.ToList();
            }
            else
            {
                dgvContatos.DataSource = agenda.Agenda
                    .Select(c => new
                    {
                        c.Nome,
                        c.Email,
                        Nascimento = c.DtNasc.ToString(),
                        Telefone = c.Telefones.Count > 0 ? c.Telefones[0].Numero : ""
                    }).ToList();
            }
        }

        public void LimparTextBox()
        {
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            dtpNascimento.Text = string.Empty;
        }

    }

  
}
