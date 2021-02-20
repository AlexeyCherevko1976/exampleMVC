using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using exampleMVC.Models;

namespace exampleMVC.Models
{
    public class Nomenclature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        Product pr1=new Product {Id=1, Name="pipe"};
    }
}
