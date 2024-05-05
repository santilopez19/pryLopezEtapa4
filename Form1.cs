using Microsoft.VisualBasic.Logging;
using pryLopezEtapa3;
using System.Collections.Generic;

namespace pryLopezEtapa4
{
    public partial class frmVehiculos : Form
    {
        /*Etapa 4 - CREAR OBJETOS EN LISTA
        Reutilizar la clase clsVehiculo
        Crear veh�culos cada vez que pulse en el bot�n que corresponde al tipo veh�culo.
        DEBE CREAR LOS OBJETOS, dentro de una estructura LIST.
        https://www.c-sharpcorner.com/article/c-sharp-list/ 
        Desde un bot�n �listar� mostrar todos los objetos por su nombre.*/

        private List<clsVehiculo> vehiculos; // Lista para almacenar los veh�culos

        private clsVehiculo auto;
        private clsVehiculo barco;
        private clsVehiculo avion;
        public frmVehiculos()
        {
            InitializeComponent();

            auto = new clsVehiculo("Auto", "Auto", Properties.Resources.auto);
            barco = new clsVehiculo("Barco", "Barco", Properties.Resources.barco);
            avion = new clsVehiculo("Avion", "Avion", Properties.Resources.avion);

            // Inicializa la lista de veh�culos
            vehiculos = new List<clsVehiculo>();

            // No necesitas inicializar los veh�culos aqu�
        }

        // M�todo para mostrar un veh�culo en el PictureBox
        private void MostrarVehiculo(clsVehiculo vehiculo)
        {
            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Evento para el bot�n Listar

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            // Mostrar los nombres de todos los veh�culos en un ListBox
            lstVehiculos.Items.Clear();
            foreach (clsVehiculo vehiculo in vehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.Nombre);
            }
        }

        private void btnAuto_Click_1(object sender, EventArgs e)
        {

            // Crea un nuevo objeto clsVehiculo y agr�galo a la lista
            clsVehiculo auto = new clsVehiculo("Auto", "Auto", Properties.Resources.auto);
            vehiculos.Add(auto);
            MostrarVehiculo(auto); // Muestra la imagen del auto
        }

        private void btnAvion_Click_1(object sender, EventArgs e)
        {

            // Crea un nuevo objeto clsVehiculo y agr�galo a la lista
            clsVehiculo avion = new clsVehiculo("Avion", "Avion", Properties.Resources.avion);
            vehiculos.Add(avion);
            MostrarVehiculo(avion); // Muestra la imagen del avi�n
        }

        private void btnBarco_Click_1(object sender, EventArgs e)
        {

            // Crea un nuevo objeto clsVehiculo y agr�galo a la lista
            clsVehiculo barco = new clsVehiculo("Barco", "Barco", Properties.Resources.barco);
            vehiculos.Add(barco);
            MostrarVehiculo(barco); // Muestra la imagen del barco
        }
    }
}
