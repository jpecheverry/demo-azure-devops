namespace Bakery.Transaction.Domain;

public class Unit : AggregateRoot
{
    public string Name { get; private set; }


    private Unit() { }

    public Unit(string name)
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