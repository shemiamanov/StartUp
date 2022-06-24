using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StartUp_Back_End.Models
{
    public class Autorh
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageUrl { get; set; }
    }
}
