using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video;
using Accord.Video.DirectShow;
namespace Image_Processing
{
    public class CameraFeed
    {
        private VideoCaptureDevice _videoSource;
        private PictureBox pictureBox;

        public CameraFeed(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0) {
                _videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                _videoSource.NewFrame += VideoSource_NewFrame;
            }
        }
        public void Start()
        {
            _videoSource?.Start();
        }
        public void Stop()
        {
            _videoSource?.SignalToStop();
        }

        private void VideoSource_NewFrame(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap) eventArgs.Frame.Clone();
        }
    }
}
