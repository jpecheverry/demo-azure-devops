namespace Bakery.Transaction.Domain;

public class Category : AggregateRoot
{
    public string Name { get; private set; }


    private  Category(){}

    public Category(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), DomainExceptionValidation.RequiredValueMessage, nameof(name));
        Id = IdentityGenerator.NewSequencialGuid();
    }

    public void ChangeName(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), DomainExceptionValidation.RequiredValueMessage, nameof(name));
        Name = name;
    }
}