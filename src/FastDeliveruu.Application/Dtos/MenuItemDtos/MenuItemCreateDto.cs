using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace FastDeliveruu.Application.Dtos.MenuItemDtos;

public class MenuItemCreateDto
{
    [Required(ErrorMessage = "Vui lòng chọn cửa hàng.")]
    public Guid RestaurantId { get; set; }

    [Required(ErrorMessage = "Vui lòng chọn thể loại.")]
    public int GenreId { get; set; }

    [Required(ErrorMessage = "Vui lòng đặt tên cho món.")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Vui lòng nhập hàng tồn.")]
    public int Inventory { get; set; }

    [Required(ErrorMessage = "Vui lòng nhập giá.")]
    public decimal Price { get; set; }

    public decimal DiscountPercent { get; set; }

    public IFormFile? ImageFile { get; set; }
}