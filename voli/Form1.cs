using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace voli
{
    public partial class Form1 : Form
    {
       
        Dictionary<string, string> countries = new Dictionary<string, string>();

        Dictionary<string, string> airports = new Dictionary<string, string>();

        private int budget; 


        public Form1()
        {
            InitializeComponent();


            PopulateAirports();
            InitializeListView();

            // Aggiungi il gestore dell'evento SelectedIndexChanged alla ListView
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
            // Nascondi la ListView all'inizio
            listView1.Visible = false;

            // Associa l'evento del clic alla TextBox
            textBox1.Click += new EventHandler(textBox1_Click);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);


        }


      

      
        private void PopulateAirports()
        {
            // Aggiungi gli aeroporti e i relativi codici al dizionario
     
            airports.Add("Heathrow (Londra, Regno Unito)", "LHR");
            airports.Add("Gatwick (Londra, Regno Unito)", "LGW");
            airports.Add("Stansted (Londra, Regno Unito)", "STN");
            airports.Add("Charles de Gaulle (Parigi, Francia)", "CDG");
            airports.Add("Orly (Parigi, Francia)", "ORY");
            airports.Add("Francoforte (Germania)", "FRA");
            airports.Add("Monaco di Baviera (Germania)", "MUC");
            airports.Add("Schiphol (Amsterdam, Paesi Bassi)", "AMS");
            airports.Add("Madrid-Barajas (Madrid, Spagna)", "MAD");
            airports.Add("Barcellona-El Prat (Barcellona, Spagna)", "BCN");
            airports.Add("Fiumicino (Roma, Italia)", "FCO");
            airports.Add("Malpensa (Milano, Italia)", "MXP");
            airports.Add("Eleftherios Venizelos (Atene, Grecia)", "ATH");
            airports.Add("Portela (Lisbona, Portogallo)", "LIS");
            airports.Add("Dublino (Irlanda)", "DUB");
            airports.Add("Nationale (Bruxelles, Belgio)", "BRU");
            airports.Add("Kastrup (Copenaghen, Danimarca)", "CPH");
            airports.Add("Arlanda (Stoccolma, Svezia)", "ARN");
            airports.Add("Bromma (Stoccolma, Svezia)", "BMA");
            // Aggiungi altri aeroporti secondo necessità
        }
        private void InitializeListView()
        {
            // Imposta le proprietà della ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Aggiungi le colonne alla ListView
            listView1.Columns.Add("Aeroporto", 200);
            listView1.Columns.Add("Codice", 100);

            // Popola la ListView con gli aeroporti e i codici
            foreach (var airport in airports)
            {
                ListViewItem item = new ListViewItem(airport.Key);
                item.SubItems.Add(airport.Value);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se è stato selezionato un aeroporto
            if (listView1.SelectedItems.Count > 0)
            {
                // Ottieni il nome e il codice dell'aeroporto selezionato
                string airportName = listView1.SelectedItems[0].Text;
                string airportCode = listView1.SelectedItems[0].SubItems[1].Text;

                // Fai qualcosa con il nome e il codice dell'aeroporto (ad esempio, visualizzali in un MessageBox)
                MessageBox.Show("Hai selezionato l'aeroporto: " + airportName + " (" + airportCode + ")");
            }
            else
            {
                MessageBox.Show("Seleziona un aeroporto prima di procedere.");
            }
        }

       
        private void textBox1_Click(object sender, EventArgs e)
        {
            // Mostra la ListView quando viene cliccata la TextBox
            listView1.Visible = true;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostra il testo selezionato nella TextBox
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Verifica se è selezionato l'elemento "50"
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "20")
            {
                // Imposta il valore della variabile a 50
                budget = 20;
                 
            }
            // Verifica se è selezionato l'elemento "50"
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "50")
            {
                // Imposta il valore della variabile a 50
                budget = 50;
            }
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "60")
            {
                // Imposta il valore della variabile a 50
                budget = 60;
            }
            
            // Verifica se è selezionato l'elemento "50"
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "80")
            {
                // Imposta il valore della variabile a 50
                budget = 80;
            }
            // Verifica se è selezionato l'elemento "50"
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "100")
            {
                // Imposta il valore della variabile a 50
                budget = 100;
            }
            // Verifica se è selezionato l'elemento "50"
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "150")
            {
                // Imposta il valore della variabile a 50
                budget = 150;
            }
        }

      
        private void dtPartenza_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtPartenza.Value;

            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void dtRitorno_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtRitorno.Value;

            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        }


private void button2_Click(object sender, EventArgs e)
        {

        string message = "Clicca [qui](https://www.example.com) per visitare il sito web.";
        MessageBox.Show(message, "Messaggio con link", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //diver.Navigate().GoToUrl($"https://www.travel365.it/destinazioni/europa/italia/lombardia/{luogo}/");
    }
}

