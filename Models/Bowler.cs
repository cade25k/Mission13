using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    // Bowler model
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        [Required]
        [MaxLength(50)]
        public string BowlerFirstName { get; set; }
        [MaxLength(1)]
        public string BowlerMiddleInit { get; set; }
        [Required]
        [MaxLength(50)]
        public string BowlerLastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string BowlerAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string BowlerCity { get; set; }
        [Required]
        [MaxLength(2)]
        public string BowlerState { get; set; }
        [Required]
        [MaxLength(10)]
        public string BowlerZip { get; set; }
        [Required]
        [MaxLength(14)]
        public string BowlerPhoneNumber { get; set; }
        [Required]
        public int TeamID { get; set; }
    }
}
