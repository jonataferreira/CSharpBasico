﻿
using Aula02.Common.Models;

Pessoa pessoa = new Pessoa();
bool exibirMenu = true;


Console.Clear();
Console.WriteLine("Você gostaria de continuar? (S / N): ");
char resposta = Console.ReadLine().ToUpper()[0];

do
{
    if (resposta == 'S')
    {
        //Console.Clear();
        Console.WriteLine("Escolha o tipo de ferramenta");
        Console.WriteLine("1 - Calculadora");
        Console.WriteLine("2 - Tabuada");
        Console.WriteLine("Digite Qualquer outra tecla para sair");
        string opcao = Console.ReadLine();
     

        switch (opcao)
        {
            case "1":
                pessoa.Calculadora();
                break;

            case "2":
                pessoa.Tabuada();
                break;

            default:
                exibirMenu = false;
                break;

        }  
    }
    else { exibirMenu = false;}
   
    

    //pessoa.Tabuada(x);
} while (exibirMenu == true) ;

Console.WriteLine("Fim da execução");



