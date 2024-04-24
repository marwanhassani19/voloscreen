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
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;

namespace voli
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> countries = new Dictionary<string, string>();

        Dictionary<string, string> airports = new Dictionary<string, string>();
        private string partenzaAeroporto;
        private string airportCode;

        private int budget;
        private string tipoViaggio;


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


            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged_1);



            rbSpecifica.Visible = false;

            rbIntervallo.Visible = false;
            panelPartenza.Visible = false;


            txtPartenza.Click += new EventHandler(txtPartenza_Click);

            rbSpecifica.CheckedChanged += new EventHandler(rbSpecifica_CheckedChanged);
            rbIntervallo.CheckedChanged += new EventHandler(rbIntervallo_CheckedChanged);

            dtPartenza.Visible = false;
            dtRitorno.Visible = false;




        }





        public void PopulateAirports()
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
        public void InitializeListView()
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

      


        public void textBox1_Click(object sender, EventArgs e)
        {
            // Mostra la ListView quando viene cliccata la TextBox
            listView1.Visible = true;
        }
        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostra il testo selezionato nella TextBox
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
            }
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            DateTime selectedDate2 = dtRitorno.Value;

            // Formatta la data nel formato desiderato (anno-mese-giorno) utilizzando la cultura "en-US"
            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        }


        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "CITTA'")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "CTY";

            }
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "FAMIGLIA")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "FAM";

            }
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "GOLF")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "GLF";


            }
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "VITA NOTTURNA")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "NIT";

            }
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == " ALL'APERTO")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "OUT";

            }

            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "MARE")
            {
                // Imposta il valore della variabile a 50
                tipoViaggio = "SEA";
            }
        }

        private void btnInformazioni_Click_1(object sender, EventArgs e)
        {

            //ANDATA
            DateTime selectedDate = dtPartenza.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("formattedDate: " + formattedDate); // Aggiungi questa linea per il debug
            string message = $"La data formattata è: {formattedDate}";
            // MessageBox.Show(message, "Data Formattata", MessageBoxButtons.OK, MessageBoxIcon.Information);






            //RITORNO
            DateTime selectedDate2 = dtRitorno.Value;
            string formattedDate2 = selectedDate2.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("formattedDate: " + formattedDate2); // Aggiungi questa linea per il debug
            string message2 = $"La data formattata è: {formattedDate2}";
            // MessageBox.Show(message2, "Data Formattata", MessageBoxButtons.OK, MessageBoxIcon.Information);





            // Verifica se è stato selezionato un aeroporto
            if (listView1.SelectedItems.Count > 0)
            {
                // Ottieni il nome e il codice dell'aeroporto selezionato
                partenzaAeroporto = listView1.SelectedItems[0].Text;
                airportCode = listView1.SelectedItems[0].SubItems[1].Text;

            }
            else
            {
                MessageBox.Show("Seleziona un aeroporto prima di procedere.");
            }
            //  string message3 = $"Informazioni:\nPartenza: {airportCode}\nBudget: {budget}\nData di Andata: {formattedDate}\nData di Ritorno: {formattedDate2}";
            // MessageBox.Show(message3, "Dettagli Viaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget={budget}&trip-type-category={tipoViaggio}");

            txtLink.Text = $"https://www.ryanair.com/it/it/voli-low-cost/?from={airportCode}&out-from-date={formattedDate}&out-to-date={formattedDate2}&budget={budget}&trip-type-category={tipoViaggio}";
            Process.Start(txtLink.Text);
        }

        private void txtPartenza_Click(object sender, EventArgs e)
        {
            rbIntervallo.Visible = true;
            rbSpecifica.Visible = true;
            panelPartenza.Visible = true;
        }


        private void rbSpecifica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSpecifica.Checked)
            {
                dtPartenza.Visible = true;
                
            }
          
        }
        private void rbIntervallo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIntervallo.Checked)
            {
                dtPartenza.Visible = true;
              dtRitorno.Visible = true;

            }
            else
            {
                dtRitorno.Visible = false;
            }

        }

      
    }
}



