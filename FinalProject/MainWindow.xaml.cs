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


namespace FinalProject
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

        private void Add_Player_Button_Click(object sender, RoutedEventArgs e)
        {
            if (FieldValidator())
            {
                //AddPlayer();
                MessageBox.Show("Player has been successfully added.");
            }
        }

        private bool FieldValidator()
        {
            bool ok = true;
            if (txt_fisrtName.Text == "")
            {
                ok = false;
                MessageBox.Show("Insert first name.");
            }
            return ok;

            if (txt_lastName.Text == "")
            {
                ok = false;
                MessageBox.Show("Insert last name.");
            }
            return ok;

            if (txt_DOB.Text == "")
            {
                ok = false;
                MessageBox.Show("Insert date of Birth.");
            }
            return ok;
        }
        private void txt_DOB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "." && IsNumber(e.Text) == false)
            {
                e.Handled = true;
            }
            else if (e.Text == ".")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }
        //knowing if the input is Int or not
        private bool IsNumber(string Text)
            {
                int output;
                return int.TryParse(Text, out output);
            }
        private void txt_fisrtName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
        }
    }

}
