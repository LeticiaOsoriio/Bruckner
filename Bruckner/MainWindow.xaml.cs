using System.Globalization;
using System.Text;
using System.IO;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;


namespace Bruckner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer;
        private string[] audioFiles;
        private int currentFileIndex = 0;
        private DispatcherTimer _inactivityTimer;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            this.WindowState = WindowState.Maximized;
            this.ResizeMode = ResizeMode.NoResize;
            // this.Topmost = true;

            //mediaPlayer = new MediaPlayer();

            // Reproducir el archivo menu.mp3 al iniciar la aplicación
            

            SessionManager.CurrentLanguage = "es-ES";
            LoadLanguage(SessionManager.CurrentLanguage);
          //  PlayMenuAudio();
            Tit2.Selected += TreeViewItem_Selected;
            Tit3.Selected += TreeViewItem_Selected;
            Tit4.Selected += TreeViewItem_Selected;
            Tit5.Selected += TreeViewItem_Selected;
            Tit7.Selected += TreeViewItem_Selected;
            Tit8.Selected += TreeViewItem_Selected;
            Tit9.Selected += TreeViewItem_Selected;
            Tit10.Selected += TreeViewItem_Selected;
            Tit11.Selected += TreeViewItem_Selected;
            Tit12.Selected += TreeViewItem_Selected;
           
            Tit14.Selected += TreeViewItem_Selected;
            Tit15.Selected += TreeViewItem_Selected;
            Tit16.Selected += TreeViewItem_Selected;
            Tit17.Selected += TreeViewItem_Selected;
            //Tit18.Selected += TreeViewItem_Selected;
            //Tit19.Selected += TreeViewItem_Selected;
            //Tit20.Selected += TreeViewItem_Selected;
            _inactivityTimer = new DispatcherTimer();
            _inactivityTimer.Interval = TimeSpan.FromMinutes(5); // 5 minutos de inactividad
            _inactivityTimer.Tick += InactivityTimer_Tick;

            // Suscribirse a los eventos de entrada del usuario
            this.MouseMove += ResetInactivityTimer;
            this.KeyDown += ResetInactivityTimer;

            // Iniciar el temporizador
            _inactivityTimer.Start();
        }

        // Método que se ejecuta cuando el temporizador alcanza los 5 minutos de inactividad
        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            // Ejecuta el método que desees
            EjecutarMetodoPorInactividad();

            // Reinicia el temporizador para seguir monitoreando
            _inactivityTimer.Stop();
            _inactivityTimer.Start();
        }

        // Restablece el temporizador cuando hay actividad del usuario
        private void ResetInactivityTimer(object sender, EventArgs e)
        {
            _inactivityTimer.Stop(); // Detener el temporizador
            _inactivityTimer.Start(); // Reiniciar el temporizador
        }

        // Método que se ejecuta cuando se detecta inactividad
        private void EjecutarMetodoPorInactividad()
        {
            ContentFrame.Content = null;
            this.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Recursos/Img/saver.jpg")));
            // Aquí puedes colocar el código que deseas ejecutar
        }
        private void LoadLanguage(string cultureCode)
        {
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
                    dict.Source = new Uri("Recursos\\idioma\\MenuEs.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("Recursos\\idioma\\MenuIn.xaml", UriKind.Relative);
                    break;
            }
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(dict);
        }
        private void MenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // mediaPlayer.Stop();
                    if (MenuListBox.SelectedItem is ListBoxItem selectedItem)
            {
                string pageName = selectedItem.Tag.ToString();
                ContentFrame.Navigate(new Uri($"Vistas/{pageName}.xaml", UriKind.Relative));
            }
        }

        private void PlayMenuAudio()
        {
            string audio = "01es.mp3";
            if (SessionManager.CurrentLanguage != "es-ES")
            {
                audio = "01en.mp3";
            }
            // Ruta del recurso menu.mp3 en el proyecto
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;


            // Ruta completa al archivo menu.mp3 (asumiendo que está en Recursos/audio/Spanisch relativo al ejecutable)
            string audioFilePath = Path.Combine(exeDirectory, @"Recursos\"+ audio);

            // Cargar y reproducir el archivo de audio
            mediaPlayer.Open(new Uri(audioFilePath, UriKind.Absolute));
            mediaPlayer.Play();
        }
        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectedItem = e.OriginalSource as TreeViewItem;

            if (selectedItem != null)
            {
                // Obtener el valor del Tag
                string tagValue = selectedItem.Tag as string;

                if (!string.IsNullOrEmpty(tagValue))
                {
                    // Llamar al método de manejo de selección
                    goNavi(tagValue);
                }

                // Evitar que el evento se propague a otros elementos
                e.Handled = true;
            }
        }
        public void goNavi(string tag)
        {
           // mediaPlayer.Stop();

            this.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Recursos/Img/Hintergrund.jpg")));
            string pageName = tag;
            ContentFrame.Navigate(new Uri($"Vistas/{pageName}.xaml", UriKind.Relative));
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Key == Key.F12)
            {
                // Mostrar el mensaje de confirmación
                MessageBoxResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea salir?", // Mensaje del diálogo
                    "Confirmar salida",                 // Título del diálogo
                    MessageBoxButton.YesNo,             // Botones de Sí y No
                    MessageBoxImage.Question);          // Icono de pregunta

                // Si el usuario selecciona "Sí", cerrar la aplicación
                if (resultado == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                }
            }
        }

        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (SessionManager.CurrentLanguage == "es-ES")
            {
                SessionManager.CurrentLanguage = "en-US";
            }
            else
            {
                SessionManager.ChangeLanguage("es-ES");
            }
            LoadLanguage(SessionManager.CurrentLanguage);
            ContentFrame.Content = null;
            this.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Recursos/Img/saver.jpg")));
        }
    }

}