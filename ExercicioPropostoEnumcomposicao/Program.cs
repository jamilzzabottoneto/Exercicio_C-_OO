using ExercicioPropostoEnumcomposicao.Entities;
using ExercicioPropostoEnumcomposicao.Enums;
using System;

namespace ExercicioPropostoEnumcomposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date(DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email, birthDate);

            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("Enter Order Data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, c1);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product prod1 = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(qtd, prodPrice, prod1);
                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
