namespace Port_serie
{
    partial class Ecran_Principale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label_portCom;
            this.label_debit = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_stop = new System.Windows.Forms.Label();
            this.label_parite = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_parite = new System.Windows.Forms.ComboBox();
            this.comboBox_stop = new System.Windows.Forms.ComboBox();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.comboBox_debit = new System.Windows.Forms.ComboBox();
            this.comboBox_portCOM = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_fermer = new System.Windows.Forms.Button();
            this.button_ouvrir = new System.Windows.Forms.Button();
            this.button_envoieDATA = new System.Windows.Forms.Button();
            this.textBox_sortieData = new System.Windows.Forms.TextBox();
            this.port_serie = new System.IO.Ports.SerialPort(this.components);
            this.textBox_receive = new System.Windows.Forms.TextBox();
            label_portCom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_portCom
            // 
            label_portCom.AutoSize = true;
            label_portCom.Location = new System.Drawing.Point(25, 37);
            label_portCom.Name = "label_portCom";
            label_portCom.Size = new System.Drawing.Size(69, 17);
            label_portCom.TabIndex = 0;
            label_portCom.Text = "Port COM";
            // 
            // label_debit
            // 
            this.label_debit.AutoSize = true;
            this.label_debit.Location = new System.Drawing.Point(25, 71);
            this.label_debit.Name = "label_debit";
            this.label_debit.Size = new System.Drawing.Size(88, 17);
            this.label_debit.TabIndex = 1;
            this.label_debit.Text = "Débit (Baud)";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(25, 107);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(114, 17);
            this.label_data.TabIndex = 2;
            this.label_data.Text = "Bits de données ";
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.Location = new System.Drawing.Point(25, 144);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(92, 17);
            this.label_stop.TabIndex = 3;
            this.label_stop.Text = "Bit(s) de stop";
            // 
            // label_parite
            // 
            this.label_parite.AutoSize = true;
            this.label_parite.Location = new System.Drawing.Point(25, 179);
            this.label_parite.Name = "label_parite";
            this.label_parite.Size = new System.Drawing.Size(101, 17);
            this.label_parite.TabIndex = 4;
            this.label_parite.Text = "Bit(s) de parité";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_parite);
            this.groupBox1.Controls.Add(this.comboBox_stop);
            this.groupBox1.Controls.Add(this.comboBox_data);
            this.groupBox1.Controls.Add(this.comboBox_debit);
            this.groupBox1.Controls.Add(this.comboBox_portCOM);
            this.groupBox1.Controls.Add(label_portCom);
            this.groupBox1.Controls.Add(this.label_parite);
            this.groupBox1.Controls.Add(this.label_debit);
            this.groupBox1.Controls.Add(this.label_stop);
            this.groupBox1.Controls.Add(this.label_data);
            this.groupBox1.Location = new System.Drawing.Point(34, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrôle port série";
            // 
            // comboBox_parite
            // 
            this.comboBox_parite.FormattingEnabled = true;
            this.comboBox_parite.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox_parite.Location = new System.Drawing.Point(166, 172);
            this.comboBox_parite.Name = "comboBox_parite";
            this.comboBox_parite.Size = new System.Drawing.Size(156, 24);
            this.comboBox_parite.TabIndex = 10;
            this.comboBox_parite.Text = "None";
            // 
            // comboBox_stop
            // 
            this.comboBox_stop.FormattingEnabled = true;
            this.comboBox_stop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBox_stop.Location = new System.Drawing.Point(166, 137);
            this.comboBox_stop.Name = "comboBox_stop";
            this.comboBox_stop.Size = new System.Drawing.Size(156, 24);
            this.comboBox_stop.TabIndex = 9;
            this.comboBox_stop.Text = "One";
            // 
            // comboBox_data
            // 
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox_data.Location = new System.Drawing.Point(166, 100);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(156, 24);
            this.comboBox_data.TabIndex = 8;
            this.comboBox_data.Text = "8";
            // 
            // comboBox_debit
            // 
            this.comboBox_debit.FormattingEnabled = true;
            this.comboBox_debit.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.comboBox_debit.Location = new System.Drawing.Point(166, 64);
            this.comboBox_debit.Name = "comboBox_debit";
            this.comboBox_debit.Size = new System.Drawing.Size(156, 24);
            this.comboBox_debit.TabIndex = 7;
            this.comboBox_debit.Text = "9600";
            // 
            // comboBox_portCOM
            // 
            this.comboBox_portCOM.FormattingEnabled = true;
            this.comboBox_portCOM.Location = new System.Drawing.Point(166, 30);
            this.comboBox_portCOM.Name = "comboBox_portCOM";
            this.comboBox_portCOM.Size = new System.Drawing.Size(156, 24);
            this.comboBox_portCOM.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.button_fermer);
            this.groupBox2.Controls.Add(this.button_ouvrir);
            this.groupBox2.Location = new System.Drawing.Point(34, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 64);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(308, 34);
            this.progressBar.TabIndex = 10;
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(158, 15);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(156, 34);
            this.button_fermer.TabIndex = 8;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // button_ouvrir
            // 
            this.button_ouvrir.Location = new System.Drawing.Point(6, 15);
            this.button_ouvrir.Name = "button_ouvrir";
            this.button_ouvrir.Size = new System.Drawing.Size(146, 34);
            this.button_ouvrir.TabIndex = 7;
            this.button_ouvrir.Text = "Ouvrir";
            this.button_ouvrir.UseVisualStyleBackColor = true;
            this.button_ouvrir.Click += new System.EventHandler(this.button_ouvrir_Click);
            // 
            // button_envoieDATA
            // 
            this.button_envoieDATA.Location = new System.Drawing.Point(413, 269);
            this.button_envoieDATA.Name = "button_envoieDATA";
            this.button_envoieDATA.Size = new System.Drawing.Size(248, 40);
            this.button_envoieDATA.TabIndex = 9;
            this.button_envoieDATA.Text = "Envoyer les données";
            this.button_envoieDATA.UseVisualStyleBackColor = true;
            this.button_envoieDATA.Click += new System.EventHandler(this.button_envoieDATA_Click);
            // 
            // textBox_sortieData
            // 
            this.textBox_sortieData.Location = new System.Drawing.Point(413, 36);
            this.textBox_sortieData.Multiline = true;
            this.textBox_sortieData.Name = "textBox_sortieData";
            this.textBox_sortieData.Size = new System.Drawing.Size(248, 218);
            this.textBox_sortieData.TabIndex = 10;
            // 
            // port_serie
            // 
            this.port_serie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_serie_DataReceived);
            // 
            // textBox_receive
            // 
            this.textBox_receive.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox_receive.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_receive.Location = new System.Drawing.Point(692, 36);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.Size = new System.Drawing.Size(248, 273);
            this.textBox_receive.TabIndex = 11;
            // 
            // Ecran_Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 376);
            this.Controls.Add(this.textBox_receive);
            this.Controls.Add(this.textBox_sortieData);
            this.Controls.Add(this.button_envoieDATA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ecran_Principale";
            this.Text = "Programme : communication port série";
            this.Load += new System.EventHandler(this.Ecran_Principale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_debit;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.Label label_parite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_parite;
        private System.Windows.Forms.ComboBox comboBox_stop;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.ComboBox comboBox_debit;
        private System.Windows.Forms.ComboBox comboBox_portCOM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_envoieDATA;
        private System.Windows.Forms.TextBox textBox_sortieData;
        private System.IO.Ports.SerialPort port_serie;
        private System.Windows.Forms.Button button_ouvrir;
        private System.Windows.Forms.TextBox textBox_receive;
    }
}

