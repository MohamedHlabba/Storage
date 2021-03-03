using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(20,ErrorMessage ="Lenght cannot be more than 20 characters")]
        public string Name { get; set; }
        [Required]
        public string Category{ get; set; }
        public string Shelf { get; set; }
        public string Description { get; set; }
        [Range(5000,35000)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public  DateTime Orderdate { get; set; }
        public int Count { get; set; }







    }
}
