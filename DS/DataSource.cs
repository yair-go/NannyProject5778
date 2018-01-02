using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.ComponentModel;

namespace DS
{
    public static class DataSource
    {
        // option 1, to change List in Datasource
        // Not good
        //private static BindingList<Nanny> nannysList;
        private static List<Nanny> nannysList;

        private static List<Mother> motherList;
        private static List<Contract> contractsList;
        private static List<Child> childsList;

         static DataSource()
        {
            nannysList = new List<Nanny>();
            motherList = new List<Mother>();
            childsList = new List<Child>();
            contractsList = new List<Contract>();
        }

        public static List<Nanny> NannysList
        {
            get
            {
                return nannysList;
            }
        }

        public static List<Mother> MotherList
        {
            get
            {
                return motherList;
            }          
        }

        public static List<Contract> ContractsList
        {
            get
            {
                return contractsList;
            }       
        }

        public static List<Child> ChildsList
        {
            get
            {
                return childsList;
            }
        }
    }
}
