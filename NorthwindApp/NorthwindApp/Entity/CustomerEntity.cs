using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindApp.Entity;

[Table("tbl_customer")]
public class CustomerEntity
{
	[Key]
	[Column("customer_id")]
	public int SupplierId { get; set; }

	[Column("company_name")]
	public string? CompanyName { get; set; }

	[Column("contact_name")]
	public string? ContactName { get; set; }

	[Column("contact_title")]
	public string? ContactTitle { get; set; }

	[Column("address")]
	public string? Address { get; set; }

	[Column("city")]
	public string? City { get; set; }

	[Column("region")]
	public string? Region { get; set; }

	[Column("postal_code")]
	public string? PostalCode { get; set; }

	[Column("country")]
	public string? Country { get; set; }

	[Column("phone")]
	public string? Phone { get; set; }

	[Column("fax")]
	public string? Fax { get; set; }
}

