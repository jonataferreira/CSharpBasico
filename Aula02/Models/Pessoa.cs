namespace Aula02.Models
{
    public class Pessoa
    {
        public int count {get; set;}


        public void Tabuada (int x)
        {
            for (int y = 0; y <= 10; y++)
            {
                int tabuada = y*x;

                Console.WriteLine(x + " X " + (y) + " = " + (tabuada));

            }
        }
    
    }
}