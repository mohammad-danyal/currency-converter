using Currency_Converter.Models;
using Microsoft.EntityFrameworkCore;

namespace currency_converter.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyModel>()
                .HasData(new CurrencyModel[] {
                new CurrencyModel{CurrencyId=1,CurrencyName="AUD", Multiplier=1.76},
                new CurrencyModel{CurrencyId=2,CurrencyName="EUR", Multiplier=1.17},
                new CurrencyModel{CurrencyId=3,CurrencyName="USD", Multiplier=1.20},
            });
        }
    }
}
