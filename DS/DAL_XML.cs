using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;
using System.ComponentModel;

namespace DS
{
    internal class DAL_XML : IDAL
    {
        #region Singleton
        private static readonly DAL_XML instance = new DAL_XML();

        public static DAL_XML Instance
        {
            get { return instance; }
        }
        #endregion

        #region Constructors

        static DAL_XML()
        {
            //DataSource.NannysList = new BindingList<Nanny>();
            //DataSource.MotherList = new List<Mother>();
            //DataSource.ChildsList = new List<Child>();
            //DataSource.ContractsList = new List<Contract>();
        }
        private DAL_XML() { }

        #endregion

        public void addChild(Child emp)
        {
            throw new NotImplementedException();
        }

        public void addContract(Contract sp)
        {
            throw new NotImplementedException();
        }

        public void addMother(Mother wo)
        {
            throw new NotImplementedException();
        }

        public void addNanny(Nanny sp)
        {
            throw new NotImplementedException();
        }

        public void deleteChild(Child emp)
        {
            throw new NotImplementedException();
        }

        public void deleteContract(Contract sp)
        {
            throw new NotImplementedException();
        }

        public void deleteMother(Mother wo)
        {
            throw new NotImplementedException();
        }

        public void deleteNanny(Nanny sp)
        {
            throw new NotImplementedException();
        }

        public List<Contract> getContractsList()
        {
            throw new NotImplementedException();
        }

        public string getLastNannyID()
        {
            throw new NotImplementedException();
        }

        public List<Mother> getMothersList()
        {
            throw new NotImplementedException();
        }

        public BindingList<Nanny> getNannysList()
        {
            throw new NotImplementedException();
        }

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

        public void updateMother(Mother wo, Mother newWo)
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
    }
}