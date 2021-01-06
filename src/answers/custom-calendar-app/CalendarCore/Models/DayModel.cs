using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarCore.Models
{
  public class DayModel
  {
      public DateTime Date { get; set; }

      public int Year => Date.Year;
      public int Month => Date.Month;
      public int Day => Date.Day;

      public bool IsLastMonth { get; set; }
      public bool IsCurrentMonth { get; set; }
      public bool IsNextMonth { get; set; }
  }
}
