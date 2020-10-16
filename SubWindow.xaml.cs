using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow(Contact contact)
        {
            InitializeComponent();
            textBox.Text = contact.FName;
            textBox_Copy.Text = contact.LName;
            textBox_Copy1.Text = contact.DateofBirth.ToString("dd/MM/yyyy");
            textBox_Copy2.Text = contact.EmailIds[0];
            textBox_Copy3.Text = contact.EmailIds[1];
            textBox_Copy4.Text = contact.PhNumbers[0];
            textBox_Copy5.Text = contact.PhNumbers[1];
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact1 = new Contact();
            contact1.FName = textBox.Text;
            contact1.LName = textBox_Copy.Text;
            contact1.DateofBirth = Convert.ToDateTime(textBox_Copy1.Text);
            contact1.EmailIds = new List<string>() {textBox_Copy2.Text,textBox_Copy3.Text };
            contact1.PhNumbers= new List<string>() { textBox_Copy4.Text, textBox_Copy5.Text };

            HttpClient h = new HttpClient();

        }
    }
}
