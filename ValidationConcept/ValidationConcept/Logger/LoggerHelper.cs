using System.Collections.Generic;
using ValidationConcept.Interfaces;

namespace ValidationConcept.Logger
{
    public class LoggerHelper
    {

        public static IEnumerable<LoggerItem> CreateLoggerItems(IEnumerable<IValidationResult> results)
        {

            var loggerItems = new List<LoggerItem>();

            foreach (var result in results)
            {
                LoggerItem loggerItem = new LoggerItem();
                result.UpdateLoggerItem(loggerItem);
                loggerItems.Add(loggerItem);
            }

            return loggerItems;

        }

    }
}
