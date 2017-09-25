using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace soap_billet_ande605x     // PRODUCER--
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BilletService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BilletService.svc or BilletService.svc.cs at the Solution Explorer and start debugging.
    public class BilletService : IBilletService
    {

        // HUSK AT SLETTE GetData og GetDataUsingDataContract INDEN PUBLISH FOR BEDRE CODE COVERAGE I UNIT TESTS


        public int PrisBilMedBrobizz()
        {
            BilletLib.Bil nyBil = new BilletLib.Bil("XX99999", new DateTime(2017, 9, 20), true);
            return 99999; //nyBil.Pris();
        }

        public int PrisMCMedBrobizz()
        {
            BilletLib.MC nyMC = new BilletLib.MC("XX99999", new DateTime(2017, 9, 20), true);
            return nyMC.Pris();
        }

        public int PrisBilUdenBrobizz()
        {
            BilletLib.Bil nyBil = new BilletLib.Bil("XX99999", new DateTime(2017, 9, 20), false);
            return nyBil.Pris();
        }

        public int PrisMCUdenBrobizz()
        {
            BilletLib.MC nyMC = new BilletLib.MC("XX99999", new DateTime(2017, 9, 20), false);
            return nyMC.Pris();
        }





        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
