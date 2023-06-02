bool c1 = 2 > 3 && 4 != 5;
Console.WriteLine(c1);

bool c2 = 2 > 3 || 4 != 5;
Console.WriteLine(c2);

bool c3 = !(2 > 3) && 4 != 5;
Console.WriteLine(c3);

bool c4 = 10<5;
bool c5 = c1 || c2 && c3; 
Console.WriteLine(c5);

if(c1 && c2 || c3)
{
    Console.WriteLine("Condicional");
}