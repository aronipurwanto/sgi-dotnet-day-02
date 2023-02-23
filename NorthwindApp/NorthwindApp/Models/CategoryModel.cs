using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindApp.Entity;
using NorthwindApp.Pages;

namespace NorthwindApp.Models;

public class CategoryModel
{
	[Key]
	[Display(Name = "Category Id")]
	public int CategoryId { get; set; }

	[Required]
	[MinLength(3,ErrorMessage = "Minimal 3")]
	[Display(Name = "Category Name")]
	public string? CategoryName { get; set; }

	[Required]
	[Display(Name ="Description")]
	public string? Description { get; set; }

	public CategoryModel()
	{
		
	}

	public CategoryModel(CategoryEntity entity)
	{
		CategoryId = entity.CategoryId;
		CategoryName = entity.CategoryName;
		Description = entity.Description;
	}
	
	public CategoryModel(CategoryTable entity)
	{
		CategoryId = entity.CategoryId;
		CategoryName = entity.CategoryName;
		Description = entity.Description;
	}
}

