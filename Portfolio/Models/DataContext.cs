using Microsoft.EntityFrameworkCore;
using Portfolio.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions options) : base(options) {}

       public virtual DbSet<Contact> Contacts{ get; set;}
    }
}
