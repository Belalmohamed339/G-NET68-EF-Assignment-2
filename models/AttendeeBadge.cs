using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.models
{
    internal class AttendeeBadge
    {
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;

        public int BadgeId { get; set; }
        public Badge Badge { get; set; } = null!;

        public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
    }
}
