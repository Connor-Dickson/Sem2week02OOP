using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> ToDos { get; set; }

        public bool CurrentEdit = false;
        public MainWindow()
        {
            InitializeComponent();
            ToDos = new ObservableCollection<string>();

            this.ListBox.ItemsSource = ToDos;
        }

        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentEdit == false)
            {
                ToDos.Add(Text_Entry.Text.ToString());
                Text_Entry.Text = "";
            }
            else if (CurrentEdit == true)
            {
                ToDos[ListBox.SelectedIndex] = Text_Entry.Text;
                CurrentEdit = false;
                ListBox.UpdateLayout();
            }
           
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            
            ToDos.RemoveAt(ListBox.SelectedIndex);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CurrentEdit = true;
                Text_Entry.Text = ListBox.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please Select an Item to Edit");
            }
            
        }
    }
}
