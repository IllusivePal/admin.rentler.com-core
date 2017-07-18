using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
	public class UserPreview
	{
		public int UserId { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string DisplayName
		{
			get
			{
				if (string.IsNullOrWhiteSpace(this.FirstName) || string.IsNullOrWhiteSpace(this.LastName))
					return (string.IsNullOrWhiteSpace(this.Username) ? this.Email : this.Username);
				else
					return string.Format("{0} {1}", this.FirstName, this.LastName);
			}
		}
		public DateTime CreateDateUtc { get; set; }
        public DateTime UpdateDateUtc { get; set; }
		public bool IsDeleted { get; set; }        
        public bool IsScammer { get; set; }

        public int BuildingCount { get; set; }

        public int CommunityCount { get; set; }
        public AccountUpgradeDetail UpgradeDetail { get; set; }
	}
}
