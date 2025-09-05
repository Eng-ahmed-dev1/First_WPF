using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace First_WPF
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

        private void Applybutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is :{this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // this key word is used to access the elements from the  XAML and this method make the all chech box false if the user click on reset button 
            this.WeldCheckBocx.IsChecked =
                this.AssemblyCheckBocx.IsChecked =
                this.PlasmaCheckBocx.IsChecked =
                this.LaserCheckBocx.IsChecked =
                this.PurchaseCheckBocx.IsChecked =
                this.LatheCheckBocx.IsChecked =
                this.DrillCheckBocx.IsChecked =
                this.FoldCheckBocx.IsChecked =
                this.RollCheckBocx.IsChecked =
                this.SawCheckBocx.IsChecked = false;
                this.DescriptionText.Text = "";

        }

        private void CheckBocx_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text +=((CheckBox)sender).Content;
        }
    }
}
