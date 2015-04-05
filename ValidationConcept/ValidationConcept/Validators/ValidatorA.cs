using System;
using System.Collections.Generic;
using ValidationConcept.Interfaces;
using ValidationConcept.Validators;

namespace ValidationConcept
{
    public class ValidatorA : BaseValidator
    {

        public ValidatorA(ValidatorInfo validatorInfo) : base(validatorInfo)
        {
        }

        public override IEnumerable<IValidationResult> Validate()
        {
            var random = new Random(DateTime.Now.Millisecond).Next();

            for (int i = 0; i < 100; i++)
            {
                yield return
                    new ValidationResultA(i, string.Format("PropX_{0}", random), string.Format("PropY_{0}", random),
                        ValidatorInfo);
            }
        }
    }
}
