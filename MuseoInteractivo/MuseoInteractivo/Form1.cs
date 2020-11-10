using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Newtonsoft.Json;
using System.Speech.Synthesis;
using SpeechSynthesizer = System.Speech.Synthesis.SpeechSynthesizer;
using System.Globalization;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace MuseoInteractivo
{
    public partial class Form1 : Form
    {

        private VideoCaptureDevice MiWebCam;
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivios;
        private string Path = @".\";

        public Form1()
        {
            InitializeComponent();
            CargaDispositivos();
            timerCamara.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "D:/Hackaton/MuseoInteractivo_Entrega/MuseoInteractivo_Entrega/Banners/Inicio2.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            btnCamara.Visible = false;
            btnMic.Visible = false;
            panelAux.Visible = false;
        }

        private void btnStartMuseum_Click(object sender, EventArgs e)
        {
            btnStartMuseum.Visible = false;
            btnCamara.Visible = true;
            btnMic.Visible = true;
            panelAux.Visible = true;
            axWindowsMediaPlayer1.URL = "D:/Hackaton/InnovaccionVirtual/CodigoCS/InteractiveMuseum/InteractiveMuseum/InteractiveMuseum/Banners/BotonesCamaraMic2.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private async void btnMic_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "D:/Hackaton/InnovaccionVirtual/CodigoCS/InteractiveMuseum/InteractiveMuseum/InteractiveMuseum/Banners/listeningSpeak.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            var speechConfig = SpeechConfig.FromSubscription("e8339b452a9d446b9b8594906389d174", "eastus");
            var result = await FromMic(speechConfig);

            btnCamara.Visible = false;
            btnMic.Visible = false;


            /*
                        axWindowsMediaPlayer1.URL = "D:/Hackaton/InnovaccionVirtual/CodigoCS/InteractiveMuseum/InteractiveMuseum/InteractiveMuseum/Banners/listeningSpeak.mp4";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        axWindowsMediaPlayer1.settings.setMode("loop", true);
            */
            var answer = AskQuestion(result.ToString());
            Speech2Text(answer);


            axWindowsMediaPlayer1.URL = "D:/Hackaton/InnovaccionVirtual/CodigoCS/InteractiveMuseum/InteractiveMuseum/InteractiveMuseum/Banners/BotonesCamaraMic2.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            btnCamara.Visible = true;
            btnMic.Visible = true;
        }

        async static Task<String> FromMic(SpeechConfig speechConfig)
        {
            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            var recognizer = new SpeechRecognizer(speechConfig, "es-MX", audioConfig);
            var result = await recognizer.RecognizeOnceAsync();

            return result.Text;
        }
        public static String AskQuestion(String Askedquestion)
        {
            Question question = new Question();
            question.question = Askedquestion;
            string result = "";
            string data = "";

            var jsonPost = JsonConvert.SerializeObject(question);

            string url = "https://museoin.azurewebsites.net/qnamaker/knowledgebases/0517be53-2f85-46eb-8b7f-f44ff203e16f/generateAnswer";
            WebRequest myReq = WebRequest.Create(url);
            myReq.Method = "post";
            myReq.ContentType = "application/json; charset=UTF-8";
            myReq.Headers["Authorization"] = "EndpointKey b6bfacf3-6581-43ab-b3dd-d3f1d4b950a7";

            using (var oSW = new StreamWriter(myReq.GetRequestStream()))
            {
                oSW.Write(jsonPost);
                oSW.Flush();
                oSW.Close();
            }

            WebResponse wr = myReq.GetResponse();
            using (var oSR = new StreamReader(wr.GetResponseStream()))
            {
                result = oSR.ReadToEnd().Trim();

                int indexStart = result.IndexOf("\"answer\":");
                int indexStop = result.IndexOf("\"score\":");

                result = result.Substring(indexStart, indexStop);
                String answerdata = result.Substring(9, result.Length - 9);
                indexStop = answerdata.IndexOf("\"score\":");
                data = answerdata.Substring(0, indexStop);
                oSR.Close();
            }

            return data;
        }
        public void Speech2Text(String text)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child, 0, CultureInfo.GetCultureInfo("es-MX"));
            synthesizer.Speak(text);
        }
        class Question
        {
            public string question { get; set; }

            public override string ToString()
            {
                return $"{question}";
            }
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.Visible = false;
            CerrarWebCam();
            string NombreVideo = MisDispositivios[0].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
            timerCamara.Start();
        }

        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Imagen;
        }
        public void CargaDispositivos()
        {
            MisDispositivios = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivios.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivios.Count; i++)
                    ;
            }
            else
                HayDispositivos = false;

        }
        private byte[] GuardaFoto()
        {
            byte[] ar = null;
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ar = new byte[ms.Length];
                ms.Write(ar, 0, ar.Length);
            }
            return ar;
        }
        private void GuardaFotoLocal()
        {
            try
            {
                if (MiWebCam != null && MiWebCam.IsRunning)
                {
                    pictureBox2.Image = pictureBox1.Image;
                    pictureBox2.Image.Save(Path + "hdeleon.jpg", ImageFormat.Jpeg);
                }
            }
            catch {; }
        }


        public static async Task<String> MakePredictionRequest(string imageFilePath)
            {
                var client = new HttpClient();
                
                // Request headers - replace this example key with your valid Prediction-Key.
                client.DefaultRequestHeaders.Add("Prediction-Key", "c76d7b45232c4959928dd88b1194e48b");

                // Prediction URL - replace this example URL with your valid Prediction URL.
                string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v3.0/Prediction/53bd8180-13d3-4329-a03a-fbe57460aeb6/classify/iterations/arqueologia/image";

                HttpResponseMessage response;

                // Request body. Try this sample with a locally stored image.
                byte[] byteData = GetImageAsByteArray(imageFilePath);

                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    response = await client.PostAsync(url, content);
                   // Console.WriteLine(await response.Content.ReadAsStringAsync());

            }
            return await response.Content.ReadAsStringAsync();
        }

            private static byte[] GetImageAsByteArray(string imageFilePath)
            {
                FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }

        public static async Task<String> predictPhoto(byte[] byteData)
        {
            var client = new HttpClient();
            // Request headers - replace this example key with your valid Prediction-Key.
            client.DefaultRequestHeaders.Add("Prediction-Key", "c76d7b45232c4959928dd88b1194e48b");

            // Prediction URL - replace this example URL with your valid Prediction URL.
            string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v3.0/Prediction/53bd8180-13d3-4329-a03a-fbe57460aeb6/classify/iterations/arqueologia/image";

            HttpResponseMessage response;

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(url, content);
                
            }

            return response.ToString();
        }
        private async void timerCamara_Tick(object sender, EventArgs e)
        {
            GuardaFotoLocal();
            String jsonStr = "";
          string path = @".\";
          jsonStr = await MakePredictionRequest(path + "hdeleon.jpg");

            axWindowsMediaPlayer1.URL = "D:/Hackaton/InnovaccionVirtual/CodigoCS/InteractiveMuseum/InteractiveMuseum/InteractiveMuseum/Banners/listeningSpeak.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = true;

            var myJsonString = jsonStr;
            var jo = JObject.Parse(myJsonString);
            var predicion = jo["predictions"][0]["tagName"].ToString();
          //  MessageBox.Show(predicion);
            CerrarWebCam();

          


            var answer = AskQuestion(predicion);
            Speech2Text(answer);


            axWindowsMediaPlayer1.URL = "D:/Hackaton/InnovaccionVirtual/CodigoCS/InteractiveMuseum/InteractiveMuseum/InteractiveMuseum/Banners/BotonesCamaraMic2.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            timerCamara.Stop();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

