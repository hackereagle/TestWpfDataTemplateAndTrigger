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

namespace TestDataTrigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TestTriggerViewModel? ViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new TestTriggerViewModel();
            ViewModel.Items = new System.Collections.ObjectModel.ObservableCollection<Item>()
                {
                new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\forest_road.bmp")), Name = "First Item"},
                new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\house.bmp")), Name = "Second Item"},
                new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\jetplane.bmp")), Name = "Third Item"},
                new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\lake.bmp")), Name = "Fourth Item"},
            };
            //ViewModel.Items.Add(new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\forest_road.bmp")), Name = "First Item"});
            //ViewModel.Items.Add(new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\house.bmp")), Name = "Second Item"});
            //ViewModel.Items.Add(new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\jetplane.bmp")), Name = "Third Item"});
            //ViewModel.Items.Add(new Item() { IsSelected = false, Source = new BitmapImage(new Uri(@"D:\projects\00.TestAndPrivates\TestDataTrigger\icons\lake.bmp")), Name = "Fourth Item"});
        }
    }
}
