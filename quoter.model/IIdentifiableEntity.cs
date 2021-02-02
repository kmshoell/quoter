using System;
namespace quoter.model
{
    public interface IIdentifiableEntity
    {
        Guid Id { get; set; }
    }
}
