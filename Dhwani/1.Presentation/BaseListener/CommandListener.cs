using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Dhwani._6.Infrastructure.MainModule;
using System.Speech.Recognition;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;

namespace Dhwani._1.Presentation.BaseListener
{
    public partial class CommandListener : Form
    {
        public CommandListener()
        {
            InitializeComponent();
        }

        private void CommandListener_Load(object sender, EventArgs e)
        {
            MalayalamPackageConfig.Explore();
            SpeechRecognitionWithDictationGrammar();
            this.webBrowser1.Visible = false;
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
           // synth.SpeakAsync("Hello there !!! This is thwaany . I'am Listening");
        }


      //   public static InputLanguage GetInputLanguageByName(string inputName)
      //  {
        //    foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
          //  {
            //    if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
              //      return lang;
           // }
           // return null;
       // }



 

        static SpeechRecognitionEngine _recognizer = null;
        static ManualResetEvent manualResetEvent = null;
        static void SpeechRecognitionWithDictationGrammar()
        {
            _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("exit")));
            _recognizer.LoadGrammar(new DictationGrammar());
            _recognizer.SpeechRecognized += speechRecognitionWithDictationGrammar_SpeechRecognized;
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        static void speechRecognitionWithDictationGrammar_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Close")
            {
                manualResetEvent.Set();
                return ;
            }
         
            if(e.Result.Text!="")
            {
                string MalayalamWord = GoogleIntegratedApi(e.Result.Text);
                if (MalayalamWord != "NIL")
                {
                    ConvertManglishtoMalayalam(MalayalamWord);
                }
            }

           
        }

        private static string GoogleIntegratedApi(string Manglish)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.google.com");


            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync(string.Format("inputtools/request?text={0}&ime=transliteration_en_ml&num=1", Manglish)).Result;
            var dataObjects = response.Content.ReadAsStringAsync().Result;
            var json = new JavaScriptSerializer().Serialize(dataObjects);


            int i = 0;

            foreach (var item in json.ToString().Split(','))
            {
                if (i == 2)
                {

                    string UnformattedMalayalamWord = item.Substring(3);
                    string FormattedWord = UnformattedMalayalamWord.Substring(0, UnformattedMalayalamWord.Length - 3);
                  return FormattedWord;
                }
                i++;
            }

            return "NIL";
        }

        private static void ConvertManglishtoMalayalam(string Manglish)
        {
            List<char> listchar = new List<char>();

            for (int i = 0; i < Manglish.Length; i++)
            {
                listchar.Add(Manglish[i]);
            }

            string MalayalamWord = "";
            for (int i = 0; i < listchar.Count; i++)
            {
                MalayalamWord = MalayalamWord + listchar[i];
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.google.co.in/search?query=" + MalayalamWord);
                if (listchar.Count - 1 == i)
                {
                    Process.Start(sInfo);
                }
            }
        }



        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName))
                    return lang;
            }
            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
          //  var Resule = GetInputLanguageByName("   ");
 
            //string Data="%E0%B4%87%E0%B4%A8%E0%B4%BF%E0%B4%AA%E0%B5%8D%E0%B4%AA%E0%B4%B1%E0%B4%AF%E0%B5%81";
          //string Name="ഇനിപ്പറയുന്നതില്‍";
            //this.webBrowser1.Visible = true;
            //this.webBrowser1.Navigate(string.Format("https://www.google.co.in/search?q=%E0%B4%87%E0%B4%A8%E0%B4%BF%E0%B4%AA%E0%B5%8D%E0%B4%AA%E0%B4%B1%E0%B4%AF%E0%B5%81%E0%B4%A8%E0%B5%8D%E0%B4%A8%E0%B4%A4%E0%B4%BFs", Name));
           // Login objlogin = new Login();
            //objlogin.Show();




            ConvertManglishtoMalayalam();
     
        }

        private void ConvertManglishtoMalayalam()
        {
            List<char> listchar = new List<char>();

            for (int i = 0; i < "".Length; i++)
            {
                listchar.Add(""[i]);
            }

            string MalayalamWord = "";
            for (int i = 0; i < listchar.Count; i++)
            {
                MalayalamWord = MalayalamWord + listchar[i];
                ProcessStartInfo sInfo = new ProcessStartInfo("https://www.google.co.in/search?query=" + MalayalamWord);
                if (listchar.Count - 1 == i)
                {
                    Process.Start(sInfo);
                }
            }
        }
    }
}
