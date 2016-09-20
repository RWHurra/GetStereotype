using EA;
using System;
using System.Runtime.InteropServices;

namespace GetStereotype
{
    [ComVisible(true)]
    public class AddIn
    {

        //Connect to Sparx repository
        public string EA_Connect(EA.Repository rep)
        {
            return "GetStereotype.AddIn - connected";
        }

        //Create class to fetch steroetype as string
        public string GetValueForStereotype(EA.Repository rep, string eaGuid, object stereotype)
        {
            EA.Element element = rep.GetElementByGuid(eaGuid);
            string ret = element.Stereotype;
            return ret;
        }

        //Disconnect from Sparx repository
        public void EA_Disconnect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
