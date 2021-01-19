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
        //public Car currCar;

        public CarsDialog(CarOwner carOwner)
        {
            InitializeComponent();
            // Here we populate dynamic fields on initalization of dialog window with informations about cars of the user
        }
    }
}
