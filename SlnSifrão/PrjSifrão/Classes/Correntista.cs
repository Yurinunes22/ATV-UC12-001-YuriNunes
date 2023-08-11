using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSifrão.Classes
{
    public class Correntista
    {



        public int IdCorrentista { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public double RendaMensal { get; set; }
        //static int TotalCliente { get; set; }

        public Correntista()
        {
          //IdCorrentista = IdCorrentista + 1;    
         
        }

        public Correntista( int idcorrentista, string nome, int cpf, DateTime dataNasc, double rendamensal )
        {
            //TotalCliente = TotalCliente + 1;
            //IdCorrentista = TotalCliente;
          IdCorrentista = idcorrentista; 
         Nome = nome;
         Cpf = cpf;
         DataNasc = dataNasc;
         RendaMensal = rendamensal;
        
        }

        public bool VerificarSeCorrentistaMaior()
        {

            int idade = DateTime.Now.Year - this.DataNasc.Year;  

            if (DateTime.Now.Month < this.DataNasc.Month || (DateTime.Now.Month == this.DataNasc.Month && DateTime.Now.Day < this.DataNasc.Day))
            {
                idade = idade - 1;
            }

            if (idade>=18)
            {
                return true;
            }
            else
            {
                    return false;   
            }

        } 




        /*public double RetornarPerfilCliente (double rendamensal)  
        {
            if (rendamensal <= 3000)
            {
                MessageBox.Show("Silver");
            }
            else if (rendamensal >=3000.01 && rendamensal <= 5000)
            {
                MessageBox.Show("Gold");
            }

            else if (rendamensal >= 5000.01 && rendamensal <= 10000)
            {
                MessageBox.Show("Diamond");
            }
            else
            {
                MessageBox.Show("Black");
            }




                    return rendamensal;
        }*/
       




    }
}
    



