int number1 = 0;
int number2 = 0;
//write nember
Console.WriteLine("number1");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("number2");
number2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" \ta - + ");
Console.WriteLine(" \tb - - ");
Console.WriteLine(" \tc - * ");
Console.WriteLine(" \td - / ");
switch (Console.ReadLine())
    { 
    case "a":
        Console.WriteLine(number1 + number2); break;
        case "b":
            Console.WriteLine(number1 - number2); break;
             case "c":
                Console.WriteLine(number1 * number2); break;
                    case "d":
                    Console.WriteLine(number1 / number2); break;
            }
    Console.ReadLine();