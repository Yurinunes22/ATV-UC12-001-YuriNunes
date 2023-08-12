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
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;


            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("O nome deve ser preenchido corretamente");
                }
            }
        }
        private string _cpf;
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value == String.Empty || Cpf.Length != 11) 
                {
                    throw new Exception("Preencha o CPF corretamente");
                }
            }
        }
            
            

            
    
        public DateTime DataNasc { get; set; }
        private double _dataNasc;   
        public double RendaMensal 
        { 
            get 
                set; }
        //static int TotalCliente { get; set; }

        public Correntista()
        {
          //IdCorrentista = IdCorrentista + 1;    
         
        }

        public Correntista( int idcorrentista, string nome, string cpf, DateTime dataNasc, double rendamensal )
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

        


        public string  RetornarPerfilCliente ()  
        {
            if (this.RendaMensal <= 3000)
            {
                return  "Silver";
                
            }
            else if (this.RendaMensal >= 3000.01 && this.RendaMensal <= 5000)
            {
                return  "Gold";
            }

            else if (this.RendaMensal >= 5000.01 && this.RendaMensal <= 10000)
            {
                return  "Diamond";
            }
            else
            {
                return  "Black";
            }


        }

        public string MensagemBoasVindas() 

        {
            return $"Olá {this.Nome}!\nSeja Bem Vindo ao Sifrão\nCliente {RetornarPerfilCliente()}";

        }



    }
}
    



