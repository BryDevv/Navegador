using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Navegador
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
            InicializarWebView();
            
            FileStream stream = new FileStream("Historial.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            //Esta linea envía el texto leído a un control richTextBox, se puede cambiar para que
            //lo muestre en otro control por ejemplo un combobox
            {
                AdressBar.Items.Add(reader.ReadLine());

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();

        }

        private async void InicializarWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }


        private void Guardar(string fileName, string texto)
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega los datos al final del archivo
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            writer.WriteLine(texto);
            //Cerrar el archivo
            writer.Close();
        }





        private void Ir_Click(object sender, EventArgs e)
        {
           
            string Url = AdressBar.Text;


            if(Url.Contains(".com"))
            {
                if (Url.Contains("https://") || Url.Contains("http://"))
                {
                    webView21.Source = new Uri(Url);
                    AdressBar.Items.Add(Url);
                }
                else
                {
                    Url = "https://" + Url;
                    webView21.Source = new Uri(Url);
                    AdressBar.Items.Add(Url);
                }
            }
            else
            {
                Url = "https://www.google.com/search?q=" + Url;
                webView21.Source = new Uri(Url);
            }

            Guardar(@"Historial.txt", Url);

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
