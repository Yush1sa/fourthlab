namespace fourthlab
{
    public partial class Form1 : Form
    {
        List<Character> charactersList = new List<Character>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.charactersList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.charactersList.Add(Warrior.Generate());
                        break;
                    case 1:
                        this.charactersList.Add(Mage.Generate());
                        break;
                    case 2:
                        this.charactersList.Add(Archer.Generate());
                        break;
                }

            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int warriorCount = 0;
            int mageCount = 0;
            int archerCount = 0;

            foreach (var character in charactersList)
            {
                if (character is Warrior)
                {
                    warriorCount++;
                }
                else if (character is Mage)
                {
                    mageCount++;
                }
                else if (character is Archer)
                {
                    archerCount++;
                }
            }
            warriorInfo.Text = $"Воин: {warriorCount}";
            mageInfo.Text = $"Маг: {mageCount}";
            archerInfo.Text = $"Лучник: {archerCount}";
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.charactersList.Count == 0)
            {
                txtOut.Text = "Пока что тут пусто =)";
                return;
            }

            var character = this.charactersList[0];
            this.charactersList.RemoveAt(0);

            txtOut.Text = character.GetInfo();

            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void mageInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
