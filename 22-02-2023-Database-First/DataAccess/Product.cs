using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_02_2023_Database_First.DataAccess
{
  //Entity
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}
