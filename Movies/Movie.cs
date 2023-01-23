using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDownloaded { get; set; }
        public string Type { get; set; }
        public string Type2 { get; set; }
        public string Link { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime AddDate { get; set; }
    }
}
