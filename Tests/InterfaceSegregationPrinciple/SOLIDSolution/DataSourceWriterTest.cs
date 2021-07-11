using System;
using NUnit.Framework;
using System.Collections.Generic;
using Core.InterfaceSegregationPrinciple.SOLIDSolution;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.Domain;
using Core.InterfaceSegregationPrinciple.SOLIDSolution.DataBase;

namespace Tests.InterfaceSegregationPrinciple.SOLIDSolution
{
    public class DataSourceWriterTest
    {
        [Test]
        public void WriteRecords_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Interface Segregation Principle - SOLID Solution");
            Console.WriteLine("===");
            Console.WriteLine("WriteRecords - PASS");

            List<Record> records = new()
            {
                new Record(1, "RECORD-A"),
                new Record(2, "RECORD-B"),
                new Record(3, "RECORD-C")
            };

            IDataSourceWriter dataSource = new DataSource();
            DataSourceWriter.WriteRecords(dataSource, records);
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
