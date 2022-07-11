using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Currency_Converter.Models
{
    public class CurrencyModel
    {
        /// <summary>
        /// Gets or sets CurrencyId.
        /// </summary>
        [Required]
        [Key]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Gets or sets Multiplier.
        /// </summary>
   
        public string CurrencyName { get; set; }

        /// <summary>
        /// Gets or sets Multiplier.
        /// </summary>
   
        public double Multiplier { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        /// 
        [Required]
        [NotMapped]
        public double Amount { get; set; }
    }
}