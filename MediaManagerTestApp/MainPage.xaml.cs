using MediaManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MediaManagerTestApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CrossMediaManager.Current.StateChanged += Current_StateChanged;
            MainVideoView.Source = "https://firebasestorage.googleapis.com/v0/b/estudo-af035.appspot.com/o/big_buck_bunny.mp4?alt=media&token=4457fc94-e298-4264-bed9-817256a2444b";
            CrossMediaManager.Current.Play();
        }

        private void Current_StateChanged(object sender, MediaManager.Playback.StateChangedEventArgs e)
        {
            if(e.State == MediaManager.Player.MediaPlayerState.Paused)
            {

            }
            else if (e.State == MediaManager.Player.MediaPlayerState.Playing)
            {

            }
            else if (e.State == MediaManager.Player.MediaPlayerState.Stopped)
            {

            }
        }
    }
}
