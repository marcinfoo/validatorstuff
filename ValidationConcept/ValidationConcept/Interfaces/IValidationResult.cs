using ValidationConcept.Logger;

namespace ValidationConcept.Interfaces
{
    public interface IValidationResult
    {
        ValidatorInfo ValidatorInfo { get; set; }

        void UpdateLoggerItem(LoggerItem loggerItem);
    }
}
