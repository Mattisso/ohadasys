using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class nttBalanceMap : EntityTypeConfiguration<nttBalance>
    {
        public nttBalanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // this.Property(t => t.Taux);


            //this.Property(t => t.Exercice)
            //    .IsFixedLength()
            //    .HasMaxLength(4);

            this.Property(t => t.IntitulCompte)
                .HasMaxLength(255);
            this.Property(t => t.NumCompte)
             .HasMaxLength(13);



            // Table & Column Mappings
            this.ToTable("nttBalance");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.oReferenceId).HasColumnName("oReferenceId");
            this.Property(t => t.oCompteId).HasColumnName("oCompteId");
            this.Property(t => t.oExercComptaId).HasColumnName("oExercComptaId");
            this.Property(t => t.oTableauPosteId).HasColumnName("oTableauPosteId");
            this.Property(t => t.NumCompte).HasColumnName("NumCompte");
            this.Property(t => t.IntitulCompte).HasColumnName("IntitulCompte");
            this.Property(t => t.SoldeDebit)
                .HasColumnName("SoldeDebit")
                .HasPrecision(18,0);
            this.Property(t => t.SoldeCredit)
                .HasColumnName("SoldeCredit")
                .HasPrecision(18, 0);

            // Relationships
            this.HasRequired(t => t.oReferences)
                .WithMany(t => t.nttBalances)
               .HasForeignKey(d => d.oReferenceId).WillCascadeOnDelete(false);

            this.HasRequired(t => t.oComptes)
               .WithMany(t => t.nttBalances)
              .HasForeignKey(d => d.oCompteId).WillCascadeOnDelete(false);

            this.HasRequired(t => t.oExercComptas)
               .WithMany(t => t.nttBalances)
              .HasForeignKey(d => d.oExercComptaId)
              .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oReferences)
               .WithMany(t => t.nttBalances)
              .HasForeignKey(d => d.oReferenceId)
              .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oTableauPostes)
              .WithMany(t => t.nttBalances)
             .HasForeignKey(d => d.oTableauPosteId)
             .WillCascadeOnDelete(false);
        }
    }
}
