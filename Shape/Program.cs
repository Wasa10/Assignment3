using Shape;
loop:
circle c=new circle();
rectangle r=new rectangle();
int cho = 0;
do
{
    Console.WriteLine("\n1,circle");
    Console.WriteLine("2,rectangle");
    Console.Write("Enter a number: ");
    cho = Int32.Parse(Console.ReadLine());
    Console.Clear();
} while (cho < 1 || cho > 2);
if (cho == 1)
{
    Console.Write("Enter the radius: ");
    c.radius = Double.Parse(Console.ReadLine());
    int cho2 = 0;
    Console.Clear();
    do
    {
        Console.WriteLine("\n1,Area");
        Console.WriteLine("2,Perimeter");
        Console.Write("choose what you want to calculate\nEnter a number: ");
        cho2 = Int32.Parse(Console.ReadLine());
    } while (cho < 1 || cho > 2);
    Console.Clear();
    if (cho2 == 1)
    {
        Console.WriteLine("The area of the circle is " + c.Area());
        goto loop;
    }
    else
    {
        Console.WriteLine("The perimeter of the circle is " + c.perimeter());
        goto loop;
    }
}
else
{
    Console.Write("Enter the length: ");
    r.length = Double.Parse(Console.ReadLine());
    Console.Write("Enter the width: ");
    r.width = Double.Parse(Console.ReadLine());
    int cho2 = 0;
    Console.Clear();
    do
    {
        Console.WriteLine("\n1,Area");
        Console.WriteLine("2,Perimeter");
        Console.Write("choose what you want to calculate\nEnter a number: ");
        cho = Int32.Parse(Console.ReadLine());
    } while (cho < 1 || cho > 2);
    Console.Clear();
    if (cho2 == 1)
    {
        Console.WriteLine("The area of the rectangle is " + r.Area());
        goto loop;
    }
    else
    {
        Console.WriteLine("The perimeter of the rectangle is " + r.perimeter());
        goto loop;
    }
}