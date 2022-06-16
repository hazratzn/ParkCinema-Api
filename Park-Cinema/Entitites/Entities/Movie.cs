using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Entity.Entities
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public int ClaimerAge { get; set; }
        public string Image { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Year { get; set; }
        public string Trailer { get; set; }
        public string VideoUrl { get; set; }
        public string Duration { get; set; }
        public string Formats { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<MovieContentLanguage> Languages { get; set; }

        public IEnumerable<string> GetDates()
        {
            while (StartTime < EndTime)
            {
                yield return StartTime.ToString("M");
                StartTime = StartTime.AddDays(1);
            }
        }
    }
}
