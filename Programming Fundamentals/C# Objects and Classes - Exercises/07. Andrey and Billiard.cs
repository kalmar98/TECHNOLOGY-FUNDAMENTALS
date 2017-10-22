using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace training
{
    class Training
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var _productAndPrice = new Dictionary<string, decimal>();
            var customers = new List<Customer>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var product = input[0];
                var price = decimal.Parse(input[1]);

                if (!_productAndPrice.ContainsKey(product))
                {
                    _productAndPrice[product] = price;
                }
                else
                {
                    _productAndPrice[product] = price;
                }
                
            }
            var request = Console.ReadLine();
            while (request!= "end of clients")
            {

                var data = request.Split('-', ',');
                var customer = data[0];
                var product = data[1];
                var quantity = int.Parse(data[2]);

                if (_productAndPrice.ContainsKey(product))
                {


                    if(customers.Exists(a=>a.Name == customer))
                    {

                        var sameCustomer = customers.Find(a => a.Name == customer);


                        if (!sameCustomer.Shoplist.ContainsKey(product))
                        {
                            sameCustomer.Shoplist[product] = quantity;
                        }
                        else
                        {
                            sameCustomer.Shoplist[product] += quantity;
                        }

                        sameCustomer.Bill += quantity * _productAndPrice[product];

                        

                        goto end;
                    }
                    
                    var newCustomer = new Customer
                    {
                        Name = customer,
                        Shoplist = new Dictionary<string, int>(),
                        Bill = 0,
                    };
                    
                   



                    if (!newCustomer.Shoplist.ContainsKey(product))
                    {
                        newCustomer.Shoplist[product] = quantity;
                    }
                    else
                    {
                        newCustomer.Shoplist[product] += quantity;
                    }

                    newCustomer.Bill += quantity * _productAndPrice[product];

                    customers.Add(newCustomer);


                }
                end:
                request = Console.ReadLine();
            }
            customers = customers.OrderBy(a => a.Name).ToList();
            var totalBill = 0m;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                foreach (var productAndQuantity in customer.Shoplist)
                {
                    Console.WriteLine($"-- {productAndQuantity.Key} - {productAndQuantity.Value}");
                }
                totalBill += customer.Bill;
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            


            Console.WriteLine($"Total bill: {totalBill:f2}");
        }


    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> Shoplist { get; set; }
        public decimal Bill { get; set; }

    }
}
