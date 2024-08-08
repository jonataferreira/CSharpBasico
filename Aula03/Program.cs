using Aula03.Models;

Pessoa pessoa = new Pessoa();

Console.Clear();
Console.WriteLine("Digite o nome:");
string nome = (Console.ReadLine());
Console.WriteLine("Digite a idade:");
int idade = Convert.ToInt32(Console.ReadLine());

pessoa.Apresentar(nome, idade);

