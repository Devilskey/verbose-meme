using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;

namespace project_week_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private FilterInfoCollection CapturDevice;
        private VideoCaptureDevice FinalFrame;

        public MainWindow()
        {
            InitializeComponent();

            CapturDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CapturDevice)
                CbCameras.Items.Add(Device.Name);
            CbCameras.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            video v = new video();
            v.Show();
            this.Close();

        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            aboutpage ap = new aboutpage();
            ap.Show();
            this.Close();
        }

        private void guid_Click(object sender, RoutedEventArgs e)
        {
            guide g = new guide();
            g.Show();
            this.Close();
        }

        private void SCAN_Click(object sender, RoutedEventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CapturDevice[CbCameras.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            try
            {
                this.Dispatcher.Invoke(() =>
                {
                    text.Text = FindQrCodeInImage(bmp);
                    imgQR.Source = imageSource(bmp);

                });
            }
            catch (Exception ex)
            {
                Environment.Exit(0);
            }
        }

        private void QrcodeChecker(string qrCode)
        {
            video v = new video();
            switch (qrCode)
            {
                case "1":
                    v.Show();
                    this.Close();
                    break;
            }
        }

        private string FindQrCodeInImage(Bitmap bmp)
        {
            var source = new BitmapLuminanceSource(bmp);
            var bitmap = new BinaryBitmap(new HybridBinarizer(source));
            var result = new MultiFormatReader().decode(bitmap);

            if (result == null)
            {
                return null;
            }

            //show the found qr code in the app
            return result.Text;
            }

        private ImageSource imageSource(Bitmap bmp)
        {
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    bmp.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                    memory.Position = 0;
                    BitmapImage bitmapimage = new BitmapImage();
                    bitmapimage.BeginInit();
                    bitmapimage.StreamSource = memory;
                    bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapimage.EndInit();
                    return bitmapimage;
                }
            }
        }
    }
}