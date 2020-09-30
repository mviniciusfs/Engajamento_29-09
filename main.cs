using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Veiculo carro01 = new Veiculo();

    Veiculo carro02 = new Veiculo(2000, "Vermelho", 34000);

    Veiculo carro03 = new Veiculo(3, "Azul", 1990, "Fusca", 12000, false, false);
   
  }
}