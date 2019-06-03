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
    
    public partial class ORCAMENTO_VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORCAMENTO_VENDA()
        {
            this.PRODUTO_ORCAMENTOVENDA = new HashSet<PRODUTO_ORCAMENTOVENDA>();
            this.VENDA = new HashSet<VENDA>();
        }
    
        public long ID { get; set; }
        public int USUARIO_ID { get; set; }
        public long CLIENTES_ID { get; set; }
        public System.DateTime DATA_ORCAMENTO { get; set; }
        public System.TimeSpan HORA { get; set; }
        public int QUANTIDADE_TOTAL { get; set; }
        public decimal SUB_TOTAL { get; set; }
        public decimal DESCONTO_REAIS { get; set; }
        public decimal DESCONTO_PORCENTO { get; set; }
        public decimal ACRESCIMO_REAIS { get; set; }
        public decimal ACRESCIMO_PORCENTO { get; set; }
        public decimal TOTAL { get; set; }
    
        public virtual CLIENTES CLIENTES { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_ORCAMENTOVENDA> PRODUTO_ORCAMENTOVENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
