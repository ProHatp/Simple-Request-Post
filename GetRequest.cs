using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GetRequest
{
    public partial class GetRequest : Form
    {
        public GetRequest()
        {
            InitializeComponent();
        }

        private void GetRequest_Load(object sender, EventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {

            string URL = "http://localhost/projeto%204/request.php";
            WebClient webClient = new WebClient();
            webClient.Headers["User-Agent"] = "userAgendCode";
            
            NameValueCollection formData = new NameValueCollection();
            formData["getrequest1"] = "ProHat";
            formData["getrequest2"] = "ProHat2";

            byte[] responseBytes = webClient.UploadValues(URL, "POST", formData);
            string responsefromserver = Encoding.UTF8.GetString(responseBytes);
            richTextBox1.Text = responsefromserver;

        }
    }
}
