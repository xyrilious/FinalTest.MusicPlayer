using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XyrilleAnnMamalateo.MusicPlayer
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
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;

        private void BT_click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            };
            bool? dialogOk = fileDialog.ShowDialog();
            if (dialogOk == true)
            {
                filename = fileDialog.FileName;
                TBFileName.Text = fileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));
            }
        }

        private void BT_click_Pause(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void BT_click_Stop(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void BT_click_Play(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
    }
}
