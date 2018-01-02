using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;
using System.ComponentModel;

namespace DS
{
    public sealed class DAL_list : IDAL
    {
        #region Singleton
        private static readonly DAL_list instance = new DAL_list();

        public static DAL_list Instance
        {
            get { return instance; }
        }
        #endregion

        #region Constructors

        static DAL_list()
        {
            //DataSource.NannysList = new BindingList<Nanny>();
            //DataSource.MotherList = new List<Mother>();
            //DataSource.ChildsList = new List<Child>();
            //DataSource.ContractsList = new List<Contract>();
        }
        private DAL_list() { }

        #endregion

        #region Nanny

        public void addNanny(Nanny nanny)
        {
            if (!DataSource.NannysList.ToList().Exists(w => w.ID == nanny.ID))
                DataSource.NannysList.Add(nanny);
        }

         public string getLastNannyID()
        {
            return DataSource.NannysList.Last().ID;
        }

        public void deleteNanny(Nanny sp)
        {
            throw new NotImplementedException();
        }

        public void updateNanny(Nanny sp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateNanny(Nanny sp, Nanny newSP)
        {
            throw new NotImplementedException();
        }

        public void updateNanny(Nanny sp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }

        public BindingList<Nanny> getNannysList()
        {
            //TODO :
            //Binding List
            // option 1, return  BindingList from DataSource
            // return DataSource.NannysList;

            //option 2, make a clone of 
            return new BindingList<Nanny>(DataSource.NannysList.Clone());
            // return new BindingList<Nanny>(DataSource.NannysList);

            
        }
        #endregion

        #region Mother

        public void addMother(Mother wo)
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

        public void updateMother(Mother wo, Mother newWo)
        {
            throw new NotImplementedException();
        }

        public void updateMother(Mother wo, int cost, string minmax)
        {
            throw new NotImplementedException();
        }

        public List<Mother> getMothersList()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Child

        public void addChild(Child emp)
        {
            throw new NotImplementedException();
        }

        public void deleteChild(Child emp)
        {
            throw new NotImplementedException();
        }

        public void updateChild(Child emp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateChild(Child emp, Child newemp)
        {
            throw new NotImplementedException();
        }

        public void updateChild(Child emp, int cost, string minmax)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Contract

        public void addContract(Contract sp)
        {
            throw new NotImplementedException();
        }

        public void deleteContract(Contract sp)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, string name)
        {
            throw new NotImplementedException();
        }

        public void updateContract(Contract sp, Contract newSP)
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

        #endregion
    }
}