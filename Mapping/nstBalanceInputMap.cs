using System.Data.Entity.ModelConfiguration;

namespace AccSyscOhoda.Entities.Mappings
{
    public class nstBalanceInputMap:  EntityTypeConfiguration<nstBalanceInput>
    {
        public nstBalanceInputMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            this.Property(t => t.IntitulCompte)
                .HasMaxLength(255);
            this.Property(t => t.NumCompte)
             .HasMaxLength(13);


            // Table & Column Mappings
            this.ToTable("nstBalanceInput");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NumCompte).HasColumnName("NumCompte");
            this.Property(t => t.IntitulCompte).HasColumnName("IntitulCompte");
            this.Property(t => t.SoldeDebit).HasColumnName("SoldeDebit")
                .HasPrecision(18, 0);
            this.Property(t => t.SoldeCredit).HasColumnName("SoldeCredit")
                .HasPrecision(18, 0);
        }


    }
}
