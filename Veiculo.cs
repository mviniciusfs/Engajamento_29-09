using System;
using System.Globalization;

class Veiculo
{
  private int qtdRodas;
  private string Cor;
  private int Ano;
  private string Modelo;
  private double valorAtual;
  private bool possuiSeguro;
  private bool possuiPendencia;

  public Veiculo()
  {
    qtdRodas = 4;
    Cor = "Preto";
    Ano = 2002;
    Modelo = "Marea";
    valorAtual = 10000;
    possuiSeguro = false;
    possuiPendencia = true;
  }

  public Veiculo(int a, string c, double va)
  {
    Ano = a;
    Cor = c;
    valorAtual = va;
  }

  public Veiculo(int qr, string c, int a, string m, double va, bool ps, bool pp)
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