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
    public class nttCompteBalanceMap : EntityTypeConfiguration<nttCompteBalance>
    {
        public nttCompteBalanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id); // new { t.nReferenceId, t.oExerciceId});

            // Properties

            //this.Property(t => t.Exercice)
            //    .IsFixedLength()
            //    .HasMaxLength(4);



            // Table & Column Mappings
            this.ToTable("nttCompteBalance");
            this.Property(t => t.oReferenceId)
                .HasColumnName("oReferenceId")
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_oReferenceIdAndoExercComptaId", 1) { IsUnique = true }));
            this.Property(t => t.oExercComptaId).HasColumnName("oExercComptaId")
            .IsRequired()
            .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_oReferenceIdAndoExercComptaId", 2) { IsUnique = true }));
            ;
            this.Property(t => t.oTableauPosteId).HasColumnName("oTableauPosteId");
            this.Property(t => t.TotalSoldeDebit)
                .HasColumnName("TotalSoldeDebit")
                .HasPrecision(18, 0);
            this.Property(t => t.TotalSoldeCredit)
           .HasColumnName("TotalSoldeCredit")
           .HasPrecision(18, 0);

            // Relationships
            this.HasRequired(t => t.oReferences)
                .WithMany(t => t.nttCompteBalances)
                .HasForeignKey(t => t.oReferenceId)
                .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oExercComptas)
             .WithMany(t => t.nttCompteBalances)
             .HasForeignKey(t => t.oExercComptaId)
             .WillCascadeOnDelete(false);

            this.HasRequired(t => t.oTableauPostes)
             .WithMany(t => t.nttCompteBalances)
             .HasForeignKey(t => t.oTableauPosteId)
             .WillCascadeOnDelete(false);
        }
    }
}