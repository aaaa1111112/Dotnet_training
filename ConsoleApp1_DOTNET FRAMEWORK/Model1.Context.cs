﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1_DOTNET_FRAMEWORK
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NewDBEntities : DbContext
    {
        public NewDBEntities()
            : base("name=NewDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<student> student { get; set; }
    
        public virtual ObjectResult<Get_Name_With_Roll_Result> Get_Name_With_Roll(Nullable<int> roll, string add)
        {
            var rollParameter = roll.HasValue ?
                new ObjectParameter("Roll", roll) :
                new ObjectParameter("Roll", typeof(int));
    
            var addParameter = add != null ?
                new ObjectParameter("add", add) :
                new ObjectParameter("add", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Name_With_Roll_Result>("Get_Name_With_Roll", rollParameter, addParameter);
        }
    
        public virtual int insert_values_into_table_student2(string name, Nullable<int> age, Nullable<int> roll)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("age", age) :
                new ObjectParameter("age", typeof(int));
    
            var rollParameter = roll.HasValue ?
                new ObjectParameter("roll", roll) :
                new ObjectParameter("roll", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_values_into_table_student2", nameParameter, ageParameter, rollParameter);
        }
    
        public virtual ObjectResult<spAll_Result> spAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAll_Result>("spAll");
        }
    }
}