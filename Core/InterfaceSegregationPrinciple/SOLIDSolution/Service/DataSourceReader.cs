using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.Domain;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.DataBase;

namespace Core.InterfaceSegregationPrinciple.SOLIDSolution
{
    public class DataSourceReader
    {
        public static ICollection<Record> ReadRecords(IDataSourceReader dataSource, ICollection<int> ids)
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
