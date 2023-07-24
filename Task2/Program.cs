using System.Net.Sockets;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice()
            {
                invoiceDetails = new InvoiceDetails()
                {
                    InvoiceNumber = 1,
                    OrderNumber = 1,
                    OrderDate = DateTime.Now,

                },
                customerDetails = new Customer()
                {
                    CustomerName = "ZAK",
                    CustomerEmail = "ZAK@mail.com",
                    CustomerPhone = "1234567890",
                    BillingAddress = new Address()
                    {
                        Hno = "2A",
                        Landmark = "street 5",
                        City = "XYZ",
                        State = "Telangana",
                        Zipcode = 234578
                    },
                    ShippingAddress = new Address()
                    {
                        Hno = "6B/2",
                        Landmark = "Flipkart",
                        City = "ABC",
                        State = "Newyork",
                        Zipcode = 123456
                    },
                },
            };
            invoice.products.Add(new Product()
            {
                SrNo = 1,
                ProductName = "BC",
                Description = "Test",
                Quantity = 1,
                UnitPrice = 10.0,
            });
            invoice.products.Add(new Product()
            {
                SrNo = 2,
                ProductName = "ASC",
                Description = "Test",
                Quantity = 3,
                UnitPrice = 132.5,
            });
            invoice.Total = Program.findTotal(invoice.products);
        }
        
        static double findTotal(List<Product> products)
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Quantity * product.UnitPrice;
            }
            return total;
        }

    }

    class Invoice {
        
        public InvoiceDetails invoiceDetails {  get; set; }
        public Customer customerDetails { get; set; }

        public List<Product> products;
        public double Total { get; set; }

        public Invoice()
        {
            products = new List<Product>();
        }
    }

    class InvoiceDetails
    {
        public int InvoiceNumber { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }

    class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
    }

    class Product
    {
        public int SrNo { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set;}
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

    class Address
    {
        public string Hno { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
    }
}