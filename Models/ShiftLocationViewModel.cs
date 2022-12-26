using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PWSched_dotnet_mvc.Models
{
    public class ShiftLocationViewModel
    {
        public List<Shift> Shifts { get; set; }
        public SelectList Locations { get; set; }
        public string ShiftLocation { get; set; }
        public string SearchString { get; set; }
    }
}