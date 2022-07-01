using System.Runtime.Serialization.Formatters.Binary;

namespace AdventureGame
{
    public partial class MainForm : Form
    {
        Adventure adv;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Wr(String s)
        {
            displayTB.AppendText(s);
        }

        private void WrLn(String s)
        {
            Wr(s);
            Wr("\r\n");
        }

        private void InitAdventure()
        {
            adv = new Adventure();
            displayTB.Clear();
            ShowLocation();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            // an example of creating a file open dialog in code
            Stream st;
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "sav files (*.sav)| *.sav| All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((st = openFileDialog1.OpenFile()) != null)
                {
                    // file loading add here
                    st.Close();
                }
            }

        }


        private void ShowLocation()
        {
            Wr(adv.Player.Name);
            Wr(" are currently in this room: ");
            WrLn(adv.Player.CurrentRoom.Describe());
        }

        private void ShowInventory()
        {
            WrLn("You have " + adv.Player.Things.Describe());
        }

        private void MovePlayer(Dir aDir)
        {
            WrLn(adv.MovePlayerTo(aDir));
        }

        private void northBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.NORTH);
        }

        private void southBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.SOUTH);
        }

        private void westBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.WEST);
        }

        private void eastBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.EAST);
        }

        private void lookBtn_Click(object sender, EventArgs e)
        {
            ShowLocation();
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.TakeOb(inputTB.Text));
        }

        private void dropBtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.DropOb(inputTB.Text));
        }

        private void lookAtBtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.LookAtOb(inputTB.Text));
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;
            if ( saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if((st = saveFileDialog.OpenFile()) != null)
                {
                    // save to disk
                    binfmt = new BinaryFormatter();
                    binfmt.Serialize(st, adv);
                    st.Close();
                    WrLn("Saved");
                }
            }
        }

        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ( (st = openFileDialog.OpenFile()) != null)
                {
                    binfmt = new BinaryFormatter();
                    adv = (Adventure)binfmt.Deserialize(st);
                    st.Close();
                }
            }
            displayTB.Clear();
            ShowLocation();
        }

        private void reStartMenuItem_Click(object sender, EventArgs e)
        {
            InitAdventure();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitAdventure();
        }

        private void InvBtn_Click(object sender, EventArgs e)
        {
            ShowInventory();
        }
    }
}