using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Bruckner.Vistas
{
    //    Viena estaba considerada en el siglo XIX como centro importante de la conservación de la música y del arte en general.Las posibilidades de la ciudad imperial atraían a artistas de todas partes del imperio, que esperaban conseguir inspiración, desarrollo y carrera en el espíritu fértil del mundo artístico.
    //La identidad musical estaba caracterizada por la esencia de Mozart, Haydn, Beethoven y Schubert, así como por los estrenos de las obras más importantes de la historia de la música. En la época de Bruckner se habían establecido varias instituciones musicales importantes en Viena:
    //la Sociedad de Amigos de la Música (Gesellschaft der Musikfreunde), fundada en 1812; la Filarmónica de Viena(establecida como Philharmonische Konzertunternehmung), creada en 1842; la Asociación de cantantes masculinos de Viena(Wiener Männergesangverein), fundada en 1843; la Asociación de cantantes de la Sociedad de Amigos de la Música(Sängervereinigung der Gesellschaft der Musikfreunde), creada en 1858; la Academia de canto(Singakademie), instituida en 1858; la Asociación académica de canto(Akademischer Gesangverein), formada en 1858; y la Unión de Schubert(Schubertbund), fundada en 1863.

    //Viena, edificio de la Sociedad de Amigos de la Música, Goldener Saal

//    Ingles
//        Bruckner in Vienna
        
//        In the 19th century, Vienna was considered to be an important centre of music culture and of art in general.The opportunities in the imperial city attracted artists from all areas of the Empire, hoping to find inspiration, development and careers in its fertile art world.
//The city's musical identity was shaped by the spirit of Mozart, Haydn, Beethoven and Schubert and premieres of some of the most significant works in musical history. In Bruckner's time, several important musical institutions were established in Vienna:
//the Gesellschaft der Musikfreunde founded in 1812, the Vienna Philharmonic Orchestra founded in 1842, the Wiener Männergesangverein (founded in 1843), the Sängervereinigung der Gesellschaft der Musikfreunde(founded in 1858), the Singakademie(founded in 1858), the Akademischen Gesangverein(founded in 1858) and the Schubertbund(founded in 1863)

    //Wien, Gesellschaft der Musikfreunde building, Goldener Saal
    /// <summary>
    /// Lógica de interacción para Viena.xaml
    /// </summary>
    public partial class Viena : Page
    {
        public Viena()
        {
            InitializeComponent();
            LoadLanguage(SessionManager.CurrentLanguage);
        }


        private void LoadLanguage(string cultureCode)
        {
            // Crear nueva cultura
            var cultureInfo = new CultureInfo(cultureCode);

            // Cambiar el idioma del hilo actual
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Limpiar los diccionarios de recursos existentes

            // Cargar el diccionario de recursos correspondiente al idioma seleccionado
            var dict = new ResourceDictionary();
            switch (cultureCode)
            {
                case "es-ES":
                    dict.Source = new Uri("..\\Recursos\\idioma\\VienaEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Recursos\\idioma\\VienaIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);

        }
    }
}
