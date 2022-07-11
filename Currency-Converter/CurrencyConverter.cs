using Currency_Converter.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class CurrencyConverter : ICurrencyConverter
    {
        private readonly AuditContext _auditContext;

        public CurrencyConverter (AuditContext context)
        { 
            _auditContext = context;
        }
        
        public async Task<double> ConvertCurrencyAsync(CurrencyModel currency, AuditModel audit)
        {

            var data = _auditContext.Currency
                       .Where(s => s.CurrencyId == currency.CurrencyId).Select(s => new { s.Multiplier, s.CurrencyName});

            var conversion = currency.Amount * data.Select(s => s.Multiplier).FirstOrDefault();

            if(currency.Amount > 0)
            {
                audit.GBPValue = currency.Amount;
                audit.ConvertedValue = conversion;
                audit.CurrencyConvertedTo = data.Select(s => s.CurrencyName).FirstOrDefault();
                audit.ConversionDateTime = DateTime.Now;
            }

            await UpdateAuditAsync(conversion, audit);


            return conversion;
        }

        public async Task<AuditModel> UpdateAuditAsync(double conversion, AuditModel newAudit)
        {
            _auditContext.Update(newAudit);
            await _auditContext.SaveChangesAsync();
            return newAudit;
        }
    }
}