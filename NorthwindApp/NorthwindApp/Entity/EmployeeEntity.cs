using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindApp.Entity;

[Table("tbl_employee")]
public class EmployeeEntity
{
	[Key]
	[Column("employee_id")]
	public int EmployeeId { get; set; }

	[Column("first_name")]
	public string? FirstName { get; set; }

	[Column("last_name")]
	public string? LastName { get; set; }

	[Column("title")]
	public string? Title { get; set; }

	[Column("title_of_courtesy")]
	public string? TitleOfCourtesy { get; set; }

	[Column("birth_date")]
	public DateTime BirthDate { get; set; }

	[Column("hire_date")]
	public DateTime HireDate { get; set; }

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

	[Column("home_phone")]
	public string? HomePhone { get; set; }

	[Column("extension")]
	public string? Extension { get; set; }

	[Column("notes")]
	public string? Notes { get; set; }

	[Column("report_to")]
	public int ReportTo { get; set; }

	public ICollection<OrderEntity>? Orders { get; set; }
}

