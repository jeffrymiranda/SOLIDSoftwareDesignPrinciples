namespace Core.InterfaceSegregationPrinciple.CommonSolution.Domain
{
    public class Record
    {
        #region Constructor

        public Record(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion

        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }

        #endregion
    }
}
