using System.Collections.Generic;

namespace PortfolioBlazorWASMv2.Models
{
    public class UserModel
    {
        public string name { get; set; }
        public string position { get; set; }
        public string city { get; set; }
        public string info { get; set; }
        public string aboutme { get; set; }
        public List<Experience> lstExperience { get; set; } 
    }
    public class Experience
    {
        public string detail { get; set; }
        public string title { get; set; }
        public string year { get; set; }
    }
}
