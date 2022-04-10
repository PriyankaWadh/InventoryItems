using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventoryItems.Models
{
    public class InventoryItemModel
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Weight { get; set; }
        [DisplayFormat(DataFormatString = "dd-MM-yyyy", ApplyFormatInEditMode = true)]
        [Display(Name="MFG Date")]
        [DataType(DataType.Date)]
        public DateTime MFGDate { get; set; }
    }
}