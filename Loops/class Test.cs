using System;
class Test
{
    public static void Main()
    {
        int i=1;
         //do-while loop
        do
        {
            Console.WriteLine("Hello world");
            i++;
        }while(i<4); 

        //while loop
        i=1;
        while(i<4)
        {
            Console.WriteLine("Hello world {0}",i);
            i++;
        }   

        //for loop
        for(i=1;i<4;i++)
        {
            Console.WriteLine("Hello world {0}",i);
        }   

        //infinite while loop
        while (true)
        {
            Console.WriteLine("Infinite while loop {0}",i);
            i++;
        }   

        //infinite for loop
        for(;;)
        {
            Console.WriteLine("Infinite for loop {0}",i);
            i++;
        }   

    }
}
