using System;
using System.Collections.Generic;
using Core.InterfaceSegregationPrinciple.SOLIDSolution;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.DataBase;
using NUnit.Framework;

namespace Tests.InterfaceSegregationPrinciple.SOLIDSolution
{
    public class DataSourceReaderTest
    {
        [Test]
        public void ReadRecords_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Interface Segregation Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine("ReadRecords - PASS");

            List<int> ids = new() { 1, 2, 3 };

            IDataSourceReader dataSource = new DataSource();
            DataSourceReader.ReadRecords(dataSource, ids);

            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
