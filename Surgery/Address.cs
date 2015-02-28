using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Surgery
{
    class Address
    {
        private string HouseNo;
        private string houseNo;

        public Address(string houseNo, string street, string postcode)
        {
            // TODO: Complete member initialization
            this.houseNo = houseNo;
            this.Street = street;
            this.Postcode = postcode;
        }
        private string Street { get; set; }
        private string Postcode
        {
            get;
            set;
        }
    }
}