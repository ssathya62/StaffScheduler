using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.Application
{
	public class Patient
	{
		public string Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		public string ParentName { get; set; }
		[EmailAddress]
		public string EmailAddress { get; set; }
		[Required]
		public Gender Sex { get; set; }
		[Required]
		public DateTime DateOfBirth { get; set; }
		[Phone]
		public string Phone { get; set; }		
		public string Address { get; set; }
		public string Cities { get; set; }
		[DataType(DataType.PostalCode)]
		public string Zip { get; set; }
		public List<AvailablityCalendar> Availablity { get; set; }
		public bool AggressiveBehavior { get; set; }
		public VerbalBehavior Verbal { get; set; }
		public Gender TherapistGender { get; set; }
		public ServiceEnvironment Environment { get; set; }
		public DateTime? WaitListDate { get; set; }
		public string Notes { get; set; }
	}
}
