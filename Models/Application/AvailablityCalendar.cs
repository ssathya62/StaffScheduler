using System;

namespace Models.Application
{
	public class AvailablityCalendar
	{
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public DayOfWeek ServiceDay { get; set; }
	}
}
