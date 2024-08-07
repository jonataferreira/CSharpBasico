using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03.Models
{
    public class Pessoa
    {
        //public Pessoa(  ) { }

       public Pessoa(string nome, int idade) 
       { 
        Nome = nome;
        Idade = idade;
       }
       // public Pessoa(string nome, string sobrenome) { }
        private string _nome;
        private int _idade; 

        
        public string Nome 
        {
             get => _nome;
              
             set 
             {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
             }
             
        }
        
        public int Idade 
        {
             get
             {
                return _idade;
             }

             set 
             {
                if (value < 0)
                {
                    throw new ArgumentException("A idade e não pode ser menor que 0");
                }

                _idade = value;
             }
             
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto { get => $"{Nome} {Sobrenome}".ToUpper(); }

        // public void Apresentar(string nome, int idade)
        // {
        //      this.Nome = nome;
        //      this.Idade = idade;
        //     Console.WriteLine($"Nome: {NomeCompleto}, Idade: {idade}");
        // }
         public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

    }

}