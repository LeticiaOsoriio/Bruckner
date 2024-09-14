using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.AccessControl;
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
using System.Windows.Shapes;

namespace Bruckner.Vistas
{
    //    Un profesor de escuela rural vivía normalmente en condiciones modestas en el siglo XIX.
    //Además del mísero sueldo, recibían algunos pagos en especie, entre ellos el alojamiento en el edificio de la escuela. Aparte de la actividad docente en clases únicas, a veces con clases de noventa estudiantes o más, el profesor tenía que ocuparse también del servicio eclesiástico y gestionaba una pequeña granja para mejorar su escaso sueldo.
    //La enseñanza era obligatoria hasta los 12 años y se enseñaba lectura, escritura, cálculo y religión.Un objetivo declarado era la educación religiosa y moral de los alumnos

    //Linz, iglesia parroquial, a la derecha la casa del sacristán

//    iNGLES
//        student in Linz
//        In the 19th century, most rural school teachers lived in modest circumstances.
//As well as a meagre salary, they also received some payment in kind, including free accommodation in the school building.In addition to their teaching duties in the single classes which sometimes comprised ninety or more pupils, teachers also had to organise church services and run small farms to supplement their paltry pay.
//Education was compulsory until the age of twelve, and the curriculum included reading, writing, arithmetic and religion.Its stated objective was the religious and moral education of pupils.

    //Linz, parish church, with the sacristan house to the right

    /// <summary>
    /// Lógica de interacción para Alumno.page
    /// </summary>
    public partial class Alumno : Page
    {
        public Alumno()
        {
            InitializeComponent();
        }
    }
}
