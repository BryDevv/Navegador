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
        List<Historial> historial = new List<Historial>();
        public Navegador()
        {
            InitializeComponent();
            InicializarWebView();
            CargarHistorial();


        }

        private async void InicializarWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }


        private void GuardarHistorial()
        {
            // Usar using y formato de fecha "round-trip" para parseo robusto
            using (var writer = new StreamWriter("Historial.txt", false))
            {
            foreach (Historial h in historial)
            {
                writer.WriteLine($"{h.Url}|{h.Contador}|{h.Date}");
            }

            writer.Close();
            }

        }


        private void CargarHistorial()
        {
            if (File.Exists("Historial.txt"))
            {
                using (var reader = new StreamReader("Historial.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine();
                        string[] datos = linea.Split('|');

                        if (datos.Length == 3)
                        {
                            Historial h = new Historial();
                            h.Url = datos[0];
                            h.Contador = int.Parse(datos[1]);
                            h.Date = DateTime.Parse(datos[2]);

                            historial.Add(h);
                            AdressBar.Items.Add(h.Url);
                        }
                    }
                }
            }
        }

        private void EliminarPagina(string url)
        {
            Historial pagina = historial.FirstOrDefault(h => h.Url == url);

            if (pagina != null)
            {
                historial.Remove(pagina);
                GuardarHistorial();
            }
        }



        private void Ir_Click(object sender, EventArgs e)
        {
            string Url = AdressBar.Text;
            // inicio del historial

            Historial pagina = historial.Find(h => h.Url == Url);

            if (pagina != null)
            {
                pagina.Contador++;
                pagina.Date = DateTime.Now;
            }
            else
            {
                Historial nueva = new Historial();
                nueva.Url = Url;
                nueva.Contador = 1;
                nueva.Date = DateTime.Now;

                historial.Add(nueva);
                AdressBar.Items.Add(Url);
            }

            GuardarHistorial();

            // fin del historial





            if (Url.Contains(".com"))
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

        private void erase_Click(object sender, EventArgs e)
        {
            string urlSeleccionada = AdressBar.SelectedItem.ToString();

            
            historial.RemoveAll(h => h.Url == urlSeleccionada);

            
            GuardarHistorial();

            AdressBar.Items.Remove(urlSeleccionada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historial = historial
               .OrderByDescending(h => h.Contador)
               .ToList();

            // Limpiar el ComboBox
            AdressBar.Items.Clear();

            // Volver a cargarlo en el nuevo orden
            foreach (Historial h in historial)
            {
                AdressBar.Items.Add(h.Url);
            }

            // Opcional: guardar el nuevo orden en el archivo
            GuardarHistorial();
        }
    }
}
