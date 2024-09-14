using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
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
    //    „Al principio, todo el esplendor influyó en los sentimientos del muchacho solo de manera inconsciente; pasaría toda una vida hasta que su renacimiento creciera desde su alma en forma de arte imperecedero“
    //[Max Auer.Anton Bruckner.Sein Leben und Werk.]

    //    El monasterio de St.Florian de los canónigos agustinos es uno de los monasterios más importantes de Austria.Aquí la ciencia y el arte juegan un papel primordial desde tiempos inmemoriales y el monasterio dispone de colecciones valiosas y una notable biblioteca.
    //Bajo el mandato del abad David Fuhrmann, entre 1667 y 1689, empezó la barroquización del monasterio, que se ampliaría hasta convertirse en una joya artística única. Bajo el mandato del abad Johann Baptist Födermayr, entre 1716 y 1732, el monasterio obtuvo su propio teatro.
    //Con el órgano construido por Franz Xaver Krisman (1726-95), la iglesia del monasterio contaba con el mayor órgano de toda la monarquía del Danubio en los tiempos de Bruckner.

    //iNGLES 

    //    niño del coro en st.florian„
    //    Al principio, todo el esplendor influyó en los sentimientos del muchacho solo de manera inconsciente; pasaría toda una vida hasta que su renacimiento creciera desde su alma en forma de arte imperecedero“
    //[Max Auer.Anton Bruckner.Sein Leben und Werk.] El monasterio de St.Florian de los canónigos agustinos es uno de los monasterios más importantes de Austria.Aquí la ciencia y el arte juegan un papel primordial desde tiempos inmemoriales y el monasterio dispone de colecciones valiosas y una notable biblioteca.
    //Bajo el mandato del abad David Fuhrmann, entre 1667 y 1689, empezó la barroquización del monasterio, que se ampliaría hasta convertirse en una joya artística única. Bajo el mandato del abad Johann Baptist Födermayr, entre 1716 y 1732, el monasterio obtuvo su propio teatro.
    //Con el órgano construido por Franz Xaver Krisman (1726-95), la iglesia del monasterio contaba con el mayor órgano de toda la monarquía del Danubio en los tiempos de Bruckner.

    //Vista del monasterio de St.Florian

    /// <summary>
    /// Lógica de interacción para Coro.xaml
    /// </summary>
    public partial class Coro : Page
    {
        public Coro()
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
                    dict.Source = new Uri("..\\Recursos\\idioma\\CoroEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\Recursos\\idioma\\CoroIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);

        }
    }
}
