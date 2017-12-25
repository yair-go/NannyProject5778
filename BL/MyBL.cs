using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;
using DS;
using System.Configuration;
using System.ComponentModel;

namespace BL
{
    public class MyBL : IBL
    {

        #region Singleton
        private static readonly MyBL instance = new MyBL();

        public static MyBL Instance
        {
            get { return instance; }
        }
        #endregion

        static IDAL MyDal;

        #region Constructor

        private MyBL() { }

        static MyBL()
        {
             string TypeDAL = ConfigurationSettings.AppSettings.Get("TypeDS");
            
            MyDal = FactoryDAL.getDAL(TypeDAL);
        }

        #endregion
        
        #region Child
        public void updateChild(Child emp, Child newemp)
        {
            throw new NotImplementedException();
        }

        public void updateChild(Child emp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateChild(Child emp, int cost, string minmax)
        {
            throw new NotImplementedException();

        }
        public void addChild(Child emp)
        {
            throw new NotImplementedException();
        }

        public void deleteChild(Child emp)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Contract
        public void addContract(Contract sp)
        {
            throw new NotImplementedException();
        }

        public string getLastNannyID()
        {
            return MyDal.getLastNannyID();
        }

        public void updateContract(Contract sp, Contract newSP)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }
        public List<Contract> getContractsList()
        {
            throw new NotImplementedException();
        }

        public void deleteContract(Contract sp)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Mother
        public void updateMother(Mother wo, Mother newWo)
        {
            throw new NotImplementedException();
        }

        public void addMother(Mother wo)
        {
            throw new NotImplementedException();
        }



        public List<Mother> getMothersList()
        {
            throw new NotImplementedException();
        }
        public void deleteMother(Mother wo)
        {
            throw new NotImplementedException();
        }
        public void updateMother(Mother wo, string name)
        {
            throw new NotImplementedException();
        }

        public void updateMother(Mother wo, int cost, string minmax)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Nanny
        public void addNanny(Nanny nanny)
        {
            if (nanny.Age < 18) throw new Exception("The age must least 18");
            MyDal.addNanny(nanny);
        }

        public void deleteNanny(Nanny sp)
        {
            throw new NotImplementedException();
        }
        public BindingList<Nanny> getNannysList()
        {
            return MyDal.getNannysList();
        }
        public void updateNanny(Nanny sp, Nanny newSP)
        {
            throw new NotImplementedException();
        }

        public void updateNanny(Nanny sp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateNanny(Nanny sp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}