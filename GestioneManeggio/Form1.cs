using System.Runtime.CompilerServices;

namespace GestioneManeggio
{
    public partial class Form1 : Form
    {

        struct Cavallo
        {
            public string nome;
            public string razza;
            public int nascita;
            public char sesso;

            public Cavallo(string nome, string razza, int nascita, char sesso)
            {
                this.nome = nome;
                this.razza = razza;
                this.nascita = nascita;
                this.sesso = sesso;
            }

            public string Stampa()
            {
                return $"{nome};{razza};{nascita};{sesso}";
            }

            public string StampaLst()
            {
                return $"Nome: {nome} Razza: {razza} Anno di nascita: {nascita} Sesso: {sesso}";
            }
        }

        List<Cavallo> maneggio = new List<Cavallo>();

        string[] cavalli = new string[10];          //array per leggere i dati dal file .txt

        string path;
        public Form1()
        {
            InitializeComponent();      
            OpenFileDialog open = new OpenFileDialog();         //aprire il file .txt
            open.Title = "Seleziona il file .txt";              //filtro per visualizzare solo i file .txt
                    
            if (open.ShowDialog() == DialogResult.OK)        //se l'utente ha selezionato un file e ha cliccato su "OK"
            {
                path = open.FileName;                          //salvo il percorso del file in una variabile
                cavalli = File.ReadAllLines(path);              //leggo tutte le righe e salvo in array cavalli

                foreach (string cavallo in cavalli) 
                {
                    string[]  datiCavallo = cavallo.Split(';');             //divido la stringa da ";"
                    string nome = datiCavallo[0];
                    string razza = datiCavallo[1];
                    int nascita = int.Parse(datiCavallo[2]);
                    char sesso = char.Parse(datiCavallo[3]);

                    Cavallo c = new Cavallo(nome, razza, nascita, sesso);       
                    maneggio.Add(c);                
                    lstManeggio.Items.Add(c.StampaLst());
                }
                txtNome.Text = "";
                txtNascita.Text = "";
                txtRazza.Text = "";

            }

        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string razza = txtRazza.Text;

            if (nome == "" || razza == "")
            {
                txtRisposta.Text = "Completa tutti i campi correttamente";
                return;
            }
            int nascita;
            char sesso;
            bool x = int.TryParse(txtNascita.Text, out nascita);
            if (!x)
            {
                txtRisposta.Text = "Completa tutti i campi correttamente";
                txtNome.Text = "";
                txtNascita.Text = "";
                txtRazza.Text = "";

                return;
            }
            if (nascita < 1950 || nascita > 2026)
            {
                txtNascita.Text = "";
                txtRisposta.Text = "Inserisci un anno valido";
                return;
            }
                
            if (rdbFemmina.Checked)
            {
                sesso = 'F';
            }
            else if (rdbMaschio.Checked)
            {
                sesso = 'M';
            }
            else
            {
                txtRisposta.Text = "Scegli un sesso";
                return;
            }  
            if (maneggio.Count < 10)         
            {
                Cavallo cavallo = new Cavallo(nome, razza, nascita, sesso);
                maneggio.Add(cavallo);
                lstManeggio.Items.Add(cavallo.StampaLst());
            }
            else
            {
                txtRisposta.Text = "Spazio finito! Rimuovi dei cavalli";
                
            }
            txtNome.Text = "";
            txtNascita.Text = "";
            txtRazza.Text = "";
            rdbFemmina.Checked = false;
            rdbMaschio.Checked = false;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            txtNome.Text = "";
            txtNascita.Text = "";
            txtRazza.Text = "";
            foreach (var cavallo in maneggio)
            {
                if (cavallo.nome == nome)
                {
                    txtRisposta.Text = cavallo.StampaLst();

                    return;
                }
            }
            txtRisposta.Text = "Cavallo non trovato";
            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstManeggio.SelectedIndex == -1)
            {
                txtRisposta.Text = "Seleziona una persona!";
                return;
            }
            int i = lstManeggio.SelectedIndex;
            Cavallo cavallo = maneggio[i];       

            if (rdbFemmina.Checked)
            {
                cavallo.sesso = 'F';
            }
            else if (rdbMaschio.Checked)
            {
                cavallo.sesso = 'M';
            }
            if (txtNome.Text != "")
            {
                cavallo.nome = txtNome.Text;
            }
            if (txtRazza.Text != "")
            {
                cavallo.razza = txtRazza.Text;
            } 
            if (txtNascita.Text != "")
            {
                int nascita = int.Parse(txtNascita.Text);

                if (nascita < 1950 || nascita > 2026)
                {
                    txtNascita.Text = "";
                    txtRisposta.Text = "Inserisci un anno valido";
                    return;
                }
                cavallo.nascita = nascita;
            }
            maneggio[i] = cavallo;
            lstManeggio.Items[i] = cavallo.StampaLst();
            txtNome.Text = "";
            txtNascita.Text = "";
            txtRazza.Text = "";
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
             if (lstManeggio.SelectedIndex == -1)
             {
                txtRisposta.Text = "Seleziona una persona!";
                return;
             }
             int i = lstManeggio.SelectedIndex;
             maneggio.RemoveAt(i);
             lstManeggio.Items.RemoveAt(i);
             txtNome.Text = "";
             txtNascita.Text = "";
             txtRazza.Text = "";
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var cavallo in maneggio) 
                {
                    sw.WriteLine(cavallo.Stampa());
                }
            }
            txtNome.Text = "";
            txtNascita.Text = "";
            txtRazza.Text = "";
        }

        private void txtNascita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
