using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBank.Models
{
    public class Account
    {
        [Key]
        public int accountno { get; set; }
        public string accountholder { get; set; }
        public string accounttype { get; set; }
        public int amount { get; set; }
    }
}
