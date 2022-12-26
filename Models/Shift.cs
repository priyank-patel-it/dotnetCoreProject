using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWSched_dotnet_mvc.Models
{
    public class Shift
    {
        public int ID { get; set; }

        public string Volunteer { get; set; }

        [Display(Name = "Shift Date")]
        [DataType(DataType.Date)]
        public DateTime ShiftDate { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public string Location { get; set; }
    }
}
