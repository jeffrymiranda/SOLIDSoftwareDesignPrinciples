using Core.InterfaceSegregationPrinciple.CommonSolution.Domain;
namespace Core.InterfaceSegregationPrinciple.CommonSolution.DataBase
{
    public interface IDataSource
    {
        #region Methods

        Record ReadRecord(int Id);

        void WriteRecord(Record record);

        #endregion
    }
}
