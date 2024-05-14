using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Clase base Jugador
namespace HerenciaEjercicio1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioJugador());
        }
    }
}

class Jugador
{
    public int NumeroUniforme { get; set; }
    public string Nombre { get; set; }
    public string Posicion { get; set; }

    // Constructor de la clase base
    public Jugador(int numeroUniforme, string nombre, string posicion)
    {
        NumeroUniforme = numeroUniforme;
        Nombre = nombre;
        Posicion = posicion;
    }
}

// Clase derivada JugadorCampo
class JugadorCampo : Jugador
{
    public int GolesAnotados { get; set; }
    public int MinutosJugados { get; set; }

    // Constructor de la clase JugadorCampo
    public JugadorCampo(int numeroUniforme, string nombre, string posicion, int golesAnotados, int minutosJugados)
        : base(numeroUniforme, nombre, posicion)
    {
        GolesAnotados = golesAnotados;
        MinutosJugados = minutosJugados;
    }
}

// Clase derivada Portero
class Portero : Jugador
{
    // Constructor de la clase Portero
    public Portero(int numeroUniforme, string nombre, string posicion)
        : base(numeroUniforme, nombre, posicion)
    {
        // No hay datos adicionales específicos para el portero
    }
}


