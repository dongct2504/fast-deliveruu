namespace FastDeliveruu.Application.Dtos.OrderDtos;

public class OrderDto
{
    public Guid OrderId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public string DeliveryMethodShortName { get; set; } = null!;

    public string ShippingPrice { get; set; } = null!;

    public string? OrderStatus { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public string? TransactionId { get; set; }

    public string Address { get; set; } = null!;

    public string Ward { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;
}