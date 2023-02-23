using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindApp.Entity;

[Table("tbl_order_detail")]
public class OrderDetailEntity
{
	[Key]
	[Column("id")]
	public int Id { get; set; }

	[Column("order_id")]
	public int OrderId { get; set; }
	
	public OrderEntity? Order { get; set; }

	[Column("product_id")]
	public int ProductId { get; set; }

	public ProductEntity? Product { get; set; }

	[Column("unit_price")]
	public int UnitPrice { get; set; }

	[Column("quantity")]
	public int Quantity { get; set; }

	[Column("discount")]
	public int Discount { get; set; }
}

