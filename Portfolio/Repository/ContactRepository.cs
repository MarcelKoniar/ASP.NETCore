using Portfolio.Models;
using Portfolio.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Repository
{
    public class ContactRepository : BaseRepository<Contact, DataContext>
    {
        public ContactRepository(DataContext context) : base(context)
        {

        }
    }
}
