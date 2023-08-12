using PrjSifrão.Classes;

namespace PrjSifrão
{
    public partial class Form1 : Form
    {
        Correntista correntista;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRendaMensal_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Correntista correntista = new Correntista(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, Convert.ToDateTime(dtDataNasc.Text), Convert.ToDouble(txtRendaMensal.Text));


                if (correntista.VerificarSeCorrentistaMaior() == true)
                {
                    MessageBox.Show($"Cadastrado com Sucesso!\n{correntista.IdCorrentista}\n{correntista.Nome}\n{correntista.Cpf}\n{correntista.DataNasc}\n{correntista.RendaMensal}\n{correntista.RetornarPerfilCliente()}");
                    MessageBox.Show(correntista.MensagemBoasVindas());
                }
                else
                {

                    MessageBox.Show("O correntista deve possuir ao menos 18 anos de idade para registro no banco");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            



            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNome.Text, out var Nome))
            {
                txtNome.Clear();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out var Nome)) //!=diferente
            {
                txtId.Clear();
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCpf.Text, out var Nome)) //!=diferente
            {
                txtCpf.Clear();
            }
        }

        private void txtRendaMensal_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRendaMensal.Text, out var Nome)) //!=diferente
            {
                txtRendaMensal.Clear();
            }
        }
    }
}