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
using System.Windows.Shapes;

namespace SakkTabla
{
    /// <summary>
    /// Interaction logic for Tabla.xaml
    /// </summary>
    public partial class Tabla : Window
    {
        public Tabla(int m,int n)
        {
            InitializeComponent();
            for(int i = 0; i < n; i++) 
            {
                grdTablazat.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < m; i++)
            {
                grdTablazat.RowDefinitions.Add(new RowDefinition());
            }

            Button[,] mezok = new Button[8, 8];

            for (int i = 0; i < m; i++)
            {
                for (int o = 0; o < n; o++)
                {
                    Button gomb = new Button();
                    gomb.Background = new SolidColorBrush(Colors.AliceBlue);

                    Grid.SetColumn(gomb, i);
                    Grid.SetRow(gomb, o);

                    grdTablazat.Children.Add(gomb);
                }
            }
        }
    }
}
