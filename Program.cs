

Console.WriteLine("Divisão de dois números!");

double n1, n2;

Console.Write("digita um número legal aí...");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("agora outro número...");
n2 = Convert.ToInt32(Console.ReadLine());

if (n2 == 0)
{
 

    Console.WriteLine("tu fez uma cagada aí, faz direito!");

}
else
{
    
    double resultado = n1 / n2;
    Console.WriteLine($"{n1} dividido poi {n2} = {resultado}");
}