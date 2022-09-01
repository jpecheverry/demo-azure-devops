namespace Bakery.BuildingBlocks.Common;

public class DomainExceptionValidation : Exception
{
    public const string RequiredValueMessage = "{0} value is required";

    public DomainExceptionValidation(string error) : base(error)
    {
    }

    public static void When(bool hasError, string error, params object[] paramenters)
    {
        if (hasError) throw new DomainExceptionValidation(string.Format(error, paramenters));
    }
}