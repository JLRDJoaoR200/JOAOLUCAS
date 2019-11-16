using System;

class MainClass {
  public static void Main (){
    string Pn, Sn;

    int num1, num2, soma;

    Console.Write("Digite o primeiro numero: ");
    Pn = Console.ReadLine();

    Console.Write("Digite o segundo numero: ");
    Sn = Console.ReadLine();

    num1 = Int32.Parse(Pn);
    num2 = Int32.Parse(Sn);

    soma = num1 + num2;

    Console.WriteLine("O resultado é:" + soma);
  }
}