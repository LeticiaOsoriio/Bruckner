using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bruckner.Vistas
{
    //    „Vayamos a Rusia y adonde sea, si en la patria no nos quieren conocer.Ya ves en qué punto de satisfacción me encuentro y cómo amo a los habitantes de Linz por semejante reconocimiento“
    //[Bruckner a su amigo Rudolf Weinwurm, el 18 de octubre de 1864.]

    //    Bruckner se daba cada vez más cuenta de que tampoco Linz le ofrecía perspectivas en el aspecto artístico.
    //Desesperado, buscó otras oportunidades de desarrollo y se interesó, entre otros, por un puesto como músico en la capilla de la Corte del emperador Maximiliano I en México.
    //Bruckner dedicó un tiempo de su vida al destino de Maximiliano, quien fue ejecutado en 1867 en México tras una desdichada regencia, y leyó todos los informes que tuvieran que ver con el emperador y México.

    //Vista de la catedral de México

    //    iNGLES
    //        crisis years
    //
    //        „Let us go to Russia or somewhere, if no-one in the Fatherland wants to recognise us.You will see how satisfied I am and how I will love the people of Linz as a result of such recognition."“
    //[Bruckner to his friend, Rudolf Weinwurm, 18 October 1864.] Bruckner increasingly recognised that Linz offered him no musical prospects.

    //He desperately sought development opportunities and applied for positions such as that of musician in the Court Orchestra of Emperor Maximilian I in Mexico.

    //The fate of Maximilian, who was executed in Mexico in 1867 following an unhappy reign, fascinated Bruckner throughout his life and he read any reports concerning Maximilian and Mexico.

    //View of the Cathedral of Mexico

    /// <summary>
    /// Lógica de interacción para Crisis.xaml
    /// </summary>
    public partial class Crisis : Page
    {
        public Crisis()
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
                    dict.Source = new Uri("..\\Recursos\\idioma\\CrisisEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Recursos\\idioma\\CrisisIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);

        }
    }
}
