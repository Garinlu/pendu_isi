using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Pendu
{
    public partial class Form1 : Form
    {
        private String hideWord = " ";
        private FindAWord hide_Word;
        private printWord printWord;
        private Partie game;

        public Form1()
        {
            InitializeComponent();
            initComposants();
        }

        // Initialise les composants graphiques du formulaire
        private void initComposants()
        {
            // Charge les cellules du DataGridView
            dataGridView1.ColumnCount = 13;
            dataGridView1.RowCount = 2;
            dataGridView1.Rows[0].Height = 30;
            dataGridView1.Rows[1].Height = 30;
            for (int i = 0; i < 13; i++)
            {
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Rows[0].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // Type casting du code ascii (entier) vers sa représentation en caractère (wrapper Char)
                // Les lettres de l'alphabet se suivent de 65 à 91 dans la table, ce qui rend facile la manipulation
                dataGridView1.Rows[0].Cells[i].Value = ((Char)(i + 65)).ToString();
                // Traitement de la deuxieme partie de l'alphabet pour la seconde ligne
                dataGridView1.Rows[1].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Rows[1].Cells[i].Value = ((Char)(i + (65 + 13))).ToString();
            }
            tsplb_information.Text = "Veuillez charger un fichier de dictionnaire de mots.";
        }


        // déclaration et instanciation d’une collection pour le dictionnaire
        private List<String> dictionary = new List<String>();

        private void selctFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // on initalise la boîte de dialogue
            ofd.Filter = "txt files (*.txt)|*.txt";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {   // on ouvre le fichier
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                String ligne;
                while ((ligne = sr.ReadLine()) != null)
                    // Insertion de chaque ligne dans le dictionnaire
                    dictionary.Add(ligne);
                // Renseignement de la propriété Mot_secret d'un mot tiré au 
                //hasard dans le dictionnaire
                fs.Close();
                sr.Close();
                hideWord = dictionary[new Random().Next(dictionary.Count)];
                tsplb_information.Text = "Mot secret chargé, choisissez votre première lettre.";
                bt_verifier.Enabled = true;

            }
        }


        public void initializeGame()
        {
            game = new Partie();
            printWord = new printWord(hideWord);
            hide_Word = new FindAWord(hideWord);
            img1.BackgroundImage = null;
            Affiche.Text = printWord.getWord();
            lb_Echec.Text = game.getEchecList();

        }

        public void repaint()
        {

            switch (game.getnoEchec())
            {
                case 1: img1.BackgroundImage = Pendu.Properties.Resources.pendu_1;
                    break;
                case 2: img1.BackgroundImage = Pendu.Properties.Resources.pendu_2;
                    break;
                case 3: img1.BackgroundImage = Pendu.Properties.Resources.pendu_3;
                    break;
                case 4: img1.BackgroundImage = Pendu.Properties.Resources.pendu_4;
                    break;
                case 5: img1.BackgroundImage = Pendu.Properties.Resources.pendu_5;
                    break;
                case 6: img1.BackgroundImage = Pendu.Properties.Resources.pendu_6;
                    break;
            }


            if (game.getnoEchec() == 6)
            {
                MessageBox.Show("Pendu!!");
                initializeGame();

            }
        }



        public void answerTest(Char c)
        {
            try
            {
                if (game.getlistEchec().Contains(c) == true)
                {
                    MessageBox.Show("Vous avez deja tester cette lettre");
                    return;
                }

                if (printWord.testLetter(hide_Word.getSecretArray(), c) == false)
                {
                    game.addEchec(c);
                    repaint();
                }
                Affiche.Text = printWord.getWord();
                lb_Echec.Text = game.getEchecList();
                if (printWord.testWord(hide_Word.getSecretArray()) == true)
                {
                    MessageBox.Show("Vous avez gagner!");
                    game = new Partie();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur: " + e.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_generer_Click(object sender, EventArgs e)
        {
            selctFile();
            initializeGame();
        }

        private void bt_abandonner_Click(object sender, EventArgs e)
        {
            if (!hideWord.Equals(" "))
            {
                MessageBox.Show("Le mot etait:" + hideWord);
                initializeGame();
            }
            else
            {
                MessageBox.Show("La partie n'a pas commencé");
            }
        }

        private void bt_verifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (hide_Word.testTry(essai.Text.ToCharArray()))
                {
                    MessageBox.Show("Vous avez gagnez!");
                    initializeGame();
                }
                else
                {
                    MessageBox.Show("Defaite! Vous avez etait pendu! La réponse était " + hideWord);
                    initializeGame();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !" + ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Char lettre = Convert.ToChar(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            answerTest(lettre);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
