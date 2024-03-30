﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FastDeliveruu.Domain.Entities;

[Index("MenuItemId", Name = "ORDERDETAILMENUITEMS_FK")]
[Index("OrderId", Name = "ORDERDETAILORDERS_FK")]
public partial class OrderDetail
{
    [Key]
    public int OrderDetailId { get; set; }

    public int? MenuItemId { get; set; }

    public int? OrderId { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }

    [ForeignKey("MenuItemId")]
    [InverseProperty("OrderDetails")]
    public virtual MenuItem? MenuItem { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderDetails")]
    public virtual Order? Order { get; set; }
}