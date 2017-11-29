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
using System.Data.SqlClient;
using System.Data;

namespace Estados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private object DataGridEstados;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Estados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void BUSCAR_Click(object sender, RoutedEventArgs e)
        {
            string CadenaDeConexion = @"Data Source=DESKTOP-BDSL3Q9;Initial Catalog=Municipios;Integrated Security=True";
            string sql = "select * from Estado";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(CadenaDeConexion);
            SqlDataAdapter datos = new SqlDataAdapter();
            datos.SelectCommand = new SqlCommand(sql, conexion);
            datos.Fill(tabla);
            Estados.DataContext = tabla;
            conexion.Close();
        }
    }
}
