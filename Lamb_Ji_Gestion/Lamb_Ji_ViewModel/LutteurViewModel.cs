using Lamb_Ji_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lamb_Ji_ViewModel
{
    public class LutteurViewModel
    {

        public int LutteurID { get; set; }
        [Required(ErrorMessage ="Ce champ est requis!")]
        public string LutteurName { get; set; }
        public string LutteurEmail { get; set; }
        public int LutteurPoids { get; set; }
        [Required(ErrorMessage ="La date est requise!..")]
        [Display(Name = "Date de Naissance")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public System.DateTime LutteurDateNaissance { get; set; }
        public string LutteurAddresse { get; set; }
        
        [StringLength(1000)]
        public string LutteurDescription { get; set; }
        public string LutteurTelephone { get; set; }
        public string imageUrl { get; set; }

        public int? LutteurClubID { get; set; }
        public string ClubName { get; set; }

        public HttpPostedFileBase ImageUpload { get; set; }

        public virtual Club Club { get; set; }







    }
}
