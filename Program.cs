﻿Console.Clear();

﻿Console.WriteLine("----Raio e Trovão----\n");


Console.WriteLine($"Trovão a {10} segundos ==> raio caiu a {DistanciaDoRaioKm(10):N5} quilômetros");
Console.WriteLine($"Trovão a {6} segundos ==> raio caiu a {DistanciaDoRaioKm(6):N5} quilômetros");

double DistanciaDoRaioKm (double segundos)

{
   const double VelocidadeDoSomKms = 340.29 / 1000;

    return segundos * VelocidadeDoSomKms;

}