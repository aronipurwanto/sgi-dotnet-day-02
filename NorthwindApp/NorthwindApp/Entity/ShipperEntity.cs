using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindApp.Entity;

namespace NorthwindApp.Entity;

[Table("tbl_shipper")]
public class ShipperEntity
{
	[Key]
	[Column("shipper_id")]
	public int ShipperId { get; set; }

	[Column("company_name")]
	public string? CompanyName { get; set; }

	[Column("phone")]
	public string? Phone { get; set; }

	public ICollection<OrderEntity>? Orders { get; set; }
}

