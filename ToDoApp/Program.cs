//Console.WriteLine("[S]ee all todo");
//Console.WriteLine("[A]dd a todo");
//Console.WriteLine("[R]emove a todo");
//Console.WriteLine("[E]xite todo app");
/*
int AliYearsOld = 29;
int HosseinYearsOld = 29 ;
if (AliYearsOld > HosseinYearsOld)
    Console.WriteLine("Ali is Grater");
else if ( HosseinYearsOld > AliYearsOld)
    Console.WriteLine("Hossein is grater");
else
    Console.WriteLine("Equal");//
Console.ReadLine();
*/
Console.WriteLine("Please Inter Number One: ");
var numA= Console.ReadLine();
Console.WriteLine("Please Inter Number Two: ");
var numB = Console.ReadLine();
Console.WriteLine("Please Inter A,a Or + For Sum");
Console.WriteLine("Please Inter S,s Or - For sub");
Console.WriteLine("Please Inter M,m Or * for Zarb");
var @operator = Console.ReadLine();
 
Action(int.Parse(numA), int.Parse(numB), @operator.ToString());

void Action (int a=1 , int b = 1, string op="+")
{
    if (op == "A" || op == "a" || op == "+")
        Console.WriteLine(a + b + " " + op);
    if (op == "S" || op == "s" || op == "-")
        Console.WriteLine(a - b + " " + op);
    if (op == "M"||  op == "m" || op=="*")
        Console.WriteLine(a * b + " " + op);
}