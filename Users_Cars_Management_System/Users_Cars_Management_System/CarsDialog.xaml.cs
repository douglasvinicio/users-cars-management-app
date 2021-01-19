using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace Users_Cars_Management_System
{
    /// <summary>
    /// Interaction logic for CarsWindow.xaml
    /// </summary>
    public partial class CarsWindow : Window
    {
        public CarsWindow()
        {
            InitializeComponent();
        }
        //======================================================================================================
        //adding a record in database
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Cars> carsList = new List<Cars>();
            //List<CarOwners> carOwnerList = new List<CarOwners>();
            if ((txtMakeModel.Text == ""))
            {
                MessageBox.Show("Input string error.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            try
            {
                //insert into db
                Cars cars = new Cars() { MakeModel = txtMakeModel.Text};
                Global.uContext.carsDbset.Add(cars);
                Global.uContext.SaveChanges();

                MessageBox.Show("record is added");
                carsList.Add(cars);
                ResetValue();
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
            LoadFile();
        }
        //======================================================================================================
        //reset the values for the form
        private void ResetValue()
        {
            lvCars.Items.Refresh();
            lblCarId.Content = "";
            txtMakeModel.Text = "";
            lvCars.SelectedIndex = -1;
            btnUpdateCar.IsEnabled = false;
            btnDeleteCar.IsEnabled = false;
        }
        //======================================================================================================
        //fetching file 
        private void LoadFile()
        {
            //fetching all data with LINQ
            //List<CarOwners> carOwnersList = (from t in Global.uContext.ownersDbset select t).ToList<CarOwners>();
            List<Cars> carsList2 = Global.uContext.carsDbset.ToList<Cars>();
            lvCars.ItemsSource = carsList2;
        }
        //======================================================================================================

    }
}
