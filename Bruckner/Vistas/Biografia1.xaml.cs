using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
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

namespace Bruckner.Vistas
{
    //    hogar paterno e infancia„A menudo, los espíritus redentores nacen donde menos se los espera“
    //[August Göllerich/Max Auer, Anton Bruckner]
    //Anton Bruckner nació el 4 de septiembre de 1824 como hijo mayor del profesor de escuela Anton Bruckner(1791-1837) y su esposa Theresia(1801-1860), nacida Helm, en el edificio de profesores(hoy, el Museo de Anton Bruckner de Ansfelden) en Ansfelden, Alta Austria.
    //Siguiendo la costumbre, el día de su nacimiento fue bautizado con el nombre de Joseph Anton y su madrina fue Rosalia Mayrhofer, su tía abuela por parte de madre, que trabajaba como ama de llaves en la parroquia de la cercana Wolfern.
    //Extracto del libro bautismal de la parroquia de Ansfelden, con la entrada del bautismo de Bruckner


    //    Ingles
    //        parental home and childhood
    //        „Redeeming spirits are often born where they are least expected. “
    //[August Göllerich/Max Auer, Anton Bruckner.Ein Lebens- und Schaffensbild.]

    //    Anton Bruckner was born on 4 September 1824 as the eldest son of schoolmaster, Anton Bruckner(1791-1837) and his wife Theresia(1801-1860), nee Helm, in the schoolmaster's house (now the Anton Bruckner Museum) in Ansfelden in Upper Austria
    //As was then customary, he was baptised Joseph Anton on the day he was born, and his Godmother was Rosalia Mayrhofer, his maternal great-aunt who worked as a housekeeper at the vicarage in nearby Wolfern.

    //Extract from the Ansfelden parish register, showing Bruckner's baptism entry

    /// <summary>
    /// Lógica de interacción para Biografia1.xaml
    /// </summary>
    public partial class Biografia1 : Page
    {
        public Biografia1()
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
                    dict.Source = new Uri("..\\Recursos\\idioma\\BiografiaEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Recursos\\idioma\\BiografiaIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);

        }
    }
}
