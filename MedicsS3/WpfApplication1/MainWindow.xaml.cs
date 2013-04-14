using System.Windows;
using MedicsS3;
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            S3Util.UploadFile(@"C:\1.png", "foto.jpg");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
          S3Util.DownloadFile();
           
        }
    }
}
