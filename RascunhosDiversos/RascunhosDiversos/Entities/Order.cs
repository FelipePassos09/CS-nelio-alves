using System.Runtime.InteropServices.ObjectiveC;
using RascunhosDiversos.Entities.Enums;

namespace RascunhosDiversos.Entities;

public class Order
{
    public int Id { get; set; }

    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString()
    {
        return $"{Id}\n{Moment}\n{Status}";
    }
}