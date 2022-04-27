using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required(ErrorMessage ="Field Required!")]
        [Column(TypeName ="nvarchar(12)")] //to specify type of data of column in BD
        [Display(Name="Account Number")]
        [MaxLength(12, ErrorMessage = "Maximun 12 Characters Only.")]
        public string AccountNumber { get; set; }
        [Required(ErrorMessage = "Field Required!")]
        [Display(Name="Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [Required(ErrorMessage = "Field Required!")]
        [Display(Name ="Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }
        [Required(ErrorMessage = "Field Required!")]
        [Display(Name ="Swift Code")]
        [Column(TypeName = "nvarchar(11)")]
        [MaxLength(11, ErrorMessage ="Maximun 11 Characters Only.")]
        public string SWIFTCODE { get; set; }
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:mm-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
