//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MODELO
    {
        public int ID { get; set; }
        public int MARCA_ID { get; set; }
        public int NOME { get; set; }
        public int DESCRICAO { get; set; }
    
        public virtual MARCA MARCA { get; set; }
    }
}
