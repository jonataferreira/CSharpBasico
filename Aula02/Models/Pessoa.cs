namespace Aula02.Models
{
    public class Pessoa
    {
        public int count {get; set;}


        public void Tabuada()
        {
            int x = 0;
            int tabuada = 0;
            Console.WriteLine("Digite o número que você gostaria de saber a tabuada: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y <= 10; y++)
            {
                tabuada = y * x;
                Console.WriteLine(x + " X " + (y) + " = " + (tabuada));
            }
            
        }

        private void Soma()
        {
                
                string control = "S";
                int soma = 0;
                while ( control == "S")
                {
                    Console.WriteLine("Digite o valor que gostaria de gostaria de soma:");
                    soma += Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"A soma atual é: " + (soma));
                    Console.WriteLine("Digite S para somar ou qualquer outra tecla para sair");
                    control = Console.ReadLine().ToUpper();
                }
        }

        private void Subtracao()
        {
                string control = "S";
                Console.WriteLine("Digite o valor inicial");
                int total = Convert.ToInt32(Console.ReadLine());

                while ( control == "S")
                {
                    Console.WriteLine("Digite o valor que gostaria de subtrair: ");
                    total -= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O valor atual é: " + (total));
                    Console.WriteLine("Digite S para continuar a subtrair");
                    control = Console.ReadLine().ToUpper();
                }
        }

        public void Calculadora ()
        {
            Console.Clear();
            Console.WriteLine("Digite a operação desejada:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            //"/n3 - Divisão /n4 - Multiplicação");
            string opcao = Console.ReadLine();

            
            switch (opcao)
            {
                case "1":
                    Soma();
                    break;

                case "2":
                    Subtracao();
                    break;

                // case '1':
                //     pessoa.Calculadora();
                //     break;

                // case '2':
                //     pessoa.Tabuada();
                //     break;

            }
        }
    
    }
}