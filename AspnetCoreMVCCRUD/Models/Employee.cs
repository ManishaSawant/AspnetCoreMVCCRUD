using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace AspnetCoreMVCCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "varchar(250)")]

        [DisplayName("Full Name")]
        public string FullName { get; set; }
       
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmepCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Position")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

    }
}
