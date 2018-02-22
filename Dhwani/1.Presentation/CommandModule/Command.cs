using Dhwani._2.Application.VoiceService.CommandService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Dhwani._1.Presentation.CommandModule
{
    public partial class Command : Form
    {
        public Command()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CommandServiceConnectDomain objData = new CommandServiceConnectDomain();

            CommandService objModel = new CommandService();
            objModel.Malayalam = txtMalayalam.Text;
            objModel.Manglish = txtManglish.Text;
            bool Result = false;
            Result = objData.InsertCommand(objModel);
            if (Result == true)
            {
                MessageBox.Show("Command inserted inserted");
            }
            else
            {
                MessageBox.Show("Command inserted failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://www.google.com");


            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            HttpResponseMessage response = client.GetAsync(string.Format("inputtools/request?text={0}&ime=transliteration_en_ml&num=1", txtManglish.Text)).Result;
            var dataObjects = response.Content.ReadAsStringAsync().Result;
            var json = new JavaScriptSerializer().Serialize(dataObjects);


            int i = 0;

            foreach (var item in json.ToString().Split(','))
            {
                if (i == 2)
                {

                    string UnformattedMalayalamWord = item.Substring(3);
                    string FormattedWord = UnformattedMalayalamWord.Substring(0, UnformattedMalayalamWord.Length - 3);
                    txtMalayalam.Text = FormattedWord;
                }
                i++;
            }
        }
    }
}