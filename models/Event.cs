using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.models
{
    internal class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }
        public organizer Organizer { get; set; }
        public int OrganizerID { get; set; }
    }
}
