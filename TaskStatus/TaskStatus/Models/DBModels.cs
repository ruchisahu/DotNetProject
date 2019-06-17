using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskStatus.Models
{
    public class DBModels: DbContext
    {
        public DBModels()
            : base("name=TestDatabase")
        { }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Task> Task { get; set; }
    }
}