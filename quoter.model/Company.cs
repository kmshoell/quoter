using System;
namespace quoter.model
{
    public class Company : IIdentifiableEntity, ISoftDeletable
    {
        //constructor
        public Company()
        {
            //Guid (global unique id)
            //if Guid hasn't been set, creates new unique id
            Id = Guid.NewGuid();
        }
        //public properties
        
        public Guid Id { get; set; }
        public int RowId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public bool IsDeleted { get; set; }

    }
}
