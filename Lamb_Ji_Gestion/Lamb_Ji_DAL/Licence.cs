//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lamb_Ji_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Licence
    {
        public int LicenceID { get; set; }
        public int LutteurID { get; set; }
        public int TypeLutteID { get; set; }
        public System.DateTime LicenceDate_Debut { get; set; }
        public System.DateTime LicenceDate_Fin { get; set; }
    
        public virtual Lutteur Lutteur { get; set; }
        public virtual TypeLutte TypeLutte { get; set; }
    }
}