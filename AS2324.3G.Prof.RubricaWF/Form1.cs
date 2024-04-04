namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;

        int nRecordInseriti = 0;

        // definizione array paralleli
        string[] cognome = new string[nMaxContatti];
        string[] nome = new string[nMaxContatti];
        string[] email = new string[nMaxContatti];
        string[] nickname = new string[nMaxContatti];
        int[] simpatia = new int[nMaxContatti];
        int[] annoNascita = new int[nMaxContatti];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            if (cmbRicerca.Text == "")
                MessageBox.Show("E' necessario definire il campo di ricerca.");
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text.Length == 0 ||
                txtNome.Text.Length == 0 ||
                txtNickName.Text.Length == 0)
            {
                MessageBox.Show("Dati obbligatori non inseriti non è possibile aggiungere il record");
                return;
            }
                

            cognome[nRecordInseriti] = txtCognome.Text;
            nome[nRecordInseriti] = txtNome.Text;
            email[nRecordInseriti] = txtEmail.Text;
            nickname[nRecordInseriti] = txtNickName.Text;

            if (cmbSimpatia.Text.Length>0)
                simpatia[nRecordInseriti] = Convert.ToInt32(cmbSimpatia.Text);
            if (txtAnnoNascita.Text.Length>0)
                annoNascita[nRecordInseriti] = Convert.ToInt32(txtAnnoNascita.Text);

            nRecordInseriti++;

        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            lstElenco.Items.Add("Elenco dei nominativi inseriti");

            lstElenco.Items.Add("cognome              nome                 email                nickname  simpatia annoNascita");
            for (int i = 0; i < nRecordInseriti; i++)
            {
               lstElenco.Items.Add($"{cognome[i].PadRight(20).Substring(0, 20)} {nome[i].PadRight(20).Substring(0, 20)} {email[i]?.PadRight(20)} {nickname[i].PadRight(10).Substring(0, 10)} {simpatia[i]}       {annoNascita[i]}");
            }
        }
    }
}
