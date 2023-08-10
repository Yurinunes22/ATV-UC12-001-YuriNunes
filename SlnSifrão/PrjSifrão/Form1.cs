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
            correntista.VerificarSeCorrentistaMaior();
        }
    }
}