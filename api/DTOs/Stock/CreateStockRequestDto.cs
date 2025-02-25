using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Stock
{
    public class CreateStockRequestDto
    {        
        [Required]
        [MaxLength(10, ErrorMessage ="Symbol cannot be over 10 characters")]
        public string? Symbol { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage ="Company Name cannot be over 10 characters")]
        public string? CompanyName { get; set; }
        [Required]
        [Range(1,1000000000000, ErrorMessage = "Purchase price cannot be over 1 trillion")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,100)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage ="Industry cannot be over 10 characters")]
        public string? Industry { get; set; }
        [Required]
        [Range(1,5000000000000, ErrorMessage = "Market Cap price cannot be over 5 trillion")]
        public long MarketCap { get; set; }
    }
}