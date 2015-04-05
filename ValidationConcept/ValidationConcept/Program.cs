using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationConcept.Interfaces;
using ValidationConcept.Logger;

namespace ValidationConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<LoggerItem> loggerItems = new List<LoggerItem>();

            var validatorInfoA = new ValidatorInfo(){Name="ValidatorA", TableName = "TableA", Field = "FieldA"};
            var validatorA = new ValidatorA(validatorInfoA);
            var validatorAResults = validatorA.Validate();
            loggerItems.AddRange(LoggerHelper.CreateLoggerItems(validatorAResults));

            ValidatorInfo validatorInfoB = new ValidatorInfo(){Name="ValidatorB", TableName = "TableB", Field = "FieldB"};
            var validatorB = new ValidatorB(validatorInfoB);
            var validatorBResults = validatorB.Validate();
            loggerItems.AddRange(LoggerHelper.CreateLoggerItems(validatorBResults));

            Print(loggerItems);

            Console.ReadLine();
        }

        public static void Print(IEnumerable<LoggerItem> loggerItems)
        {
            foreach (var item in loggerItems)
            {
                item.Print();
            }
        }
    }
}
