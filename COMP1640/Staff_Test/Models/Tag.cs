using System.Collections.Generic;

namespace Staff_Test.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public string tag_name { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
