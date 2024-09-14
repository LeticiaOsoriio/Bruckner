using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
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
using System.Windows.Shapes;

namespace Bruckner.Vistas
{
    //    la familia
    //
    //    Los escritos de aquellos días describen a sus habitantes como trabajadores, aplicados y de carácter alegre.Agricultores, artesanos, profesores y párrocos formaban una familia pueblerina que se sentía protegida por la iglesia y la parroquia.No obstante, también sabían enfrentarse a las preocupaciones de la vida con perseverancia“
    //[Leopold Nowak, Anton Bruckner.Musik und Leben]
    //    Anton Bruckner procedía de una familia de profesores.Su abuelo Joseph Bruckner (1749–1831), nacido en Oed, en Baja Austria, era profesor.
    //    Se trasladó a Ansfelden probablemente en 1776 y allá sucedió a su suegro, Sebastian Kletzer (1716-1776) como profesor de la escuela.
    //    Por motivos de salud, Joseph Bruckner cedió el puesto a su hijo Anton(1791-1837) en 1822.
    //La madre de Bruckner, Theresia Helm(1801-1860), procedía de Neuzeug, cerca de Sierning.
    //Sus padres, Johann Ferdinand(1769-1816) y Anna Maria(1773-1811), eran latifundistas y gestionaban un mesón.

    //    Ansfelden
    //Vista de la iglesia y la casa natal de Bruckner


    //    iNGLES

    //        family„Writings from that time portray its residents as industrious, busy, cheerful souls.Farmers, artisans, the schoolmaster and priest formed a village community which felt safe under the protection of the Church and vicarage.But which also knew how to face life's challenges with dogged persistence." “
    //[Leopold Nowak, Anton Bruckner.Musik und Leben] Anton Bruckner came from a family of teachers. His grand-father, Joseph Bruckner (1749–1831), born in Oed in Lower Austria, was a teacher
    //He probably moved to Ansfelden in 1776, where he became schoolmaster – following in the footsteps of his father-in-law, Sebastian Kletzer(1716–1776).
    //In 1822, Joseph Bruckner handed the job over to his son, Anton(1791–1837), due to illness.
    //Bruckner's mother, Theresia Helm (1801–1860), came from Neuzeug near Sierning.
    //Her parents, Johann Ferdinand(1769-1816) and Anna Maria(1773-1811), owned a lot of land and managed a public house.

//    Ansfelden
//View of the church and Bruckner's birthplace.

    /// <summary>
    /// Lógica de interacción para Familia.xaml
    /// </summary>
    public partial class Familia : Page
    {
        public Familia()
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
                    dict.Source = new Uri("..\\Recursos\\idioma\\FamiliaEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Recursos\\idioma\\FamiliaIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);

        }
    }
}
