using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPayment.Models
{
    public class Payment
    {
        [Key]
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public int paymentId { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string cardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string cardNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string expirationDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
