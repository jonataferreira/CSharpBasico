using Aula01.Models;


/*Pessoa p = new Pessoa();

p.Nome = "Jonata";
p.Idade = 31;
p.Apresentar();*/
string apresentacao = "Olá seja bem vindo";
// double altura = 1.80;
// decimal preco = 1.80M; //decimaal representa valores monetários

DateTime dataAtual = DateTime.Now;
DateTime data5Dias = DateTime.Now.AddDays(5);

Console.WriteLine(apresentacao);   
Console.WriteLine("São " + dataAtual);   
Console.WriteLine("Serão " + data5Dias);   
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));   