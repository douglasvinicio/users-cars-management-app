using Microsoft.Win32;
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
        }

       //======================================================================================================
        //adding a record in database
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Cars> carsList = new List<Cars>();
            List<CarOwners> carOwnerList = new List<CarOwners>();
            if ((txtName.Text == ""))
                {
                    MessageBox.Show("Input string error.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|.jpeg|PNG Files (*.png)|*.png|JPG Files(*.jpg|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog() == true)
            {
                ImgOwner.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
           
                try
                {
                    //insert into db
                    
                    CarOwners carOwners = new CarOwners() { Name = txtName.Text, OwnerImage = ImgOwner.};
                    Global.uContext.ownersDbset.Add(carOwners);
                //Global.uContext.ownersDbset
                Global.uContext.SaveChanges();

                    MessageBox.Show("record is added");
                    carOwnerList.Add(carOwners);
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
                lvOwners.Items.Refresh();
                lblId.Content = "";
                txtName.Text = "";           
                lvOwners.SelectedIndex = -1;
                btnDelete.IsEnabled = false;
                btnUpdate.IsEnabled = false;
            }
        //======================================================================================================
          //fetching file 
        private void LoadFile()
        {
            //fetching all data with LINQ
            //List<CarOwners> carOwnersList = (from t in Global.uContext.ownersDbset select t).ToList<CarOwners>();
            List<CarOwners> carOwnersList2 = Global.uContext.ownersDbset.ToList<CarOwners>();
            lvOwners.ItemsSource = carOwnersList2;
        }
        //======================================================================================================

    }
}
