using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Currency_Converter.Models
{
    public class AuditModel
    {
        /// <summary>
        /// Gets or sets ConversionId.
        /// </summary>
        
        [Required]
        [Key]
        public int ConversionId { get; set; }

        /// <summary>
        /// Gets or sets GBP.
        /// </summary>
        [Required]
        public double GBPValue { get; set; }

        // <summary>
        /// Gets or sets Conversion.
        /// </summary>
        [Required]
        public double ConvertedValue { get; set; } = 1;

        /// <summary>
        /// Gets or sets GBP.
        /// </summary>
        public string CurrencyConvertedTo { get; set; }

        /// <summary>
        /// Gets or sets ConversionDate.
        /// </summary>
        public DateTime ConversionDateTime { get; set; }

        [Required]
        [RegularExpression(@"^^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$", ErrorMessage = "Invalid Data: Use DD/MM/YYYY for your date format")]
        [NotMapped]
        public string ConversionDate { get; set; } = "11/07/2022";
    }
}