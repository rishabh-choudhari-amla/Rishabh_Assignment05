using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Model.Models
{
    public class ReportDetails
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double Science { get; set; }
        [Required]
        public double Maths { get; set; }
        [Required]
        public double EVS { get; set; }
        [Required]
        public double History { get; set; }
        [Required]
        public double English { get; set; }
        [Required]
        public double Hindi { get; set; }
        [Required]
        public double Percentage { get; set; }
        public string Result { get; set; }
        [Required]
        public string Remark { get; set; }
    }
}
