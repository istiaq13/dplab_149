using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab1
{
    public interface PaymentMethod
    {
        void ProcessPayment(double amount);
    }

    public class CreditCard : PaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Credit Card.");
        }
    }

    public class PayPal : PaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via PayPal.");
        }
    }

    public class DigitalWallet : PaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of {amount} via Digital Wallet.");
        }
    }

}
