namespace ByMail.Models
{
    using Avalonia.Media;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
#nullable disable
    public class MenuItem
    {
        public string Title { get; set; }
        public string Count { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public Geometry Ico { get; set; }
    }
}
