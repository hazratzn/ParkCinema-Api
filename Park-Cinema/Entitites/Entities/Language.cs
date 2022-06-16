using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public class Language:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<MovieContentLanguage> Movies { get; set; }
        public ICollection<Navbar> Navbars { get; set; }
        //public ICollection<Footer> Footers { get; set; }
        //public ICollection<Hall> Halls { get; set; }
        //public ICollection<Branch> Branches { get; set; }
        //public ICollection<Contact> Contacts { get; set; }
        //public ICollection<Imax> Imaxes { get; set; }
        //public ICollection<MovieDetail> MovieDetails { get; set; }
        //public ICollection<Session> Sessions { get; set; }
        //public ICollection<VIP> VIPs { get; set; }
        //public ICollection<AboutUs> AboutUs { get; set; }
        //public ICollection<AdvertisingOffer> AdvertisingOffers { get; set; }
        //public ICollection<Campaign> Campaigns { get; set; }
        //public ICollection<CampaignDetail> CampaignDetails { get; set; }
        //public ICollection<Format> Formats { get; set; }
        //public ICollection<Rules> Rules { get; set; }
        //public ICollection<Photos> Photos { get; set; }
    }
}
