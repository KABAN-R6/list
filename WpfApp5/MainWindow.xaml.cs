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
using System.Windows.Ink;
using System.Collections.ObjectModel;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<zadah> zadahs;
        List<zadah> activezadah;
        List<zadah> completzadah;
        public MainWindow()
        {
            InitializeComponent();
            zadahs = new List<zadah>() 
            {
                new zadah("dvsdsv",Status.Active),
                 new zadah("dvasfasfasfasf",Status.Completed)
            };
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tx1.Text == "" || tx1.Text == null)
            {

            }
            zadahs.Add(new zadah(tx1.Text, Status.Active));
            Update();
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
           
        }

        private void list2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
           
        }

        private void list1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (list1.SelectedItem == null) return;
            var b = zadahs.FindIndex(u => u == list1.SelectedItem);
            zadahs[b].status = Status.Completed;
            Update();
        }
        public void Update()
        {
            activezadah = zadahs.Where(u => u.status == Status.Active).ToList();
            completzadah = zadahs.Where(u => u.status == Status.Completed).ToList();
            list1.ItemsSource = activezadah;
            list2.ItemsSource = completzadah;
        }

        private void list2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (list2.SelectedItem == null) return;
            foreach(var note in list2.SelectedItems)
            {
                zadahs.Remove((zadah)note);
            }

            Update();
        }
    }
}
