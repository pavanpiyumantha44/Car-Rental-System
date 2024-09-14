using System.ComponentModel.DataAnnotations;

namespace CRS.Models
{
    public class Car
    {
        [Key]
        [Display (Name ="Car ID")]
        public int Id { get; set; }

        [Display (Name ="Make")]
        [StringLength(50)]
        public string? Make { get; set; }

        [Display (Name ="Model")]
        [StringLength(50)]
        public string? Model { get; set; }

        [Display(Name = "Year")]
        public int? Year { get; set; }

        [Display(Name = "License Plate")]
        [StringLength(10)]
        public string? LicensePlate { get; set; }

        [Display(Name = "VIN")]
        [StringLength(20)]
        public string? VIN { get; set; }

        [Display(Name = "Fuel Type")]
        [StringLength(20)]
        public string? FuelType { get; set; }

        [Display(Name = "Transmission Type")]
        [StringLength(20)]
        public string? TransmissionType { get; set; }

        [Display(Name = "Seats")]
        public int? Seats { get; set; }

        [Display(Name = "Color")]
        [StringLength(20)]
        public string? Color { get; set; }

        [Display(Name = "Rental Price Per Day")]
        public decimal? RentalPricePerDay { get; set; }

        [Display(Name = "Available")]
        public bool? isAvailable { get; set; }

        [Display(Name = "Milage")]
        public int? Milage { get; set; }

        [Display(Name = "Category")]
        [StringLength(30)]
        public string? Category { get; set; }

        [Display(Name = "Created date time")]
        public DateTime? CreatedDttm { get; set; }

        [Display(Name = "Modified date time")]
        public DateTime? ModifiedDttm { get; set; }
    }
}
