using BuildingBlocks.Domain.BusinessRules;
using Net.JourneyHero.Domain.BuildingBlocks.BusinessRules;

namespace Net.JourneyHero.Domain.BuildingBlocks.ValueObjects;

public record class ValueObject
{
    /// <summary>
    /// Checks business rule for ValueObject.
    /// </summary>
    /// <param name="rule">Business rule to check.</param>
    /// <exception cref="BusinessRuleValidationException">Exception can be thrown on invalid business rule.</exception>
    protected static void CheckRule(IBusinessRule rule)
    {
        if (rule.BrokenWhen)
        {
            throw new BusinessRuleValidationException(rule);
        }
    }
}