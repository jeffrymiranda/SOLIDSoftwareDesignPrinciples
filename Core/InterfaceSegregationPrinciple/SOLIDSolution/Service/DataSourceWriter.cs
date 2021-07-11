using System.Collections.Generic;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.Domain;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.DataBase;

namespace Core.InterfaceSegregationPrinciple.SOLIDSolution
{
    public class DataSourceWriter
    {
        public static void WriteRecords(IDataSourceWriter dataSource, ICollection<Record> records)
        {
            foreach (var record in records)
            {
                dataSource.WriteRecord(record);
            }
        }
    }
}
