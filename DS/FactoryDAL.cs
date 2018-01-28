using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;


namespace DS
{
    public sealed class FactoryDAL
    {
        #region Singleton
        private static readonly FactoryDAL instance = new FactoryDAL();

        static FactoryDAL() { }
        private FactoryDAL() { }

        public static FactoryDAL Instance
        {
            get { return instance; }
        }
        #endregion

        public static IDAL getDAL(string typeDL)
        {
            switch (typeDL)
            {
                case "List": return DAL_list.Instance;
                case "XML": return DAL_XML.Instance;
                default: return null;
            }
        }

    }

   
}