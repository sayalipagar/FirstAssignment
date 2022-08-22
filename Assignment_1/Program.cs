namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First class
            // Class1 myObj = new Class1();
            //  Console.WriteLine(myObj.color);

            //Second class
            // Add myObj = new Add();
            // Console.WriteLine(myObj.addme(3, 8));
            // Console.WriteLine(myObj.subme(8, 4));
            //Console.ReadLine();

            // Third class
            // Mul New = new Mul();
            //  Console.WriteLine(New.MulMe(10, 10));
            //  Console.WriteLine(New.DividwMe(12,12));
            // Console.ReadLine();


            Console.WriteLine("1.Addition \n2.Sustraction\n3.Exit");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Choose an option to execute");
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                          
                        case 1:
                        Addition New = new Addition();
                        int a =Convert.ToInt32(Console.ReadLine());
                        int b=Convert.ToInt32(Console.ReadLine());
                        New.Add(a,b);
                        break;


                        case 2:
                        Substraction substract = new Substraction();
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(substract.Sub(c, d));

                        break;

                    case 3:

                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose an correct option");

                        break;
                }
            }
            
                
            
        }
    }
}