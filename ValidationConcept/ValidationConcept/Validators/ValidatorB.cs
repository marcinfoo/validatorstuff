using System;
using System.Collections.Generic;
using ValidationConcept.Interfaces;
using ValidationConcept.Validators;

namespace ValidationConcept
{
    public class ValidatorB : BaseValidator
    {

        public ValidatorB(ValidatorInfo validatorInfo)
            : base(validatorInfo)
        {
        }

        public override IEnumerable<IValidationResult> Validate()
        {
            var random = new Random(DateTime.Now.Millisecond).Next();

            for (int i = 0; i < 100; i++)
            {
                yield return
                    new ValidationResultB(i, string.Format("Prop1_{0}", random), string.Format("Prop2_{0}", random),
                        ValidatorInfo);
            }
        }
    }
}
