using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObjects;

namespace XamarinForms.Helpers
{
    public static class KupacData
    {
        public static Kupac _kupac;


        public static void SetObjects()
        {
        }

        public static void Set(DataTransferObjects.Kupac kupac)
        {
            _kupac = kupac;
        }

        public static DataTransferObjects.Kupac Get()
        {
            return _kupac;
        }
    }
}
