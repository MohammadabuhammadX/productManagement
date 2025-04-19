using productManagement.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productManagement.Dtos
{
    public class CreateUpdateProductDto
    {
        public Guid CategoryId { get; set; }
        [Required]
        [StringLength(ProductConsts.MaxNameLength)]
        public string Name { get; set; }
        public float Price { get; set; }
        public bool IsFreeCargo { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ProductStockState StockState { get; set; }
    }
}
