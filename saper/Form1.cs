namespace saper
{
    public partial class Form1 : Form
    {
        private Button[] cells;
        private string[,] mines = new string [10,10];
        public Form1()
        {
            InitializeComponent();
            cells = new[] 
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12,
                button13,
                button14,
                button15,
                button16,
                button17,
                button18,
                button19,
                button20,
                button21,
                button22,
                button23,
                button24,
                button25,
                button26,
                button27,
                button28,
                button29,
                button30,
                button31,
                button32,
                button33,
                button34,
                button35,
                button36,
                button37,
                button38,
                button39,
                button40,
                button41,
                button42,
                button43,
                button44,
                button45,
                button46,
                button47,
                button48,
                button49,
                button50,
                button51,
                button52,
                button53,
                button54,
                button55,
                button56,
                button57,
                button58,
                button59,
                button60,
                button61,
                button62,
                button63,
                button64,
                button65,
                button66,
                button67,
                button68,
                button69,
                button70,
                button71,
                button72,
                button73,
                button74,
                button75,
                button76,
                button77,
                button78,
                button79,
                button80,
                button81,
                button82,
                button83,
                button84,
                button85,
                button86,
                button87,
                button88,
                button89,
                button90,
                button91,
                button92,
                button93,
                button94,
                button95,
                button96,
                button97,
                button98,
                button99,
                button100

            };
            for (int i = 0; i < mines.GetLength(0); i++)
                for (int j = 0; j < mines.GetLength(1); j++)
                    mines[i, j] = "";
            for (int i = 0; i < 10; i++)
                mines[new Random().Next(10), new Random().Next(10)] = "*";
            int count = 0;
            for (int i = 0; i < mines.GetLength(0); i++)
                for (int j = 0; j < mines.GetLength(1); j++)
                {
                    for (int k = -1; k < -1; k++)
                        for (int t = -1; t < 1; t++)
                        {
                            try
                            {

                                if (mines[i + k, j + t] == "*")
                                    count++;
                            }
                            catch(Exception e) { }
                        }
                        if (mines[i, j] != "*")
                            mines[i,j] = count.ToString();
                        count = 0;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cells.Length; i++)
                if (cells[i] == sender)
                {
                    cells[i].Text = mines[i%10,i/10].ToString();

                }
        }
    }
}
