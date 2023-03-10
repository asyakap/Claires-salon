using System.Text.RegularExpressions;
using System;

namespace Salon.Models
{
  public class Appointment
  {
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public string Notes { get; set; }
  }

  public class Validation
  {
    public static int CheckDateFormat(string date)
    {
      if (Regex.IsMatch(date, @"((0[1-9]|1[0-2])\/((0|1)[0-9]|2[0-9]|3[0-1])\/((202)\d))$"))
      {
        return 1;
      }
      else
      {
        return 2;
      }
    }
  }
}