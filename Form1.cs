using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarWebView();
            
        }

        private async void InicializarWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            string Url = comboBox1.Text;


            if(Url.Contains(".com"))
            {
                if (Url.Contains("https://") || Url.Contains("http://"))
                {
                    webView21.Source = new Uri(Url);
                }
                else
                {
                    Url = "https://" + Url;
                    webView21.Source = new Uri(Url);
                }
            }
            else
            {
                Url = "https://www.google.com/search?q=" + Url;
                webView21.Source = new Uri(Url);
            }

            
        
        }

        private void navegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webView21.Source = new Uri("https://www.google.com");
        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
                webView21.GoBack();
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
                webView21.GoForward();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
