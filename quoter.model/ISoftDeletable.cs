using System;
namespace quoter.model
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }

}
