/*
 3- faça um programa que leia um vetor de caracteres de 10 posicoes e 
 converta as vogais de minusculos para maiusculo
 */

Console.WriteLine("=====Minusculos e maiusculos=====");

char[] letras = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite a letra({i}): ");
    letras[i] = char.Parse(Console.ReadLine());

    switch (letras[i])
    {
        case 'a':
            letras[i] = 'A'; 
            break;
        case 'e':
            letras[i] = 'E';
            break;
        case 'i':
            letras[i] = 'I';
            break;
        case 'o':
            letras[i] = 'O';
            break;
        case 'u':
            letras[i] = 'U';
            break;
        default:
            break;
    }
}

Console.WriteLine("\n=============================");
Console.WriteLine($"Texto formatado: ");

for (int i = 0;i < 10; i++)
{
    Console.Write(letras[i]);
}

Console.WriteLine("\n=============================");



Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();