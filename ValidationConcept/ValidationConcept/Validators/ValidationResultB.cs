using ValidationConcept.Logger;
using ValidationConcept.Validators;

namespace ValidationConcept
{
    public class ValidationResultB : BaseValidationResult
    {
        public string Prop1 { get; set; }
        public string Prop2 { get; set; }

        public ValidationResultB(int rowId, string prop1, string prop2, ValidatorInfo validatorInfo)
            : base(rowId, validatorInfo)
        {
            Prop1 = prop1;
            Prop2 = prop2;
        }

        public override void UpdateLoggerItem(LoggerItem loggerItem)
        {
            base.UpdateLoggerItem(loggerItem);

            loggerItem.Prop1 = Prop1;
            loggerItem.Prop2 = Prop2;
        }
    }
}
