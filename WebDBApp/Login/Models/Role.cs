using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebDBApp.Models
{
    public class Role
    {

        [Required, Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }
    }
}