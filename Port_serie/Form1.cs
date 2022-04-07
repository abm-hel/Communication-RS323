using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ajout bibliothèque pour port série 
using System.IO.Ports;

namespace Port_serie
{
    public partial class Ecran_Principale : Form
    {
        string data;
        string data_receive;
        public Ecran_Principale()
        {
            InitializeComponent();
        }

        private void Ecran_Principale_Load(object sender, EventArgs e)
        {
            //on récupére les ports série dispo , ensuite on les ajoute à la comboBox (comboBox_portCOM)
            string[] ports = SerialPort.GetPortNames(); 
            comboBox_portCOM.Items.AddRange(ports);
        }

        //boutton ouverture du port 
        private void button_ouvrir_Click(object sender, EventArgs e)
        {
            try
            {
                //Controle du port série (récupération des paramètres choisis par l'utilisateur)
                port_serie.PortName = comboBox_portCOM.Text;
                port_serie.BaudRate = Convert.ToInt32(comboBox_debit.Text);
                port_serie.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_stop.Text);
                port_serie.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_parite.Text);
                //ouverture du port 
                port_serie.Open();
                //barre de progression à 100 % 
                progressBar.Value = 100;

            }
            catch (Exception err)
            {
                //affichage d'un message en cas d'erreur de paramétrage 
                MessageBox.Show(err.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        //boutton fermerture du port
        private void button_fermer_Click(object sender, EventArgs e)
        {
            if(port_serie.IsOpen)
            {
                //fermeture du port si ouvert
                port_serie.Close();
                //barre de progression se met à 0%
                progressBar.Value = 0;
            }
            else
            {
                MessageBox.Show("Tous les ports sont déjà fermés ! ", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //boutton envoie des données 
        private void button_envoieDATA_Click(object sender, EventArgs e)
        {
            //chaine de caractere ou le message va etre stocke (que l'utisisateur va  tapper dans la textBox) 
            data = textBox_sortieData.Text;
            if(port_serie.IsOpen)
            {
                //envoie du message si le port est ouvert 
                port_serie.WriteLine(data);
            }
            //sinon affichage d'un message d'erreur
            else
            {
                MessageBox.Show("Port fermé !", "Attention !", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void port_serie_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_receive = port_serie.ReadExisting();
            this.Invoke(new EventHandler(afficher));
        }

        private void afficher(object sender, EventArgs e)
        {
            textBox_receive.Text = data_receive;
        }
    }
}
