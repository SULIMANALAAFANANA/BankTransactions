using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Transactions.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [DisplayName("TransactionId")]
        public int TransactionId { get; set; }
        [DisplayName("AccountNumber")]
        public string AccountNumber { get; set; }
        [DisplayName("BeneficiaryName")]
        public string BeneficiaryName { get; set; }
        [DisplayName("BankName")]
        public string BankName { get; set; }
        [DisplayName("SWIFTCode ")]
        public string SWIFTCode { get; set; }
        public int Amount{ get; set; }
        public DateTime Data { get; set; }
    }
}
