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
    
    public partial class ESPECIEPAGAMENTO_FATURAMENTOVENDA
    {
        public int ESPECIE_PAGAMENTO_ID { get; set; }
        public int FATURAMENTO_VENDA_ID { get; set; }
        public decimal VALOR { get; set; }
    
        public virtual ESPECIE_PAGAMENTO ESPECIE_PAGAMENTO { get; set; }
        public virtual FATURAMENTO_VENDA FATURAMENTO_VENDA { get; set; }
    }
}
