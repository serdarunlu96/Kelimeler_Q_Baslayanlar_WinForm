namespace Kelimeler_Q_Baslayanlar
{
    public partial class Form1 : Form
    {
        string[] kelimeler;
        public Form1()
        {
            InitializeComponent();
            kelimeler = File.ReadAllLines("english3.txt");

        }

        private void btnKelimeQ_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();

            foreach (string kelime in kelimeler) 
            {
                if(kelime.StartsWith("q"))
                {
                    lstSonuc.Items.Add(kelime);
                }
            }

        }
    }
}