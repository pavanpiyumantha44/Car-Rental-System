using System.ComponentModel.DataAnnotations;

namespace CRS.Models
{
    public class Driver
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name ="Name")]
        [StringLength(128)]
        public string? Name { get; set; }

        [Display(Name="Address")]
        [StringLength(256)]
        public string? Address { get; set; }

        [Display(Name ="NIC")]
        [Required]
        [StringLength(12)]
        public string NIC {  get; set; }

        [Display (Name ="Date of Birth")]
        public DateTime? Dob {  get; set; }

        [Display (Name ="Email")]
        [StringLength(128)]
        public string? Email { get; set;}

        [Display(Name = "Phone")]
        [StringLength(20)]
        public string? Phone { get; set; }

        [Display (Name ="Created date time")]
        public DateTime? CreatedDttm { get; set; }

        [Display (Name ="Modified date time")]
        public DateTime? ModifiedDttm { get; set; }

    }
}
