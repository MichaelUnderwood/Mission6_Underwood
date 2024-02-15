using System.ComponentModel.DataAnnotations;

namespace Mission6_Underwood.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int EntryID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }


    }
}
