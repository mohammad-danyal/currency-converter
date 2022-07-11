using Currency_Converter.Models;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public interface ICurrencyConverter
    {
        Task<double> ConvertCurrencyAsync(CurrencyModel currency, AuditModel audit);

        Task<AuditModel> UpdateAuditAsync(double conversion, AuditModel newAudit);
    }
}