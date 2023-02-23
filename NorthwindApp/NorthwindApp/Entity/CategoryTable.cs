using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindApp.Models;

namespace NorthwindApp.Entity;

[Table("tbl_category_new")]
public class CategoryTable
{
	[Key]
	[Column("category_id")]
	public int CategoryId { get; set; }

	[Column("category_code")]
	public string? CategoryCode { get; set; }
	
	[Column("category_name")]
	public string? CategoryName { get; set; }

	[Column("description")]
	public string? Description { get; set; }
}

