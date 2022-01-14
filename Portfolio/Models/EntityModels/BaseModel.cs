using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models.EntityModels
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
