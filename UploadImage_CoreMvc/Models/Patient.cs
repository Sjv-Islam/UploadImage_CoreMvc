using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UploadImage_CoreMvc.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
        [DataType(DataType.Currency)]
        public decimal Honorary { get; set; }

        [DataType(DataType.ImageUrl)]
        public string? ImageUrl {  get; set; }
        [NotMapped]
        public IFormFile? Picture { get; set; }
    }


    public class PatientDb : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public PatientDb(DbContextOptions opt): base(opt)
        {
            
        }
    }
}
