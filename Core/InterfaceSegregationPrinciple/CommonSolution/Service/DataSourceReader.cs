using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.InterfaceSegregationPrinciple.CommonSolution.Domain;
using Core.InterfaceSegregationPrinciple.CommonSolution.DataBase;

namespace Core.InterfaceSegregationPrinciple.CommonSolution
{
    public class DataSourceReader
    {
        public static ICollection<Record> ReadRecords(IDataSource dataSource, ICollection<int> ids)
        {
            var result = new Collection<Record>();
            foreach (var id in ids)
            {
                result.Add(dataSource.ReadRecord(id));
            }
            return result;
        }
    }
}
