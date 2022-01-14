using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using Portfolio.Models.EntityModels;
using Portfolio.Repository;

namespace Portfolio.Controllers
{
    public class ContactController : BaseController<Contact, ContactRepository>
    {
        public ContactController(ContactRepository repository) : base(repository)
        {

        }
    }
}
