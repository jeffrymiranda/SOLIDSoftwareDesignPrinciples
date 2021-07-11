using System;
using System.Collections.Generic;
using Core.InterfaceSegregationPrinciple.CommonSolution;
using Core.InterfaceSegregationPrinciple.CommonSolution.DataBase;
using NUnit.Framework;

namespace Tests.InterfaceSegregationPrinciple.CommonSolution
{
    public class DataSourceReaderTest
    {
        [Test]
        public void ReadRecords_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Interface Segregation Principle - Common Solution");
            Console.WriteLine("===");
            Console.WriteLine("ReadRecords - PASS");

            List<int> ids = new() { 1, 2, 3 };

            IDataSource dataSource = new DataSource();
            DataSourceReader.ReadRecords(dataSource, ids);

            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
