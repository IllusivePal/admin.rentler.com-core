using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Search
    {
        public int? MinBedrooms { get; set; }

        public int? MaxBedrooms { get; set; }

        public int? Bathrooms { get; set; }

        public int? MinBathrooms { get; set; }

        public int? MaxBathrooms { get; set; }

        public int? MinSquareFootage { get; set; }

        public int? MaxSquareFootage { get; set; }

        public int? YearBuiltMin { get; set; }

        public int? YearBuiltMax { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string [] GeoPolygonCoordinates { get; set; }
    }
}
