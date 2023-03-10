using System.Collections.Generic;
using System.Linq;

namespace Salon.Models
{
  public class Stylist
  {
    private readonly SalonContext _db;
    public int StylistId { get; set; }
    public string Name { get; set; }
    public List<Client> Clients { get; set; }

    public List<Stylist> FindByStylistName(string name)
    {
      List<Stylist> list = new List<Stylist> {};
      foreach (Stylist stylist in _db.Stylists.ToList())
      {
        if (stylist.Name == name) {
          list.Add(stylist);
        }
      }
      return list;
    }
  }
}