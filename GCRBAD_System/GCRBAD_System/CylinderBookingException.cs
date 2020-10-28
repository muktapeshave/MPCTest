using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCRBAD_System
{
    //Don't change any existing member of this type

    public class CylinderBookingException : Exception
    {
        public CylinderBookingException()
            : base("Cylinder Booking Exception") { }

        public CylinderBookingException(string message)
            : base(message) { }
    }
}