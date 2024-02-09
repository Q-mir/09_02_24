using System.ComponentModel.DataAnnotations;


namespace _09_02_24
{
    public class Match
    {
        [Key]
        [Required]
        public int Id {  get; set; }

        [Required]
        public string City {  get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Team1 { get; set; } = null!;
        
        [Required]
        [MaxLength(100)]
        public string Team2 {  get; set; } = null!;

        public string Score { get; set; } = null!;

    }
}
