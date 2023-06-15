using Inventory.Domain.Products;
using Inventory.Domain.Products.Rules;
using Net.JourneyHero.Domain.BuildingBlocks.Entities;
using Net.JourneyHero.Domain.Products.Rules;

namespace Net.JourneyHero.Domain.Products;

public sealed class Product : Entity
{
    private Product(ProductId id, string name, string category, string? description)
    {
        Id = id;
        Name = name;
        Description = description;
        Category = category;
    }

    public ProductId Id { get; private set; }

    public string Name { get; private set; }

    public string Category { get; private set; }

    public string? Description { get; private set; }

    public static Product Create(string name, string category, string? description = default)
    {
        CheckRule(new NameMustNotBeEmptyRule(name));
        CheckRule(new CategoryMustNotBeEmptyRule(category));

        return new Product(ProductId.New, name, category, description);
    }
}