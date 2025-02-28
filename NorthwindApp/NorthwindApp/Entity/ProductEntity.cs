﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindApp.Entity;

[Table("tbl_product")]
public class ProductEntity
{
	[Key]
	[Column("product_id")]
	public int ProductId { get; set; }

	[Column("product_name")]
	public string? ProductName { get; set; }

	[Column("supplier_id")]
	public int SupplierId { get; set; }

	public SupplierEntity? Supplier { get; set; }

	[Column("category_id")]
	public int CategoryId { get; set; }

	public CategoryEntity? Category { get; set; }

	[Column("quantity_per_unit")]
	public int QuantityPerUnit { get; set; }

	[Column("unit_price")]
	public int UnitPrice { get; set; }

	[Column("units_in_stock")]
	public int UnitsInStock { get; set; }

	[Column("units_on_order")]
	public int UnitsOnOrder { get; set; }

	[Column("reorder_leve")]
	public int ReorderLevel { get; set; }

	[Column("discontinued")]
	public Boolean Discontinued { get; set; }
}

