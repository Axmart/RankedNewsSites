using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankedNewsSites.Models
{
    public class NewsSite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string PictureSource { get; set; }
        public int Points { get; set; }
    }
}
