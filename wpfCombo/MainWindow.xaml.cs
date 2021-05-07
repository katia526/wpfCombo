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

namespace wpfCombo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<persoon> MyList { get; set; } = new List<persoon>();
        public MainWindow()
        {
            InitializeComponent();
            MyList.Add(new persoon() { Naam = "Mouse", Voornaam = "Mickey", ImagePath = @"\images\mickey_mouse.png"});
            MyList.Add(new persoon() { Naam = "Pan", Voornaam = "Peter", ImagePath = @"\images\peter_pan.png"});
            MyList.Add(new persoon() { Naam = "Pirate", Voornaam = "Mister", ImagePath = @"\images\pirate.png"});
            MyList.Add(new persoon() { Naam = "Doggy", Voornaam = "Pluto", ImagePath = @"\images\pluto.png" });
            MyList.Add(new persoon() { Naam = "Balou", Voornaam = "Mowgli", ImagePath = @"\images\mowgli.png" });

            CmbBox.ItemsSource = MyList;
            CmbBox.SelectedIndex = 0;
        }

        private void CmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            persoon selectedItem = (CmbBox.SelectedItem as persoon);
            var test = selectedItem.ImagePath;
         //   Image img = new Image();
            foto.Source = new BitmapImage(new Uri(selectedItem.ImagePath, UriKind.Relative));
         
        }
    }
    public class persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string ImagePath { get; set; }
    }
}
