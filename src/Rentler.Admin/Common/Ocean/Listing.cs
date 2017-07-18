using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common.Ocean
{
	public class Listing
	{
		public string TemplateId { get; set; }
		public string ShowingInstructions { get; set; }
		public bool CoBrokerAgreement { get; set; }
		public float CoBrokerFee { get; set; }
		public string Instructions { get; set; }
		public string LeaseTerm { get; set; }
		public bool LeaseToOwnAvailable { get; set; }
		public string LeaseDetails { get; set; }
		public float Price { get; set; }
		public float Deposit { get; set; }
		public string Headline { get; set; }
		public string ApplicationUrl { get; set; }
		public float ApplicationFee { get; set; }
		public bool HousingAssistance { get; set; }
		public DateTime DateAvailable { get; set; }
		public DateTime StartDate { get; set; }
		public bool ShowWeatherLink { get; set; }
		public bool ShowNeighborhoodDemo { get; set; }
		public bool ShowMap { get; set; }
		public DateTime ModifyDate { get; set; }
	}
}
