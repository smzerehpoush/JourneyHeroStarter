using BuildingBlocks.Domain.BusinessRules;

namespace Net.JourneyHero.Domain.Products.Rules;

internal sealed record CategoryMustNotBeEmptyRule(string Category) : IBusinessRule
{
    public string Message => "Product category must not be empty.";

    public bool BrokenWhen => string.IsNullOrWhiteSpace(Category);
}