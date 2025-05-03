using System.Globalization;

Console.WriteLine("--Calculadora IMC--");

Console.Write("Digite sua altura em metros: ");
string alturaTexto = Console.ReadLine()?? "0";
double altura = double.Parse(alturaTexto.Replace(',', '.'), CultureInfo.InvariantCulture);

Console.Write("Digite seu peso em kg: ");
string pesoTexto = Console.ReadLine() ?? "0";
double peso = double.Parse(pesoTexto.Replace(',', '.'), CultureInfo.InvariantCulture);

double imc = peso / (altura * altura);

Console.WriteLine($"\nSeu IMC é {imc:F1}");

if (imc < 18.5)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Classificação: Abaixo do peso");
}
else if (imc < 25)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Classificação: Peso normal");
}
else if (imc < 30)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Classificação: Sobrepeso");
}
else if (imc < 35)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Classificação: Obesidade grau I");
}
else if (imc < 40)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Classificação: Obesidade grau II");
}
else
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Classificação: Obesidade grau III");
}
Console.ResetColor();