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
    
    public partial class SAIDA_CAIXA
    {
        public long ID { get; set; }
        public int CAIXA_ID { get; set; }
        public System.DateTime DATA_SAIDA { get; set; }
        public System.TimeSpan HORA { get; set; }
        public decimal VALOR { get; set; }
        public string NUMERO_DOCUMENTO { get; set; }
    
        public virtual CAIXA CAIXA { get; set; }
    }
}
