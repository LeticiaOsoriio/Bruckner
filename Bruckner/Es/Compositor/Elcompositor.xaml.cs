using Bruckner.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bruckner.Es.Compositor
{
    //el compositor elogiado

    //    „Ayer(Viernes Santo) dirigí su grandioso y poderoso 'Te Deum'. Tanto los músicos como todo el público estaban profundamente conmovidos por la formidable obra y el verdaderamente elevado pensamiento, y yo viví al final de la representación lo que considero el mayor triunfo de una obra: el público permaneció sentado y en silencio, sin moverse, y no fue hasta después de que el director y los músicos dejaran sus asientos que rompieron los aplausos.“
    //[Gustav Mahler(1869 - 1911) desde Hamburgo a Bruckner, el 16 de abril de 1892.]

    //    Bruckner cosechaba grandes éxitos como compositor y sus obras se tocaban tanto dentro como fuera del país.Su cortejo triunfal como creador, distinguido entretanto numerosas veces con homenajes, era imparable.
    //El interés de Anton Bruckner se centraba originalmente en la música eclesiástica pero, con su traslado a Viena y un nuevo campo de actividad artística, su creación compositiva cambió totalmente a la sinfonía y al terreno laico.
    //Bruckner compuso once sinfonías en total, de las cuales diez están íntegras y mayormente en varias versiones.Solo la última de las enumeradas, la sinfonía n.º 9 (WAB 109), quedó inacabada y del último movimiento solo existen fragmentos.Una «sinfonía de estudio» (Studiensymphonie) del año 1863 y una sinfonía «anulada» por Bruckner(WAB 100) se excluyeron del recuento consecutivo.Bruckner no consideraba estas composiciones como dignas, por lo que se representaron por primera vez póstumamente en 1900

    //Ingles 

////    the acclaimed composer
////        „Yesterday(Good Friday), I conducted your splendid and magnificent "Te Deum". Both the musicians and the entire audience were deeply moved by its impressive setting and truly sublime ideas, and at the end of the performance, I experienced something I consider to be the greatest triumph of a work: the audience remained sitting silently, without moving, and only after the conductor and musicians[had] left their seats, did the thunderous applause break out.“
////[Gustav Mahler(1869 - 1911) from Hamburg to Bruckner, 16 April 1892. ] Bruckner enjoyed huge success as a composer; his works were performed at home and abroad.His triumphant success as a composer was unstoppable, and has since been awarded many honours.
////Anton Bruckner's original focus was church music; but with his move to Vienna and a new artistic arena, the entirety of his compositional work shifted to symphonies and secular music.
////Bruckner composed a total of eleven symphonies, ten of which are complete and for the most part available in several versions. Only the last one, the (numbered) Ninth Symphony (WAB 109), remains incomplete, with only part of its finale available.Bruckner's Study Symphony written in 1863 and "Annulled" Symphony (WAB 100) are excluded from the consecutive numbering. Bruckner did not consider either composition to be good enough, so they were only first performed in 1900, after his death.
    
        /// <summary>
    /// Lógica de interacción para Elcompositor.xaml
    /// </summary>
    public partial class Elcompositor : Window
    {
        public Elcompositor()
        {
            InitializeComponent();
        }
    }
}
