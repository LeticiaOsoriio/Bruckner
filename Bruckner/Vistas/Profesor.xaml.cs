using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
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

namespace Bruckner.Vistas
{ 
    //    El tiempo señala a un oficio que poco vale, pero que todos aprovechan, ¡qué pena! A algunos aquí ni se los respeta ni se los ayuda, ¿no sabéis qué oficio es? es el honrado oficio de profesor“
    //[Anton Bruckner.Der Lehrerstand(WAB 77) (El oficio de profesor). Coro masculino a cuatro voces(alrededor de 1847)]

    ////    Después de acudir al Präparandie en los años 1840-41, Bruckner aceptó un puesto como asistente en Windhaag bei Freistadt en 1841.
    ////En el distante pueblo de Mühlviertel llevaba una existencia extremadamente modesta.Además de las clases, tenía que trabajar en el campo y, en su escaso tiempo libre, aumentaba sus ingresos como músico de entretenimiento y baile en los mesones de los alrededores.
    ////Aquí nació la misa de Bruckner en do mayor para contralto, 2 trompas y órgano (WAB 25).

    //Windhaag.Antiguo edificio de la escuela

////    iNGLES

////        Bruckner as a teacher
//„It is referred to as a profession, which is acknowledged by few, but benefits everyone, unfortunately! Some people in this country neither honour nor support it, is this profession unknown to you? The brave teaching profession “

////[Anton Bruckner, Der Lehrerstand (WAB 77), four-part men's choir (around 1847)]
///After attending the Präparandie in 1840/41, Bruckner took a job as assistant teacher in Windhaag near Freistadt in 1841.
////He led an extremely modest existence in the remote village in Mühlviertel. As well as teaching, he had to work in the fields, and supplemented his income as an entertainment and dance musician in the region's public houses in what little spare time he had.
////This is where Bruckner wrote his Mass in C major for alto solo, 2 horns and organ (WAB 25).

    //Windhaag, Old school house

    /// <summary>
    /// Lógica de interacción para Profesor.xaml
    /// </summary>
    public partial class Profesor : Page
    {
        public Profesor()
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
                    dict.Source = new Uri("..\\Recursos\\idioma\\ProfesorEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Recursos\\idioma\\ProfesorIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);

        }
    }
}
