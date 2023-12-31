﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(30, ErrorMessage = "Category Name must be about 30 characters")]
		[DisplayName("Category Name")]
		public string Name { get; set; }
		[Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
		[DisplayName("Display Order")]
		public int DisplayOrder { get; set; }
	}
}
