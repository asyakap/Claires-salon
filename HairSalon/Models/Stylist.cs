using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public List<Client> Clients { get; set; }
    public List<Appointment> Appointments { get; set; }
  }
}