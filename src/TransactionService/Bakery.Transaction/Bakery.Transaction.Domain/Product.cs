namespace Bakery.Transaction.Domain;

public class Product : AggregateRoot
{
    public string Name { get; private set; }
    public string QR { get; private set; }
    public decimal UnitPrice { get; private set; }
    public Guid CategoryId { get; private set; }
    public Guid BrandId { get; private set; }
    public Guid UnitId { get; private set; }

    private Product(){}

    public Product(string name, string qr, decimal unitPrice, Guid categoryId, Guid brandId, Guid unitId)
    {
        ValidateDomain(name, qr, unitPrice, categoryId, brandId, unitId);
        Id = IdentityGenerator.NewSequencialGuid();
    }

    public void Update(string name, string qr, decimal unitPrice, Guid categoryId, Guid brandId, Guid unitId)
    {
        ValidateDomain(name, qr, unitPrice, categoryId, brandId, unitId);
    }

    private void ValidateDomain(string name, string qr, decimal unitPrice, Guid categoryId, Guid brandId, Guid unitId)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name),DomainExceptionValidation.RequiredValueMessage, nameof(name));
        DomainExceptionValidation.When(string.IsNullOrEmpty(qr),DomainExceptionValidation.RequiredValueMessage, nameof(qr));
        DomainExceptionValidation.When(unitPrice <= 0, DomainExceptionValidation.RequiredValueMessage, nameof(unitPrice));
        DomainExceptionValidation.When(categoryId == Guid.Empty, DomainExceptionValidation.RequiredValueMessage, nameof(categoryId));
        DomainExceptionValidation.When(brandId == Guid.Empty, DomainExceptionValidation.RequiredValueMessage, nameof(brandId));
        DomainExceptionValidation.When(unitId == Guid.Empty, DomainExceptionValidation.RequiredValueMessage, nameof(unitId));

        Name = name;
        QR = qr;
        UnitPrice = unitPrice;
        CategoryId = categoryId;
        BrandId = brandId;
        UnitId = unitId;
    }
}