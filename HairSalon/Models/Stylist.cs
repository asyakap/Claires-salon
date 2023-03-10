using System.Collections.Generic;
using System.Linq;

namespace Salon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public List<Client> Clients { get; set; }
  }
}