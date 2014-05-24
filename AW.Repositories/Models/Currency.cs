using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace AW.Repositories.Models
{
    public class Currency
    {
        [Key]
        public string CurrencyCode { get; set; }

        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Configuration properties for Currency class
        /// </summary>
        internal protected class Configuration : EntityTypeConfiguration<Currency>
        {
            public Configuration()
            {
                ToTable("Currency", "Sales");

                Property(p => p.CurrencyCode).HasMaxLength(3);

                Property(p => p.Name).IsRequired().HasMaxLength(50);
                Property(p => p.ModifiedDate).IsRequired();
            }
        }
    }
}