using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using BL;
using BE;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Members
        private MyBL bl;
        private BindingList<Nanny> NannysList;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            bl = MyBL.Instance;
            CreateDemoEntites();
            LoadNannyListOnWindow();
           

        }

        private void CreateDemoEntites()
        {
            int[] idArray = new int[] { 1, 2, 3, 4,5 };
            foreach (int i in idArray)
            {
                bl.addNanny(new Nanny(i.ToString(), 20));
              //  bl.addChild(new Child(i.ToString(), 20));
            }
          
        }

        private void LoadNannyListOnWindow()
        {
            NannysList = bl.getNannysList();

            //option 1. Problem : PL has directly access to DataSource
            // NannysList.Add(new Nanny("10", 30));

            lvNanny.DataContext = NannysList;
            //
           // lvNanny.DataContext = bl.getNannysList();
            
        }

        private void addNannyButton_Click(object sender, RoutedEventArgs e)
        {
            string id = bl.getLastNannyID();
            int newID;
            int.TryParse(id, out newID);
            newID++;
            bl.addNanny(new Nanny((newID).ToString(), 21));

            //option 0, the PL has another BindingList
            //Problem : PL responsibility

            //  NannysList.Add(new Nanny((newID).ToString(), 21));

            //option 0, ver 2
            RefreshWindow();
        }

        private void RefreshWindow()
        {
            //option 0, ver 2. Problem : This is not general enough
            LoadNannyListOnWindow();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            new SettingWindow().Show();
        }
    }
}
