using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.InterfaceSegregationPrinciple.CommonSolution.Domain;

namespace Core.InterfaceSegregationPrinciple.CommonSolution.DataBase
{
    public class DataSource : IDataSource
    {
        #region Fields

        private readonly ICollection<Record> recordCollection = new Collection<Record>();

        #endregion

        #region IDataSource Members

        public Record ReadRecord(int Id) => recordCollection.FirstOrDefault(x => x.Id == Id);

        public void WriteRecord(Record record)
        {
            recordCollection.Add(record);
        }

        #endregion
    }
}
