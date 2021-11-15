using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLoginForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet5.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter1.Fill(this.dataDataSet5.Person);
            // TODO: This line of code loads data into the 'dataDataSet4.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dataDataSet4.Table);
            // TODO: This line of code loads data into the 'dataDataSet3.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.dataDataSet3.Person);
            // TODO: This line of code loads data into the 'dataDataSet2.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.dataDataSet2.Address);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            ImageList photoList = new ImageList();
            photoList.TransparentColor = Color.Blue;
            photoList.ColorDepth = ColorDepth.Depth32Bit;
            photoList.ImageSize = new Size(200, 200);
            // books available for reading
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\books.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\pushkin.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\womenInRu.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\womenV.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\classics.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\drZhivago.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\HeroOfOurTime.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\anna-karenina.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\FathersAndsons.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\WarAndPeace.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\brotherKaramazovs.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheIdiot.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\life-and-fate.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Maidenhair.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\OmonRa.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\slynx-tolstaya.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Sonechka.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheDreaLifeOfSukhanov.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheFoundationPit.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheHeartOfaDog.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheNose.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheSecretHistoryOfMoscow.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheStoneBridge.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheTimeNight.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\DeadSouls.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Envy.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\CrimeAndPunishment.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\day-in-the-life-of-ivan.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Sankya.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Laurus.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\funeral-party-cover.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\eugene-onegin-cover.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\and-quiet-flows.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Chehov.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Journey.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\LadyMacbeth.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\Lolita-.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\LoveAndYouth.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\TheMonastery.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\3Apples.jpg"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\FTCC\Desktop\My Folder\books images\bookshelf.jpg"));

            for (int count = 0; count < photoList.Images.Count; count++)
            {
                photoList.Draw(g, new Point(20, 20), count);
                // Paint the form and wait to load the image
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string box_msg = "Check Out Yes / No Options";

            string box_title = "Yes No Dialog";

            MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
