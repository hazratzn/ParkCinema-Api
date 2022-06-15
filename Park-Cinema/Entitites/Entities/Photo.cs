using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Photo:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        [NotMapped]
        public IFormFile PhotosFile { get; set; }
    }
} 
