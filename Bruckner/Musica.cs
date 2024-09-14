using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruckner
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Media;

    //            "Alumno",
    //            "Biografia1",
    //            "Compositor",
    //            "Coro",
    //            "Crisis",
    //            "Familia",
    //            "forschung",
    //            "Galeria",
    //            "Imagen",
    //            "Literatura",
    //            "Muerte",
    //            "Obras",
    //            "Organista",
    //            "Profesor",
    //            "Trabajo",
    //            "Viajes",
    //            "Viena"


    namespace Beethoven
    {
        public class Musica
        {
            MediaPlayer mediaPlayer;
            public Musica()
            {
                mediaPlayer = new MediaPlayer();
            }
            public void Pagina(string tag)
            {
                switch (tag)
                {
                    case "Biografia1":
                        PlayMenuAudio("01");
                        break;
                    case "Familia":
                        PlayMenuAudio("2");
                        break;
                    case "Coro":
                        PlayMenuAudio("Coro");
                        break;
                    case "Profesor":
                        PlayMenuAudio("Profesor");
                        break;
                    case "Crisis":
                        PlayMenuAudio("Crisis");
                        break;
                    case "Viajes":
                        PlayMenuAudio("Viaje");
                        break;
                    case "Muerte":
                        PlayMenuAudio("Muerte");
                        break;
                    case "Compositor":
                        PlayMenuAudio("Compositor");
                        break;
                    case "Trabajo":
                        PlayMenuAudio("Trabajo");
                        break;
                    case "Imagen":
                        PlayMenuAudio("Imagen");
                        break;
                    default:
                        mediaPlayer.Stop();
                        break;
                }
            }

            private void PlayMenuAudio(string audio)
            {
                mediaPlayer.Stop();

                if (SessionManager.CurrentLanguage != "es-ES")
                {
                    audio = $"{audio}En.mp3";
                }
                else
                {
                    audio = $"{audio}Es.mp3";
                }
                // Ruta del recurso menu.mp3 en el proyecto
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;


                // Ruta completa al archivo menu.mp3 (asumiendo que está en Recursos/audio/Spanisch relativo al ejecutable)
                string audioFilePath = Path.Combine(exeDirectory, @"Recursos\audio\" + audio);

                // Cargar y reproducir el archivo de audio
                mediaPlayer.Open(new Uri(audioFilePath, UriKind.Absolute));
                mediaPlayer.Play();
            }
        }

    }


}