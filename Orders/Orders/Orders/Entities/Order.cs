using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orders.Entities.Enums;
using System.Globalization;

namespace Orders.Entities
{
    public class Order
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }


        public Order(){}

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public void ClearOrder()
        {
            Items.Clear();
        }

        public double TotalAmmount()
        {
            double sum = 0.0;
            
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return double.Parse(sum.ToString("T2"), CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Client data:\n");
            sb.AppendLine(Client.ToString());
            sb.Append("Order Data:\n");
            sb.AppendLine($"Status: {Status.ToString()}");
            sb.AppendLine($"Order Date: {OrderDate.ToString("dd/MM/yyyy HH:mm:ss tt")}");
            sb.AppendLine("Order Items:\n");
            
            foreach (var item in Items)
            {
                sb.AppendLine(Items.ToString());
            }

            return sb.ToString();
        }
    }
}