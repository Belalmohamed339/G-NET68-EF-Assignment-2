using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.models
{
    internal class organizerprofile
    {
        public int OrganizerProfileId { get; set; }
        public string Biography { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public organizer Organizer { get; set; }
        public int organizerID { get; set; }

    }
}
