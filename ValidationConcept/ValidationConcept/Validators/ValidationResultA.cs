using ValidationConcept.Logger;

namespace ValidationConcept.Validators
{
    public class ValidationResultA : BaseValidationResult
    {
        
        private string PropX { get; set; }
        private string PropY { get; set; }

        public ValidationResultA(int rowId, string propX, string propY, ValidatorInfo validatorInfo)
            : base(rowId, validatorInfo)
        {
            PropX = propX;
            PropY = propY;
        }

        public override void UpdateLoggerItem(LoggerItem loggerItem)
        {
            base.UpdateLoggerItem(loggerItem);

            loggerItem.PropX = PropX;
            loggerItem.PropY = PropY;
        }


    }
}
