using Currency_Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class AuditService : IAuditService
    {
        private readonly AuditContext _auditContext;

        public AuditService(AuditContext context)
        { 
            _auditContext = context;
        }
        
        public List<AuditModel> GetAudit(AuditModel audit)
        {
            DateTime dateTime = Convert.ToDateTime(audit.ConversionDate);

            var startDate = dateTime.Date;
            var endDate = startDate.AddDays(1);

            var data = _auditContext.Audit
                       .Where(s => s.ConversionDateTime >= startDate).Where(s => s.ConversionDateTime <= endDate).Select(s =>
                       new AuditModel{ 
                           ConversionId = s.ConversionId, 
                           GBPValue = s.GBPValue, 
                           ConvertedValue = s.ConvertedValue, 
                           CurrencyConvertedTo = s.CurrencyConvertedTo }).ToList();

            return data;
        }
    }
}