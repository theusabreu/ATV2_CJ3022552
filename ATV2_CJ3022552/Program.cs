namespace ATV2_CJ3022552

         Console.WriteLine("Atividade 1");
//Atividade 1 - Sala
float investimento1 = 1000;
float variação_dia1 = -3.4f;
float variação_dia2 = 2.8f;
float variação_dia3 = 14f;
float variação_dia4 = -8.5f;
 
float valor_dia1 = investimento1 * (1 + variação_dia1 / 100);
float valor_dia2 = valor_dia1 * (1 + variação_dia2 / 100);
float valor_dia3 = valor_dia2 * (1 + variação_dia3 / 100);
float valor_atual = valor_dia3 * (1 + variação_dia4 / 100);
 
Console.WriteLine("O valor atual dos investimentos de Marquesito é R$" + valor_atual.ToString("0.00"));
 
Console.WriteLine("Atividade 2");
 
//Atividade 2 - Sala
Console.WriteLine("Digite seu salário: ");
float salário = int.Parse(Console.ReadLine());
float aumento = salário * 0.25f;
float total = salário + aumento;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));
 
Console.WriteLine("Atividade 3");
 
//Atividade 3 - Sala
Console.WriteLine("Digite o número desejado: ");
int numero = int.Parse(Console.ReadLine());
numero = (numero * 3 + 1) + (numero * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numero.ToString());
 
Console.WriteLine("");
 
//Atividade 1 - Lista
 
 
Console.WriteLine("Digite o seu valor em metros: ");
double quantidade = double.Parse(Console.ReadLine());
double centimetros = quantidade / 100;
double milimetros = quantidade / 1000;
 
Console.WriteLine("O seu valor em centímetros é: " + centimetros.ToString("0.00"));
Console.WriteLine("O seu valor em milímetros é: " + milimetros.ToString("0.00"));
Console.ReadKey();
 
//Atividade 2 - Lista
Console.WriteLine("Digite o valor em Fahrenheit: ");
float f_graus = float.Parse(Console.ReadLine());
float c_graus;
 
Console.WriteLine("Digite o valor novamente: ");
int f_graus1 = int.Parse(Console.ReadLine());
int c_graus1;
 
c_graus = (f_graus - 32.0f) * (5.0f / 9.0f);
c_graus1 = (f_graus1 - 32) * (5 / 9);
Console.WriteLine("O resultado em celsius com float é: {0} \n O resultado em celsius com inteiro é: {1}", c_graus, c_graus1);
 
 
//Atividade 3 - Lista
Console.WriteLine("Digite sua altura em metros: ");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine("Digite seu peso em kilos: ");
float peso = float.Parse(Console.ReadLine());
float imc;
imc = peso / (altura * altura);
Console.WriteLine("O seu IMC é: " + imc.ToString());
 
 
//Atividade 4 - Lista
Console.WriteLine("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
float peso1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda nota: ");
float peso2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da terceira nota: ");
float peso3 = float.Parse(Console.ReadLine());
float total2;
 
total = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
Console.WriteLine("A média poderada dos pesos é: " + total.ToString());
 
//Atividade 5 - Lista (Fórmula da velocidade)
Console.WriteLine("Digite a distância percorrida: ");
float distância = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o tempo que foi gasto na ação em segundos: ");
float tempo = float.Parse(Console.ReadLine());
float velocidade;
 
velocidade = (distância / tempo);
Console.WriteLine("A velocidade em a ocorreu a ação foi de: " + velocidade.ToString());
 
//Atividade 6 -  Lista
Console.WriteLine("Digite seu salário: ");
float salário1 = int.Parse(Console.ReadLine());
float aumento1 = salário * 0.25f;
float total1 = salário + aumento;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));
 
//Atividade 7 - Lista 
Console.WriteLine("Digite o valor a ser convertido em reais: ");
double real = double.Parse(Console.ReadLine());
double valor_dolar = 4.97;
double dolar;
 
dolar = real / valor_dolar;
Console.WriteLine("O valor em real convertido para dólar é: " + dolar.ToString());
 
//Atividade 8 - Lista
Console.WriteLine("Digite o número desejado: ");
int numero1 = int.Parse(Console.ReadLine());
numero = (numero * 3 + 1) + (numero * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numero.ToString());
 
//Atividade 9 - Lista
int val, milhar, milhar1, milhar2, centena, centena1, dezena, dezena1, unidade, val1, val2;
 
Console.WriteLine("Digite um número que tenha 4 digítos: ");
val = int.Parse(Console.ReadLine());
milhar1 = val / 1000;
milhar2 = milhar1 * 1000;
centena = (val - milhar1) / 1000;
centena1 = centena * 100;
val1 = milhar2 + centena1;
dezena = (val - val1) / 10;
dezena1 = dezena * 10;
val2 = milhar1 + centena1 + dezena1;
unidade = val - val2;
 
Console.WriteLine("{0}\n{1}\n{2}\n{3}", milhar1, centena, dezena, unidade);
 
 
//Atividade 10 - Lista
float investimento = 1000.0f;
float variação_dia10 = -3.4f;
float variação_dia20 = 2.8f;
float variação_dia30 = 14f;
float variação_dia40 = -8.5f;
 
float valor_dia10 = investimento * (1 + variação_dia10 / 100);
float valor_dia20 = valor_dia1 * (1 + variação_dia2 / 100);
float valor_dia30 = valor_dia2 * (1 + variação_dia3 / 100);
float valor_atual0 = valor_dia3 * (1 + variação_dia4 / 100);
 
Console.WriteLine("O valor atual dos investimentos de Marquesito é R$" + valor_atual.ToString("0.00"));
 
//Atividade 11 - Lista
Console.WriteLine("Digite o número desejado: ");
float num = float.Parse(Console.ReadLine());
float quadrado;
float cubo;
 
quadrado = (num * num);
cubo = (num * num * num);
 
Console.WriteLine("O número ao quadrado é: {0} \n O resultado ao cubo é: {1}", quadrado, cubo);
 
//Atividade 12 - Lista
Console.WriteLine("Digite sua altura: ");
float altura1 = float.Parse(Console.ReadLine());
double ideal1;
double ideal2;
 
 
ideal1 = (72.7 * altura - 58);
ideal2 = (62.1 * altura - 44.7);
 
Console.WriteLine("Para mulher, o peso ideal é: {0} \n Para homem, o peso ideal é: {1}", ideal2, ideal1);
 
 









        }
    }
}








