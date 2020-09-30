using System;
using System.Globalization;

class Veiculo
{
  public string qtdRodas;
  public string Cor;
  public int Ano;
  public string Modelo;
  public double valorAtual;
  public string possuiSeguro;
  public string possuiPendencia;

  public Param1()
  {

  }

  public Param2(int a, string c, double va)
  {
    Ano = a;
    Cor = c;
    valorAtual = va;
  }

  public Param3(string qr, string c, int a, string m, double va, string ps, string pp)
  {
    qtdRodas = qr;
    Cor = c;
    Ano = a;
    Modelo = m;
    valorAtual = va;
    possuiSeguro = ps;
    possuiPendencia = pp;
  }


}