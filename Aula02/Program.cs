// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Aula02.Models;

Pessoa pessoa= new Pessoa();

//string char = Console.ReadLine("Você gostaria de continuar? (S / N): ");
Console.WriteLine("Você gostaria de continuar? (S / N): ");
char resposta = Console.ReadLine().ToUpper()[0];
 if (resposta == 'S')
 {

    Console.WriteLine("Digite o número que você gostaria de saber a tabuada: ");
    int x = Convert.ToInt32(Console.ReadLine());
    pessoa.Tabuada(x);
}





