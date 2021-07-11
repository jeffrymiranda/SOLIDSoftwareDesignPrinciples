using Core.InterfaceSegregationPrinciple.SOLIDSolution.Domain;

namespace Core.InterfaceSegregationPrinciple.SOLIDSolution.DataBase
{
    public interface IDataSourceReader
    {
        #region Methods

        Record ReadRecord(int Id);

        #endregion
    }
}
