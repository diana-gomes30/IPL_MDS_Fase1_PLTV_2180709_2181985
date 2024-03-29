//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Filhos : Pessoas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filhos()
        {
            this.Inscricoes = new HashSet<Inscricoes>();
        }
    
        public string Sexo { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public int IdProgenitor { get; set; }
        public int IdEscola { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricoes> Inscricoes { get; set; }
        public virtual Escolas Escolas { get; set; }

        public override string ToString()
        {
            return Nome + " (" + Idade() + " Anos)";
        }
        // Para calcular a idade        
        public int Idade()
        {
            int idade;
            idade = DateTime.Today.Year - DataNascimento.Year;
            if (DataNascimento.Month > DateTime.Today.Month || DataNascimento.Month == DateTime.Today.Month && DataNascimento.Day > DateTime.Today.Day)
            {
                idade--;
            }
            return idade;
        } 
    }
}
