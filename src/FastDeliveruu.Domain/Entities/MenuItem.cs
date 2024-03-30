﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FastDeliveruu.Domain.Entities;

[Index("GenreId", Name = "MENUITEMGENRES_FK")]
[Index("RestaurantId", Name = "MENUITEMRESTAURANTS_FK")]
public partial class MenuItem
{
    [Key]
    public int MenuItemId { get; set; }

    public int? RestaurantId { get; set; }

    public int? GenreId { get; set; }

    public string Description { get; set; } = null!;

    public int Inventory { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal DiscountPercent { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }

    [ForeignKey("GenreId")]
    [InverseProperty("MenuItems")]
    public virtual Genre? Genre { get; set; }

    [InverseProperty("MenuItem")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("RestaurantId")]
    [InverseProperty("MenuItems")]
    public virtual Restaurant? Restaurant { get; set; }

    [InverseProperty("MenuItem")]
    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}