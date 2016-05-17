using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateMVCProject.Models
{
    public class PropertyModels
    {
        [Key]
        public int PropertyID { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }

       

        /*images, height, overlays, description, content
        * button to link to learn more
        * Title*/



    }
}