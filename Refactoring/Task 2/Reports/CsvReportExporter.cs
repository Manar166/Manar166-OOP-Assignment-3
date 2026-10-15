using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Reports
{
    public class CsvReportExporter : ReportExporterBase
    {
        
       

        protected override string Format(List<string[]> rows)
        {
           return string.Join(Environment.NewLine, rows.Select(r => string.Join(",", r)));
        }
    }
}
