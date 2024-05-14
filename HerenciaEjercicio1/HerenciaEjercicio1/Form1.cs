using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerenciaEjercicio1;

namespace HerenciaEjercicio1
{

    public partial class FormularioJugador : Form
    {

        private JugadorCampo jugadorCampo;
        private bool datosCapturados = false;

       public FormularioJugador()
        {
            InitializeComponent();
        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                int numeroUniforme = int.Parse(txtNumeroUniforme.Text);
                string nombre = txtNombre.Text;
                int minutosJugados = int.Parse(txtMinutosJugados.Text);
                int golesAnotados = int.Parse(txtGolesAnotados.Text);
                string posicion = ObtenerPosicionSeleccionada();
                

                //crear un nuevo jugador de campo con los datos ingresados
                jugadorCampo = new JugadorCampo(numeroUniforme, nombre, posicion, golesAnotados, minutosJugados);
                //indicar que se han capturado datos
                datosCapturados = true;

                MessageBox.Show("Datos capturados correctamente.");
            }
            catch (FormatException) 
            {
                MessageBox.Show("Porfavor, ingrese datos correctos en todos los campos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void txtDetalles_TextChanged(object sender, EventArgs e)
        {

        }

       

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//Salir de la aplicacion
        }

        
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ///////////////////////////////////
        /// </summary>

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if(datosCapturados)
            {
               listBox1.Items.Clear();

                //agregar los datos del jugador de campo el listBOX
                listBox1.Items.Add($"Número de Uniforme: {jugadorCampo.NumeroUniforme}");
                listBox1.Items.Add($"Nombre: {jugadorCampo.Nombre}");
                listBox1.Items.Add($"Posición: {jugadorCampo.Posicion}");
                listBox1.Items.Add($"Minutos Jugados: {jugadorCampo.MinutosJugados}");
                listBox1.Items.Add($"Goles Anotados: {jugadorCampo.GolesAnotados}");
            }
            else
            {
                MessageBox.Show("No se han campurado datos.");
            }
        }
        //Evento del checkBox para seleccionar la posicion de los jugadores
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                LimpiarCampos();
              
            }
        }
        
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
          
            txtNumeroUniforme.Text = "";
            txtNombre.Text = "";
            txtMinutosJugados.Text = "";
            txtGolesAnotados.Text = "";
        }
        private string ObtenerPosicionSeleccionada()
        {
            if (checkDelantero.Checked)
            {
                return "Delantero";
            }
            else if (checkMedio.Checked)
            {
                return "Medio";
            }
            else if (checkDefensa.Checked)
            {
                return "Defensa";
            }
            else if (checkPortero.Checked)
            {
                return "Portero";
            }
            else
            {
                return "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

   

}

    

