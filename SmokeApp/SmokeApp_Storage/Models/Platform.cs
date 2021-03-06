using System;
using System.Collections.Generic;

#nullable disable

namespace SmokeApp_Storage.Models
{
    public partial class Platform
    {
        public Platform()
        {
            GamesPlatforms = new HashSet<GamesPlatform>();
        }

        public int PlatformId { get; set; }
        public string PlatformName { get; set; }

        public virtual ICollection<GamesPlatform> GamesPlatforms { get; set; }
    }
}
