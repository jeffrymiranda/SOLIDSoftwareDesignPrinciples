using System.Collections.Generic;
using Core.InterfaceSegregationPrinciple.CommonSolution.Domain;
using Core.InterfaceSegregationPrinciple.CommonSolution.DataBase;

namespace Core.InterfaceSegregationPrinciple.CommonSolution
{
    public class DataSourceWriter
    {
        public static void WriteRecords(IDataSource dataSource, ICollection<Record> records)
        {
            foreach (var record in records)
            {
                dataSource.WriteRecord(record);
            }
        }
    }
}
