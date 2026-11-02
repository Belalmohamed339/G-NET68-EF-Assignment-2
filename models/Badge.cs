using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.models
{
    internal class Badge
    {
        public int BadgeId { get; set; }
        public string BadgeNumber { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public BadgeTier Tier { get; set; }

        public ICollection<AttendeeBadge> AttendeeBadges { get; set; } = new List<AttendeeBadge>();
    }
}
