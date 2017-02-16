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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private int i = -1;
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /*private void Make_new(object sender, RoutedEventArgs e)
        {
            //int max_row = 2;
            //int max_col = 3;
            this.i += 1;
            int row;
            int col;
            row = Grid.GetRow(this.Add);
            col = Grid.GetColumn(this.Add);
            if (col != 2)
            {
                Button a = new Button();
                Grid.SetRow(a, row);
                Grid.SetColumn(a, col);
                Grid.SetColumn(this.Add, col + 1);
                a.Content = "New Gesture";
                a.Width = 80;
                a.Height = 80;
                MyGrid.Children.Add(a);

            }

            else if (col == 2)
            {
                Button a = new Button();
                Grid.SetRow(a, row);
                Grid.SetColumn(a, col);
                a.Content = "New Gesture";
                a.Width = 80;
                a.Height = 80;
                MyGrid.Children.Add(a);

                Grid.SetRow(this.Add, row + 1);
                Grid.SetColumn(this.Add, 0);

            }

        }*/

        public void Page_2_load(object sender, RoutedEventArgs e)
        {
            this.App_name.Text = "Spotify";
            Just_one_frame.Content = new Page2();
        }
        public void Page_1_load()
        {
            this.App_name.Text = "VLC";
            Just_one_frame.Content = new Page1();
        }
        //private int r = 1;
        public void Add_App(object sender, RoutedEventArgs e)
        {
            Button newapp = new Button();
            newapp.Content = "VLC";
            newapp.Background = Brushes.RoyalBlue;
            newapp.Foreground = Brushes.Aqua;
            //this.newapp.Click += new System.EventHandler(this.Page_1);


            MyPanel.Children.Add(newapp);
            this.Page_1_load();

        }
    }
    public partial class Page1:Page
    {
        /*public Page1()
        {
            this.InitializeComponent();
        }*/
        private void Make_new(object sender, RoutedEventArgs e)
        {
            //int max_row = 2;
            //int max_col = 3;
            //this.i += 1;
            int row;
            int col;
            row = Grid.GetRow(this.Add);
            col = Grid.GetColumn(this.Add);
            if (col != 2)
            {
                Button a = new Button();
                Grid.SetRow(a, row);
                Grid.SetColumn(a, col);
                Grid.SetColumn(this.Add, col + 1);
                a.Content = "New Gesture";
                a.Width = 150;
                a.Height = 150;
                SecGrid.Children.Add(a);

            }

            else if (col == 2)
            {
                Button a = new Button();
                Grid.SetRow(a, row);
                Grid.SetColumn(a, col);
                a.Content = "New Gesture";
                a.Width = 150;
                a.Height = 150;
                SecGrid.Children.Add(a);

                Grid.SetRow(this.Add, row + 1);
                Grid.SetColumn(this.Add, 0);

            }
        }
        
    }
    public partial class Page2:Page
    {
        private void Make_new(object sender, RoutedEventArgs e)
        {
            //int max_row = 2;
            //int max_col = 3;
            //this.i += 1;
            int row;
            int col;
            row = Grid.GetRow(this.Add);
            col = Grid.GetColumn(this.Add);
            if (col != 2)
            {
                Button a = new Button();
                Grid.SetRow(a, row);
                Grid.SetColumn(a, col);
                Grid.SetColumn(this.Add, col + 1);
                a.Content = "New Gesture";
                a.Width = 150;
                a.Height = 150;
                ThirdGrid.Children.Add(a);

            }

            else if (col == 2)
            {
                Button a = new Button();
                Grid.SetRow(a, row);
                Grid.SetColumn(a, col);
                a.Content = "New Gesture";
                a.Width = 150;
                a.Height = 150;
                ThirdGrid.Children.Add(a);

                Grid.SetRow(this.Add, row + 1);
                Grid.SetColumn(this.Add, 0);

            }



        }
    }

 }
