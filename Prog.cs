using System;

static void Main(string[] args)
{
    int num = 103;
string otvet = "\0", buff;
while (num > 0)
{
    if (num % 2 <= 0)
    {
        buff = "0";
        otvet = String.Concat(otvet, buff);
    }
    if (num % 2 > 0)
    {
        buff = "1";
        otvet = String.Concat(otvet, buff);
    }

    num /= 2;
}
for (int i = otvet.Length - 1; i > 0; i--)
{
    Console.Write(otvet[i]);
}
        }
 