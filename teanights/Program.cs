using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teanights
{
    class Program
    {
        static void Main(string[] args)
        {


            /* int people = 40;
             int averagedonation = 100;
             int candleprice = 10;
             int result = (people * averagedonation *30)/ candleprice;
             string outmessage = "may afford";
             outmessage = outmessage + result + "candles";
             Console.WriteLine(result);
             Console.ReadLine();*/
            string password = Console.ReadLine();
            while(password!="12345")
            {
                password = Console.ReadLine();

            }
            int money = 1000;
            int candlebought = 0;
            int candleput=0; 
            while(true)
            {
                Console.Clear;
                Console.WriteLine("YOU HAVE" + money + "pounds");
                Console.WriteLine("you have put" + candleput + "candles");
                Console.WriteLine("Buy-buy acandle,put-put a candle");
                string buf = Console.ReadLine();
                if(buf=="buy")
                {
                    if(money>=10)
                    { money -= 10;candlebought++; }
                    else
                    { Console.WriteLine("not enough money"); }
                }
                else if(buf=="put")

            }

        }
        
    }
}
