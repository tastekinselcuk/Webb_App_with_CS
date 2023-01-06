using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebProgramlama.Models.NewFolder
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }
        public List<Car> Cars { get; set; }


    }
}
