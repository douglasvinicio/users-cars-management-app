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
using System.Windows.Shapes;

namespace Users_Cars_Management_System
{
    /// <summary>
    /// Interaction logic for CarsWindow.xaml
    /// </summary>
    public partial class CarsDialog : Window
    {
        // We might use those ones as in the Car project showed before by Reza
        //public event Action<Car> AddedNewCar;
        public CarOwner currCarOwner;

        public CarsDialog(CarOwner carOwner)
        {
            // Here we populate dynamic fields on initalization of dialog window with informations about cars of the user
            InitializeComponent();

            // Assign parameter passed as currentCarOwner if not null
            if (carOwner != null)
            {
                currCarOwner = carOwner;
            }

            LoadData();                       
        }

        private void LoadData()
        {
            // Must find a way to query only the cars of the suposed owner, right now the list shows all cars inside the Car table
            // List<Car> carsList = Global.ctx.Cars.Find(currCarOwner.OwnerI);
            // List<Car> carsList = Global.ctx.Cars.Where(i => i.OwnerId == currCarOwner.OwnerId).ToList(); System.Reflection.TargetException: 'Non-static method requires a target.'
            //List<Car> carsList = Global.ctx.Cars.ToList<Car>();

            List<Car> carsList = Global.ctx.Cars.Where(s => s.OwnerId == currCarOwner.OwnerId).ToList();
            lvCars.ItemsSource = carsList;
            lblOwnerName.Content = currCarOwner.Name;
            lblOwnerId.Content = currCarOwner.OwnerId;
            lvCars.Items.Refresh();
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            string carMakeModel = txtMakeModel.Text;

            Car newCar = new Car { MakeModel = carMakeModel, OwnerId = currCarOwner.OwnerId };
            Global.ctx.Cars.Add(newCar);
            Global.ctx.SaveChanges();

            LoadData();
            ResetValues();
        }

        private void btnUpdateCar_Click(object sender, RoutedEventArgs e)
        {
            string newMakeModel = txtMakeModel.Text;

            Car carUpdate = (Car)lvCars.SelectedItem;

            carUpdate.MakeModel = newMakeModel;
            Global.ctx.SaveChanges();

            LoadData();
        }

        private void btnDeleteCar_Click(object sender, RoutedEventArgs e)
        {
            Car carDelete = (Car)lvCars.SelectedItem;
            Global.ctx.Cars.Remove(carDelete);
            Global.ctx.SaveChanges();

            LoadData();
            ResetValues();
        }

        private void lvCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdateCar.IsEnabled = true;
            btnDeleteCar.IsEnabled = true;

            var selectedCar = (Car)lvCars.SelectedItem;

            if (selectedCar is Car)
            {
                txtMakeModel.Text = selectedCar.MakeModel;
            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ResetValues()
        {
            txtMakeModel.Text = "";
        }
    }
}
