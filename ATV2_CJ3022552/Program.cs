namespace ATV2_CJ3022552
{
    internal class Program
    {
        static void Main(string[] args)
        {float salario;

            //leitura do salario 
            Console.WriteLine("entre com o seu salario: ");
            salario = float.Parse(Console.ReadLine());
            salario = salario + (25.0f / 100.0f) * salario;
            Console.WriteLine("o novo salario é R$ {0}", salario);



            //exercico 2 
            Console.WriteLine("digite um numero");
            int numero = int.Parse(Console.ReadLine());
            numero = (numero * 3 + 1) + (numero * 2 - 1);
            Console.WriteLine("o valor final sera de " + numero.ToString());



            // exercicio 3 

            float investimento = 1000;

            // Variações porcentuais nos primeiros dias 

            float vd1 = -3.4f;
            float v2 = 2.8f;
            float v3 = 14f;
            float v4 = 8.5f;

            // calculo

            float valor = investimento * (1 + vd1 / 100);
            float valor2= investimento * (1+ v2 / 100);
            float valor3 = investimento * (1 + v3 / 100);
            float valor4 = investimento * (1 + v4 / 100);


            // valor atual
            Console.WriteLine("o valor atual dos investimentos sera de R$ ", valor4.ToString("0.00"));  










        }
    }
}








