using System;

namespace Todo.Models.Entities
{
    public class UnusualDate
    {
        public virtual int Id { get; set; }
        public virtual System.DateTimeOffset CreationDate { get; set; }
        public virtual System.DateTime ModificationDate { get; set; }
        public virtual Nullable<System.DateTimeOffset> CreationDate2 { get; set; }
        public virtual Nullable<System.DateTime> ModificationDate2 { get; set; }
    }
}
