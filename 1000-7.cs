int c = 1000; //initial number
while (c > 0) //calculation cycle
{
    Thread.Sleep(001);
    int i = c - 7;
    Console.WriteLine("I`m Ghoule {0}", i);//write result THIS text
    c = i;
}
Console.WriteLine("I`m Ghoule");// this text writen for fun

