using Microsoft.VisualBasic.Logging;
using pryLopezEtapa3;
using System.Collections.Generic;

namespace pryLopezEtapa4
{
    public partial class frmVehiculos : Form
    {
        /*Etapa 4 - CREAR OBJETOS EN LISTA
        Reutilizar la clase clsVehiculo
        Crear vehículos cada vez que pulse en el botón que corresponde al tipo vehículo.
        DEBE CREAR LOS OBJETOS, dentro de una estructura LIST.
        https://www.c-sharpcorner.com/article/c-sharp-list/ 
        Desde un botón “listar” mostrar todos los objetos por su nombre.*/

        private clsVehiculo auto;
        private clsVehiculo barco;
        private clsVehiculo avion;
        public frmVehiculos()
        {
            InitializeComponent();
            InitializeComponent();
            auto = new clsVehiculo("Auto", "Auto", Properties.Resources.auto);
            barco = new clsVehiculo("Barco", "Barco", Properties.Resources.barco);
            avion = new clsVehiculo("Avion", "Avion", Properties.Resources.avion);
        }
        private void MostrarVehiculo(clsVehiculo vehiculo)
        {
            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            MostrarVehiculo(avion);
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {

            MostrarVehiculo(barco);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

            MostrarVehiculo(auto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
