using DAN_XLIX_Dejan_Prodanovic.Commands;
using DAN_XLIX_Dejan_Prodanovic.Service;
using DAN_XLIX_Dejan_Prodanovic.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DAN_XLIX_Dejan_Prodanovic.ViewModel
{
    class OwnerViewModel : ViewModelBase
    {
        OwnerView view;
        IHotelService hotelService;

       
        public OwnerViewModel(OwnerView ownerViewOpen)
        {
            view = ownerViewOpen;
            hotelService = new HotelService();

        }
            
        private ICommand logout;
        public ICommand Logout
        {
            get
            {
                if (logout == null)
                {
                    logout = new RelayCommand(param => LogoutExecute(), param => CanLogoutExecute());
                }
                return logout;
            }
        }

        private void LogoutExecute()
        {
            try
            {
                LoginView loginView = new LoginView();
                loginView.Show();
                view.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanLogoutExecute()
        {
            return true;
        }



        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }

        private void CloseExecute()
        {
            try
            {
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanCloseExecute()
        {
            return true;
        }



        private ICommand addEmployee;
        public ICommand AddEmployee
        {
            get
            {
                if (addEmployee == null)
                {
                    addEmployee = new RelayCommand(param => AddEmployeeExecute(),
                        param => CanAddEmployeeExecute());
                }
                return addEmployee;
            }
        }

        private void AddEmployeeExecute()
        {
            try
            {
                AddEmployee addEmployee = new AddEmployee();
                addEmployee.ShowDialog();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanAddEmployeeExecute()
        {

            return true;
        }

        private ICommand addManager;
        public ICommand AddManager
        {
            get
            {
                if (addManager == null)
                {
                    addManager = new RelayCommand(param => AddManagerExecute(),
                        param => CanAddManagerExecute());
                }
                return addManager;
            }
        }

        private void AddManagerExecute()
        {
            try
            {
                AddManager addManager = new AddManager();
                addManager.ShowDialog();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanAddManagerExecute()
        {

            return true;
        }
    }
}