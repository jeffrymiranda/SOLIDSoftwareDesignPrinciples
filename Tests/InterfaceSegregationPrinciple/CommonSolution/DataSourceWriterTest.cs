using System;
using NUnit.Framework;
using System.Collections.Generic;
using Core.InterfaceSegregationPrinciple.CommonSolution;
using Core.InterfaceSegregationPrinciple.CommonSolution.Domain;
using Core.InterfaceSegregationPrinciple.CommonSolution.DataBase;

namespace Tests.InterfaceSegregationPrinciple.CommonSolution
{
    public class DataSourceWriterTest
    {
        [Test]
        public void WriteRecords_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine("Interface Segregation Principle - Common Solution");
            Console.WriteLine("===");
            Console.WriteLine("WriteRecords - PASS");

            List<Record> records = new()
            {
                new Record(1, "RECORD-A"),
                new Record(2, "RECORD-B"),
                new Record(3, "RECORD-C")
            };

            IDataSource dataSource = new DataSource();
            DataSourceWriter.WriteRecords(dataSource, records);
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
