using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tasks6
{
    delegate void Notifier(string message);
    class Money
    {
        Notifier sendNotification;
        double balance_now = 0;
        public double money;
        public string result;

        public void AddNotifier(Notifier notifier)
        {
            sendNotification += notifier;
        }

        public void balace()
        {
            Console.WriteLine("Enter balance: ");
            balance_now = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your balance now is: ");
            result = String.Format(new CultureInfo ("en-US"),"{0:C2}", balance_now);
            sendNotification?.Invoke(result);
        }

        public void diposit()
        {
            Console.WriteLine("Enter your dipodit: ");
            money = Convert.ToDouble(Console.ReadLine());
            balance_now += money;
            Console.WriteLine("Your balance now is: ");
            result = String.Format(new CultureInfo("en-US"), "{0:C2}", balance_now);
            sendNotification?.Invoke(result);
        }

        public void take_off()
        {

            Console.WriteLine("Enter the amount you want to withdraw: ");
            money = Convert.ToDouble(Console.ReadLine());
            if (money > balance_now)
            {
                Console.WriteLine("Error!");

            }
            else { balance_now -= money; }
            Console.WriteLine("Your balance now is: ");
            result = String.Format(new CultureInfo("en-US"), "{0:C2}", balance_now);
            sendNotification?.Invoke(result);
        }
    }
}
