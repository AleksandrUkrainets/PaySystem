using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaySystem.Models
{
    public class BalanceModels
    {
        public int PayerUserBalance { get; set; }
        public int PayerBalanceNumber { get; set; }
        public int ReceiverUserBalance { get; set; }
        public int ReceiverBalanceNumber { get; set; }
        public int ReceiverValue { get; set; }
    }
}