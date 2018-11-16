using Lamb_Ji_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lamb_Ji_ViewModel
{
    public class LutteurViewModel
    {

        public int LutteurID { get; set; }
        public string LutteurName { get; set; }
        public string LutteurEmail { get; set; }
        public int LutteurPoids { get; set; }
        public System.DateTime LutteurDateNaissance { get; set; }
        public string LutteurAddresse { get; set; }
        public string LutteurDescription { get; set; }
        public string LutteurTelephone { get; set; }
        public string imageUrl { get; set; }

        public Nullable<int> LutteurClubID { get; set; }
        public string ClubName { get; set; }



        public HttpPostedFileBase ImageUpload { get; set; }


     
       


    }
}
