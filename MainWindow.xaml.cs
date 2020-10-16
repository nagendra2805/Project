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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>()
            {
                new Contact{ FName = "nag", LName ="Duvvapu", DateofBirth = Convert.ToDateTime("1996-05-06").Date, 
                    EmailIds= new List<string>{"nage.@gmail.com", "nagu@gmail.com" }, PhNumbers= new List<string>{"8500506028", "7013796898" }},
                new Contact{ FName = "priya", LName ="Duvvapu", DateofBirth = Convert.ToDateTime("1996-05-06").Date,
                    EmailIds= new List<string>{"nage.@gmail.com", "nagu@gmail.com" }, PhNumbers= new List<string>{"8500506028", "7013796898" }}
            };
            listView.ItemsSource = contacts;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = listView.SelectedItem;
            SubWindow p = new SubWindow((Contact)item);
            p.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var Name = textBox.Text;
            string[] names = Name.Split(' ');
            if (names.Count() > 1)
                listView.ItemsSource = contacts.Where(x => x.FName.Equals(names[0], StringComparison.InvariantCultureIgnoreCase) && x.LName.Equals(names[1], StringComparison.InvariantCultureIgnoreCase));
            else
                MessageBox.Show("Please provide LastName and FirstName");

        }

    }
}
