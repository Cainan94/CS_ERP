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
    
    public partial class CONDICAO_PAGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONDICAO_PAGAMENTO()
        {
            this.FATURAMENTO_VENDA = new HashSet<FATURAMENTO_VENDA>();
            this.FATURAMENTO_COMPRA = new HashSet<FATURAMENTO_COMPRA>();
        }
    
        public int ID { get; set; }
        public int NUMERO_PARCELAS { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public decimal JUROS { get; set; }
        public decimal DESCONTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FATURAMENTO_VENDA> FATURAMENTO_VENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FATURAMENTO_COMPRA> FATURAMENTO_COMPRA { get; set; }
    }
}
