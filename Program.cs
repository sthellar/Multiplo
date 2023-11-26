Console.WriteLine("----Multíplo----");
int n1, n2;
Console.WriteLine();

Console.Write("Digete um número...:"); 
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Analisar se é multiplo de....:");
n2 = Convert.ToInt32(Console.ReadLine());

if (n1 % n2 == 0)
{
    Console.WriteLine($"{n1} é multiplo de {n2}");
}
else
{
    Console.WriteLine($"{n1} não é multiplo de {n2}");
}


