using System.Collections.Generic;

namespace ValidationConcept.Interfaces
{
    public interface IValidator
    {
        IEnumerable<IValidationResult> Validate();
    }
}
