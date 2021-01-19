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

namespace Users_Cars_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<CarOwner> carOwnersList = Global.ctx.CarOwners.ToList<CarOwner>();
            lvOwners.ItemsSource = carOwnersList;
            lvOwners.Items.Refresh();
        }

        private void btnManageCars_Click(object sender, RoutedEventArgs e)
        {
            // Showing Cars Dialog Window 
            // Here I'm passing car owner selected item on list as a parameter to open new dialog window. But not sure yet how to fetch this owner from db.
            CarOwner carOwner = (CarOwner)lvOwners.SelectedItem;
            CarsDialog carsDialog = new CarsDialog(carOwner);
            carsDialog.Owner = this;
            bool? result = carsDialog.ShowDialog();

            if (result == true)
            {
                lvOwners.Items.Refresh();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            CarOwner newCarOwner = new CarOwner { Name = name};
            Global.ctx.CarOwners.Add(newCarOwner);
            Global.ctx.SaveChanges();

            LoadData();
            ResetValues();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string newName = txtName.Text;

            CarOwner carOwnerUpdate = (CarOwner)lvOwners.SelectedItem;

            carOwnerUpdate.Name = newName;
            Global.ctx.SaveChanges();

            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            CarOwner carOwnerDelete = (CarOwner)lvOwners.SelectedItem;
            Global.ctx.CarOwners.Remove(carOwnerDelete);
            Global.ctx.SaveChanges();

            LoadData();
            ResetValues();
        }

        private void lvOwners_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;

            var selectedOwner = lvOwners.SelectedItem;

            if (selectedOwner is CarOwner)
            {
                CarOwner carOwner = (CarOwner)lvOwners.SelectedItem;

                txtName.Text = carOwner.Name;
                lblId.Content = carOwner.OwnerId;
            }
        }

        public void ResetValues()
        {
            txtName.Text = "";
            lblId.Content = "";
        }
    }
}
