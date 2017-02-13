namespace SharoStore.Data
{
    using SharpStore.Models;
    using System.Data.Entity;

    public class SharpStoreContext : DbContext
    {
        public SharpStoreContext()
            : base("name=SharpStoreContext")
        {
        }

        public virtual DbSet<Knife> Knives { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        
    }
}