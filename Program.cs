using System;

namespace Calculator
{
  class Calculator
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.WriteLine("Calculadora Especial!!!!");
      Console.WriteLine("------------------------");
      Console.WriteLine("Escolha uma das opçoes!");
      Console.WriteLine("------------------------");
      Console.WriteLine("1 - Soma!");
      Console.WriteLine("2 - Dividir!");
      Console.WriteLine("3 - Multiplicar!");
      Console.WriteLine("4 - Subtrair!");
      Console.WriteLine("5 - Sair da Calculadora!");
      Console.WriteLine("------------------------");
      Console.WriteLine("");
      short value = short.Parse(Console.ReadLine());

      switch (value)
      {
        case 1: Soma(); break;
        case 2: Divirdir(); break;
        case 3: Multiplicar(); break;
        case 4: Subtrair(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }

    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Digite um valor!");
      float value = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite outro valor!");
      float value2 = float.Parse(Console.ReadLine());

      Console.WriteLine($"O valor da soma é: {(value + value2)}");
    }

    static void Divirdir()
    {
      Console.Clear();

      Console.WriteLine("Digite um valor!");
      float value = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite outro valor!");
      float value2 = float.Parse(Console.ReadLine());

      Console.WriteLine($"O valor da divisao é: {(value / value2)}");
    }

    static void Multiplicar()
    {
      Console.Clear();

      Console.WriteLine("Digite um valor!");
      float value = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite outro valor!");
      float value2 = float.Parse(Console.ReadLine());

      Console.WriteLine($"O valor da multiplicacao é: {(value * value2)}");
    }

    static void Subtrair()
    {
      Console.Clear();

      Console.WriteLine("Digite um valor!");
      float value = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite outro valor!");
      float value2 = float.Parse(Console.ReadLine());

      Console.WriteLine($"O valor da subtracao é: {(value - value2)}");
    }
  }
}