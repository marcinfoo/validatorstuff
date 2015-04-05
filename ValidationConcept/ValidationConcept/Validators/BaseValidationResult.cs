using ValidationConcept.Interfaces;
using ValidationConcept.Logger;

namespace ValidationConcept.Validators
{
    public abstract class BaseValidationResult : IValidationResult
    {
        public int RowId { get; set; }
        public ValidatorInfo ValidatorInfo { get; set; }

        protected BaseValidationResult(int rowId, ValidatorInfo validatorInfo)
        {
            RowId = rowId;
            ValidatorInfo = validatorInfo;
        }

        public virtual void UpdateLoggerItem(LoggerItem loggerItem)
        {
            loggerItem.Name = ValidatorInfo.Name;
            loggerItem.TableName = ValidatorInfo.TableName;
            loggerItem.RowId = RowId;
        }
    }
}
