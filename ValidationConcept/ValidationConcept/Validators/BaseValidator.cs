using System.Collections.Generic;
using ValidationConcept.Interfaces;

namespace ValidationConcept.Validators
{
    public abstract class BaseValidator : IValidator
    {
        protected ValidatorInfo ValidatorInfo { get; set; }

        protected BaseValidator(ValidatorInfo validatorInfo)
        {
            ValidatorInfo = validatorInfo;
        }

        public abstract IEnumerable<IValidationResult> Validate();
    }
}
