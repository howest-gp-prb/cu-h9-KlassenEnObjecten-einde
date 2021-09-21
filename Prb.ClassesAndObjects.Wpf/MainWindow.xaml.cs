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
using Prb.ClassesAndObjects.Core;

namespace Prb.ClassesAndObjects.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> cars;
        public MainWindow()
        {
            InitializeComponent();
            cars = new List<Car>();
        }

        private void btnAddNewCar_Click(object sender, RoutedEventArgs e)
        {
            string color = txtColor.Text.Trim();
            string carbrand = txtCarBrand.Text.Trim();
            decimal.TryParse(txtPrice.Text.Trim(), out decimal price);

            Car car = new Car();
            car.color = color;
            car.brand = carbrand;
            car.price = price;

            // OF via constructor:
            //Car car = new Car(carbrand, color, price);

            cars.Add(car);
            UpdateCarListbox();

        }
        private void UpdateCarListbox()
        {
            ////3 mogelijke manieren om de listbox te vullen met de List: 

            //// #1
            // lstCars.ItemsSource = cars;
            // lstCars.Items.Refresh();
            //// #2
            // lstCars.ItemsSource = null;
            // lstCars.ItemsSource = cars;
            //// #3
            ///
            lstCars.Items.Clear();
            foreach(Car car in cars)
            {
                lstCars.Items.Add(car);
            }
        }

        private void lstCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCars.SelectedItem != null)
            {
                Car car = (Car)lstCars.SelectedItem;
                txtCarBrand.Text = car.brand;
                txtColor.Text = car.color;
                txtPrice.Text = car.price.ToString();
            }
        }
    }
}
