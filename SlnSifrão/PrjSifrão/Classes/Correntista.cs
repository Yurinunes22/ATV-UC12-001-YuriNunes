using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjSifrão.Classes
{
    public class Correntista
    {

        private int _id;
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id não pode ser menor que zero!");
                }
                else
                {
                    this._id = value;
                }
            }

        }

        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public double RendaMensal { get; set; }


        public Correntista()
        {
          
         
        }

        public Correntista(int id, string nome, int cpf, DateTime dataNasc, double rendamensal )
        { 
         this.Id = id;
         this.Nome = nome;
         this.Cpf = cpf;
         this.DataNasc = dataNasc;
         this.RendaMensal = rendamensal;
        
        }

        public int VerificarSeCorrentistaMaior()
        {
            int aux = Convert.ToInt32(DateTime.Now - DataNasc);
            if (aux <18)
            {
                MessageBox.Show("Menor de Idade");
            }
            else
            {
                MessageBox.Show("maior de idade");
            }


            return aux;
         
         
          
         
        }









    }
}
    



