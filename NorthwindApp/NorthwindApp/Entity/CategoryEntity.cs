using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindApp.Models;

namespace NorthwindApp.Entity;

[Table("tbl_category")]
public class CategoryEntity
{
	[Key]
	[Column("category_id")]
	public int CategoryId { get; set; }

	[Column("category_name")]
	public string? CategoryName { get; set; }

	[Column("description")]
	public string? Description { get; set; }

	public ICollection<ProductEntity>? Products { get; set; }

	public CategoryEntity()
	{
	}

	public CategoryEntity(CategoryModel model)
	{
		CategoryId = model.CategoryId;
		CategoryName = model.CategoryName;
		Description = model.Description;
	}
}

