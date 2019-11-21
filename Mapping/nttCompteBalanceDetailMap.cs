using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSyscOhoda.Entities.Mappings
{
    public class nttCompteBalanceDetailMap : EntityTypeConfiguration<nttCompteBalanceDetail>
    {
        public nttCompteBalanceDetailMap()
        {
            // Primary Key
            this.HasKey(t =>  t.Id); 

            // Properties
            this.Property(t => t.NumCompte)
         .HasMaxLength(13);

            this.Property(t => t.IntitulCompte)
               .HasMaxLength(255);

        



            // Table & Column Mappings
            this.ToTable("nttCompteBalanceDetail");
            this.Property(t => t.nttCompteBalanceId).HasColumnName("nttCompteBalanceId")
            .IsRequired()
            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_nttCompteBalanceIdAndNumCompte", 1) { IsUnique = true }));
            ;
            this.Property(t => t.NumCompte).HasColumnName("NumCompte")
           .IsRequired()
            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_nttCompteBalanceIdAndNumCompte", 2) { IsUnique = true }));
            ;
            this.Property(t => t.IntitulCompte).HasColumnName("IntitulCompte");
            this.Property(t => t.SoldeDebit)
                .HasColumnName("SoldeDebit")
                .HasPrecision(18,0);
            this.Property(t => t.SoldeCredit)
           .HasColumnName("SoldeCredit")
           .HasPrecision(18, 0);

            // Relationships
            this.HasRequired(t => t.nttCompteBalances)
                .WithMany(t => t.nttCompteBalanceDetails)
                .HasForeignKey(d => d.nttCompteBalanceId)
                .WillCascadeOnDelete(true);

           
        }
    }
}