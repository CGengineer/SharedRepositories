using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerList = new List<Customer>
            {
                new Customer { CustomerID = 1, Name = "Alice" },
                new Customer { CustomerID = 2, Name = "Bob" },
            };

            var paymentDetailList = new List<PaymentDetail>
            {
                new PaymentDetail { CustomerID = 1, Amount = 100.00m },
                new PaymentDetail { CustomerID = 1, Amount = 110.00m },
                new PaymentDetail { CustomerID = 2, Amount = 200.50m },
                new PaymentDetail { CustomerID = 2, Amount = 210.50m },
                new PaymentDetail { CustomerID = 2, Amount = 220.50m },
            };

            var result = customerList
                .GroupJoin(paymentDetailList,
                           customer => customer.CustomerID, // Customerリストのキー
                           payment => payment.CustomerID,    // PaymentDetailリストのキー
                           (customer, payments) => new
                           {
                               customer.CustomerID,
                               customer.Name,
                               Payments = payments.ToList() // 支払い詳細のリスト
                           })
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Customer: {item.Name}");
                foreach (var payment in item.Payments)
                {
                    Console.WriteLine($"  Amount: {payment.Amount}");
                }
            }

            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
    }

    public class PaymentDetail
    {
        public int CustomerID { get; set; }
        public decimal Amount { get; set; }
    }
}
