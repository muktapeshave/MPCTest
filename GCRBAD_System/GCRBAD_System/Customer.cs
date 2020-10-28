using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCRBAD_System
{
    //Don't change any existing member of this type
    public struct FullAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    //Don't change any existing member of this type
    public class Customer
    {
        List<CylinderRefillRequest> cylinderRefillHistory = null;
        
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public FullAddress Address { get; set; }        
        public List<CylinderRefillRequest> CylinderRefillHistory
        {
            get { return cylinderRefillHistory; }
            set { cylinderRefillHistory = value; }
        }

        public Customer()
        {
            cylinderRefillHistory = new List<CylinderRefillRequest>();            
        }          
    }
}
