using Currency_Converter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Currency_Converter
{
    public interface IAuditService
    {
        List<AuditModel> GetAudit(AuditModel audit);
    }
}