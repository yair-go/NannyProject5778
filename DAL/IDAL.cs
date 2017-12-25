using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.ComponentModel;

namespace DAL
{
    public interface IDAL
    {

        #region Nanny
        void addNanny(Nanny sp);
        void deleteNanny(Nanny sp);
        void updateNanny(Nanny sp, string name);
        void updateNanny(Nanny sp, Nanny newSP);
        void updateNanny(Nanny sp, int cost, string minmax);
        BindingList<Nanny> getNannysList();
        #endregion

        #region Mother
        void addMother(Mother wo);
        void deleteMother(Mother wo);
        void updateMother(Mother wo, string name);
        void updateMother(Mother wo, Mother newWo);
        void updateMother(Mother wo, int cost, string minmax);
        List<Mother> getMothersList();
        #endregion

        #region Child
        void addChild(Child emp);
        void deleteChild(Child emp);
        void updateChild(Child emp, string name);
        void updateChild(Child emp, Child newemp);
        void updateChild(Child emp, int cost, string minmax);
        #endregion

        #region Contract
        void addContract(Contract sp);
        void deleteContract(Contract sp);
        void updateContract(Contract sp, string name);
        void updateContract(Contract sp, Contract newSP);
        void updateContract(Contract sp, int cost, string minmax);
        List<Contract> getContractsList();
        string getLastNannyID();
        #endregion

    }
}
