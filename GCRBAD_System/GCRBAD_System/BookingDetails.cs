using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCRBAD_System
{
    //Don't modify this enum.
    public enum DeliveryStatus { Initiated, Delivered, Canceled };

    //Don't change any existing member of this type
    public class CylinderRefillRequest
    {
        public string RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public int RemCylCountWhileRequest { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }

        public DateTime ActualDeliveryDate { get; set; }
        public double TotalAmountPaid { get; set; }       
    }
}