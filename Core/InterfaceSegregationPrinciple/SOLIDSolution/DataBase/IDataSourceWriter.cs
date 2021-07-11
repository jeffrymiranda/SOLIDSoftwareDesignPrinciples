using Core.InterfaceSegregationPrinciple.SOLIDSolution.Domain;

namespace Core.InterfaceSegregationPrinciple.SOLIDSolution.DataBase
{
    public interface IDataSourceWriter
    {
        #region Methods

        void WriteRecord(Record record);

        #endregion
    }
}
