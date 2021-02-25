using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Visor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Cuenta> lista = new List<Cuenta>();

        private int contadorCuentas = 0;
        public bool identBotNueva = false;

        public MainWindow()
        {
            InitializeComponent();
            actualizarDatos();
        }

        private void actualizarDatos()
        {
            List<Cuenta> lista2 = new List<Cuenta>();
            Conexion.sql = "SELECT * FROM cuenta";

            MySqlCommand cmd = new MySqlCommand(Conexion.sql, Conexion.con);
            cmd.CommandTimeout = 60;

            try
            {
                Conexion.con.Open();

                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Cuenta c = new Cuenta();

                        c.setNumCuenta(rd.GetInt32("Numero"));
                        c.setTitular(rd.GetString("Titular"));
                        c.setFechaApertura(rd.GetString("Fecha_Apertura"));
                        c.setSaldo(rd.GetDouble("Saldo"));
                        c.setNacionalidad(rd.GetString("Nacionalidad"));

                        lista2.Add(c);
                    }
                }

                lista = lista2;

                txt_Numero.Text = Convert.ToString(lista[contadorCuentas].getNumCuenta());
                txt_Titulo.Text = lista[contadorCuentas].getTitular();
                txt_Nacionalidad.Text = lista[contadorCuentas].getNacionalidad();
                txt_Fecha.Text = Convert.ToString(lista[contadorCuentas].getFechaApertura());
                txt_Saldo.Text = Convert.ToString(lista[contadorCuentas].getSaldo());
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión", "Visor", MessageBoxButton.OK);
            }

            finally
            {
                Conexion.con.Close();
            }

        }

        private void btn_Siguiente_Click(object sender, RoutedEventArgs e)
        {
            if (contadorCuentas == (lista.Count) - 2)
            {
                identBotNueva = true;
                btn_Siguiente.Visibility = Visibility.Hidden;
                btn_Siguiente.IsEnabled = false;
                btn_Nueva.Visibility = Visibility.Visible;
                btn_Nueva.IsEnabled = true;
            }

            if (contadorCuentas < (lista.Count))
            {
                contadorCuentas++;
            }

            if (contadorCuentas > 0)
            {
                btn_Atras.Visibility = Visibility.Visible;
                btn_Atras.IsEnabled = true;
            }

            actualizarDatos();
        }

        private void btn_Atras_Click(object sender, RoutedEventArgs e)
        {
            if (identBotNueva)
            {
                btn_Siguiente.Visibility = Visibility.Visible;
                btn_Siguiente.IsEnabled = true;
                btn_Nueva.Visibility = Visibility.Hidden;
                btn_Nueva.IsEnabled = false;
                identBotNueva = false;
            }

            if (contadorCuentas > 0)
            {
                contadorCuentas--;
            }

            if (contadorCuentas == 0)
            {
                btn_Atras.Visibility = Visibility.Hidden;
                btn_Atras.IsEnabled = false;
            }

            actualizarDatos();
        }

        private void btn_Nueva_Click(object sender, RoutedEventArgs e)
        {
            label_etiExist.Visibility = Visibility.Hidden;
            label_etiNueva.Visibility = Visibility.Visible;

            txt_Numero.Clear();
            txt_Titulo.Clear();
            txt_Fecha.Clear();
            txt_Saldo.Clear();
            txt_Nacionalidad.Clear();

            txt_Numero.IsReadOnly = false;
            txt_Titulo.IsReadOnly = false;
            txt_Fecha.IsReadOnly = false;
            txt_Saldo.IsReadOnly = false;
            txt_Nacionalidad.IsReadOnly = false;

            btn_Nueva.Visibility = Visibility.Hidden;
            btn_Nueva.IsEnabled = false;

            btn_Atras.Visibility = Visibility.Hidden;
            btn_Atras.IsEnabled = false;

            btn_Aceptar.Visibility = Visibility.Visible;
            btn_Aceptar.IsEnabled = true;

            btn_Cancelar.Visibility = Visibility.Visible;
            btn_Cancelar.IsEnabled = true;
        }

        private void btn_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            txt_Numero.Background = Brushes.White;
            txt_Titulo.Background = Brushes.White;
            txt_Fecha.Background = Brushes.White;
            txt_Saldo.Background = Brushes.White;
            txt_Nacionalidad.Background = Brushes.White;

            bool isValid = true;

            if (!String.IsNullOrEmpty(txt_Numero.Text) && !isNumeric(txt_Numero.Text))
            {
                foreach (Cuenta cuenta in lista)
                {
                    if (int.Parse(txt_Numero.Text) == cuenta.getNumCuenta())
                    {
                        isValid = false;
                        txt_Numero.Background = Brushes.Red;
                    }
                }
            }
            else
            {
                isValid = false;
                txt_Numero.Background = Brushes.Red;
            }

            if (!String.IsNullOrEmpty(txt_Titulo.Text))
            {
                if (!isNumeric(txt_Titulo.Text))
                {
                    isValid = false;
                    txt_Titulo.Background = Brushes.Red;
                }
            }
            else
            {
                isValid = false;
                txt_Titulo.Background = Brushes.Red;
            }

            if (!String.IsNullOrEmpty(txt_Fecha.Text))
            {
                if (!validDate(txt_Fecha.Text))
                {
                    isValid = false;
                    txt_Fecha.Background = Brushes.Red;
                }
            }
            else
            {
                isValid = false;
                txt_Fecha.Background = Brushes.Red;
            }

            if (!String.IsNullOrEmpty(txt_Saldo.Text))
            {
                if (isNumeric(txt_Saldo.Text))
                {
                    isValid = false;
                    txt_Saldo.Background = Brushes.Red;
                }
            }
            else
            {
                isValid = false;
                txt_Saldo.Background = Brushes.Red;
            }

            if (!String.IsNullOrEmpty(txt_Nacionalidad.Text))
            {
                if (!isNumeric(txt_Nacionalidad.Text))
                {
                    isValid = false;
                    txt_Nacionalidad.Background = Brushes.Red;
                }
            }
            else
            {
                isValid = false;
                txt_Nacionalidad.Background = Brushes.Red;
            }

            if (isValid)
            {
                Conexion.sql = "INSERT INTO CUENTA (Numero, Titular, Fecha_Apertura, Saldo, Nacionalidad) VALUES (@numero, @titular, @fecha, @saldo, @nacionalidad)";
                MySqlCommand cmd = new MySqlCommand(Conexion.sql, Conexion.con);

                Conexion.con.Open();

                try
                {

                    cmd.Parameters.AddWithValue("@numero", txt_Numero.Text);
                    cmd.Parameters.AddWithValue("@titular", txt_Titulo.Text);
                    cmd.Parameters.AddWithValue("@fecha", txt_Fecha.Text);
                    cmd.Parameters.AddWithValue("@saldo", txt_Saldo.Text);
                    cmd.Parameters.AddWithValue("@nacionalidad", txt_Nacionalidad.Text);
                    cmd.ExecuteNonQuery();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al establecer la conexión", "Visor", MessageBoxButton.OK);
                }

                finally
                {
                    Conexion.con.Close();
                }

                contadorCuentas++;

                label_etiNueva.Visibility = Visibility.Hidden;
                label_etiExist.Visibility = Visibility.Visible;

                txt_Numero.IsReadOnly = true;
                txt_Titulo.IsReadOnly = true;
                txt_Fecha.IsReadOnly = true;
                txt_Saldo.IsReadOnly = true;
                txt_Nacionalidad.IsReadOnly = true;

                btn_Aceptar.Visibility = Visibility.Hidden;
                btn_Aceptar.IsEnabled = false;

                btn_Cancelar.Visibility = Visibility.Hidden;
                btn_Cancelar.IsEnabled = false;

                btn_Atras.Visibility = Visibility.Visible;
                btn_Atras.IsEnabled = true;

                btn_Nueva.Visibility = Visibility.Visible;
                btn_Nueva.IsEnabled = true;
            }

        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            label_etiExist.Visibility = Visibility.Visible;
            label_etiNueva.Visibility = Visibility.Hidden;

            txt_Numero.Background = Brushes.White;
            txt_Titulo.Background = Brushes.White;
            txt_Fecha.Background = Brushes.White;
            txt_Saldo.Background = Brushes.White;
            txt_Nacionalidad.Background = Brushes.White;

            txt_Numero.IsReadOnly = true;
            txt_Titulo.IsReadOnly = true;
            txt_Fecha.IsReadOnly = true;
            txt_Saldo.IsReadOnly = true;
            txt_Nacionalidad.IsReadOnly = true;

            actualizarDatos();

            btn_Aceptar.Visibility = Visibility.Hidden;
            btn_Aceptar.IsEnabled = false;

            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Cancelar.IsEnabled = false;

            btn_Atras.Visibility = Visibility.Visible;
            btn_Atras.IsEnabled = true;

            btn_Nueva.Visibility = Visibility.Visible;
            btn_Nueva.IsEnabled = true;
        }

        public bool isNumeric(String strNum)
        {
            if (strNum == null)
            {
                return false;
            }

            try
            {
                Convert.ToDouble(strNum);
            }
            catch (FormatException nfe)
            {
                return true;
            }

            return false;
        }

        public bool validDate(String fecha)
        {
            DateTime date;
            
            if (DateTime.TryParse(txt_Fecha.Text, out date))
            {
                return true;
            }
            else
            {
                return false;
            }

            return false;
        }
    }
}
