using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Runtime.InteropServices;

namespace FootBallManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            map1.Items.Add("4-3-3");
            map1.Items.Add("4-4-2");
            map1.Items.Add("3-5-2");
            map2.Items.Add("4-3-3");
            map2.Items.Add("4-4-2");
            map2.Items.Add("3-5-2");

        }
        Dictionary<string, ViTriCauThu[]> soDoChienThuat1 = new Dictionary<string, ViTriCauThu[]>()
{
    {"4-4-2", new ViTriCauThu[] {
        new ViTriCauThu { TenViTri = "ST11", ToaDo = new Point(69, 10) },
        new ViTriCauThu { TenViTri = "ST12", ToaDo = new Point(249, 10) },
        new ViTriCauThu { TenViTri = "CM11", ToaDo = new Point(16, 113) },
        new ViTriCauThu { TenViTri = "CM12", ToaDo = new Point(100, 113) },
        new ViTriCauThu { TenViTri = "CM13", ToaDo = new Point(192, 113) },
        new ViTriCauThu { TenViTri = "CM14", ToaDo = new Point(290, 113) },
        new ViTriCauThu { TenViTri = "CB11", ToaDo = new Point(16, 216) },
        new ViTriCauThu { TenViTri = "CB12", ToaDo = new Point(100, 216) },
        new ViTriCauThu { TenViTri = "CB13", ToaDo = new Point(192, 216) },
        new ViTriCauThu { TenViTri = "CB14", ToaDo = new Point(290, 216) },
        new ViTriCauThu { TenViTri = "GK1", ToaDo = new Point(154, 319) }
    }},
    {"4-3-3", new ViTriCauThu[] {
        new ViTriCauThu { TenViTri = "ST11", ToaDo = new Point(154, 10) },
        new ViTriCauThu { TenViTri = "ST12", ToaDo = new Point(36, 10) },
        new ViTriCauThu { TenViTri = "ST13", ToaDo = new Point(273, 10) },
        new ViTriCauThu { TenViTri = "CM11", ToaDo = new Point(154, 113) },
        new ViTriCauThu { TenViTri = "CM12", ToaDo = new Point(36, 113) },
        new ViTriCauThu { TenViTri = "CM13", ToaDo = new Point(273, 113) },
        new ViTriCauThu { TenViTri = "CB11", ToaDo = new Point(16, 216) },
        new ViTriCauThu { TenViTri = "CB12", ToaDo = new Point(100, 216) },
        new ViTriCauThu { TenViTri = "CB13", ToaDo = new Point(192, 216) },
        new ViTriCauThu { TenViTri = "CB14", ToaDo = new Point(290, 216) },
        new ViTriCauThu { TenViTri = "GK1", ToaDo = new Point(154, 319) }
    }},
    {"3-5-2", new ViTriCauThu[] {
        new ViTriCauThu { TenViTri = "ST11", ToaDo = new Point(63, 0) },
        new ViTriCauThu { TenViTri = "ST12", ToaDo = new Point(243, 0) },
        new ViTriCauThu { TenViTri = "CM11", ToaDo = new Point(154, 36) },
        new ViTriCauThu { TenViTri = "CM12", ToaDo = new Point(16, 136) },
        new ViTriCauThu { TenViTri = "CM13", ToaDo = new Point(100, 136) },
        new ViTriCauThu { TenViTri = "CM14", ToaDo = new Point(192, 136) },
        new ViTriCauThu { TenViTri = "CM15", ToaDo = new Point(290, 136) },
        new ViTriCauThu { TenViTri = "CB11", ToaDo = new Point(154, 239) },
        new ViTriCauThu { TenViTri = "CB12", ToaDo = new Point(36, 239) },
        new ViTriCauThu { TenViTri = "CB13", ToaDo = new Point(273, 239) },
        new ViTriCauThu { TenViTri = "GK1", ToaDo = new Point(154, 342) }
    }}
};
        Dictionary<string, ViTriCauThu[]> soDoChienThuat2 = new Dictionary<string, ViTriCauThu[]>()
{
    {"4-4-2", new ViTriCauThu[] {
        new ViTriCauThu { TenViTri = "ST21", ToaDo = new Point(69, 10) },
        new ViTriCauThu { TenViTri = "ST22", ToaDo = new Point(249, 10) },
        new ViTriCauThu { TenViTri = "CM21", ToaDo = new Point(16, 113) },
        new ViTriCauThu { TenViTri = "CM22", ToaDo = new Point(100, 113) },
        new ViTriCauThu { TenViTri = "CM23", ToaDo = new Point(192, 113) },
        new ViTriCauThu { TenViTri = "CM24", ToaDo = new Point(290, 113) },
        new ViTriCauThu { TenViTri = "CB21", ToaDo = new Point(16, 216) },
        new ViTriCauThu { TenViTri = "CB22", ToaDo = new Point(100, 216) },
        new ViTriCauThu { TenViTri = "CB23", ToaDo = new Point(192, 216) },
        new ViTriCauThu { TenViTri = "CB24", ToaDo = new Point(290, 216) },
        new ViTriCauThu { TenViTri = "GK2", ToaDo = new Point(154, 319) }
    }},
    {"4-3-3", new ViTriCauThu[] {
        new ViTriCauThu { TenViTri = "ST21", ToaDo = new Point(154, 10) },
        new ViTriCauThu { TenViTri = "ST22", ToaDo = new Point(36, 10) },
        new ViTriCauThu { TenViTri = "ST23", ToaDo = new Point(273, 10) },
        new ViTriCauThu { TenViTri = "CM21", ToaDo = new Point(154, 113) },
        new ViTriCauThu { TenViTri = "CM22", ToaDo = new Point(36, 113) },
        new ViTriCauThu { TenViTri = "CM23", ToaDo = new Point(273, 113) },
        new ViTriCauThu { TenViTri = "CB21", ToaDo = new Point(16, 216) },
        new ViTriCauThu { TenViTri = "CB22", ToaDo = new Point(100, 216) },
        new ViTriCauThu { TenViTri = "CB23", ToaDo = new Point(192, 216) },
        new ViTriCauThu { TenViTri = "CB24", ToaDo = new Point(290, 216) },
        new ViTriCauThu { TenViTri = "GK2", ToaDo = new Point(154, 319) }
    }},
    {"3-5-2", new ViTriCauThu[] {
        new ViTriCauThu { TenViTri = "ST21", ToaDo = new Point(63, 0) },
        new ViTriCauThu { TenViTri = "ST22", ToaDo = new Point(243, 0) },
        new ViTriCauThu { TenViTri = "CM21", ToaDo = new Point(154, 36) },
        new ViTriCauThu { TenViTri = "CM22", ToaDo = new Point(16, 136) },
        new ViTriCauThu { TenViTri = "CM23", ToaDo = new Point(100, 136) },
        new ViTriCauThu { TenViTri = "CM24", ToaDo = new Point(192, 136) },
        new ViTriCauThu { TenViTri = "CM25", ToaDo = new Point(290, 136) },
        new ViTriCauThu { TenViTri = "CB21", ToaDo = new Point(154, 239) },
        new ViTriCauThu { TenViTri = "CB22", ToaDo = new Point(36, 239) },
        new ViTriCauThu { TenViTri = "CB23", ToaDo = new Point(273, 239) },
        new ViTriCauThu { TenViTri = "GK2", ToaDo = new Point(154, 342) }
    }}
};
        public static List<PlayerInfo> playerInfos1 = new List<PlayerInfo>();
        public static List<PlayerInfo> playerInfos2 = new List<PlayerInfo>();
        private void map1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            string soDoDuocChon = map1.SelectedItem.ToString();
            ViTriCauThu[] viTriCauThu = soDoChienThuat1[soDoDuocChon];

            foreach (var viTri in viTriCauThu)
            {
                Player cauThuControl = new Player();
                cauThuControl.Location = viTri.ToaDo;
                cauThuControl.Name = viTri.TenViTri;
                string imagePath1 = "";
                if (cauThuControl.Name == "ST11")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\9.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "ST12")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\7.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "ST13")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\11.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CM11")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\10.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CM12")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\6.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CM13")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\8.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CM14")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\12.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CM15")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\13.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CB11")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\2.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CB12")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\3.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CB13")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\4.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "CB14")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\5.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (cauThuControl.Name == "GK1")
                {
                    imagePath1 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\1.png";
                    cauThuControl.Image = Image.FromFile(imagePath1);
                }
                if (PieChartForm.p1 > 50)
                {
                    Random rand = new Random();
                    float minValue = 6.0f;
                    float maxValue = 10.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                else
                {
                    Random rand = new Random();
                    float minValue = 2.0f;
                    float maxValue = 6.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                playerInfos1.Add(new PlayerInfo(cauThuControl.Name, viTri.ToaDo, imagePath1, cauThuControl.Score));
                panel3.Controls.Add(cauThuControl);
            }
        }
        private void map2_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.Controls.Clear();

            string soDoDuocChon = map2.SelectedItem.ToString();
            ViTriCauThu[] viTriCauThu = soDoChienThuat2[soDoDuocChon];

            foreach (var viTri in viTriCauThu)
            {
                Player cauThuControl = new Player();
                cauThuControl.Location = viTri.ToaDo;
                cauThuControl.Name = viTri.TenViTri;
                string imagePath2 = "";
                if (cauThuControl.Name == "ST21")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\9.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "ST22")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\7.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "ST23")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\11.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CM21")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\10.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CM22")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\6.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CM23")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\8.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CM24")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\12.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CM25")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\13.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CB21")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\2.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CB22")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\3.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CB23")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\4.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "CB24")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\5.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if (cauThuControl.Name == "GK2")
                {
                    imagePath2 = "D:\\Do an C#\\FootBallManager\\FootBallManager\\Kit\\1.png";
                    cauThuControl.Image = Image.FromFile(imagePath2);
                }
                if(PieChartForm.p2 > 50)
                {
                    Random rand = new Random();
                    float minValue = 6.0f;
                    float maxValue = 10.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                else
                {
                    Random rand = new Random();
                    float minValue = 2.0f;
                    float maxValue = 6.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }                  
                playerInfos2.Add(new PlayerInfo(cauThuControl.Name, viTri.ToaDo, imagePath2, cauThuControl.Score));
                panel4.Controls.Add(cauThuControl);
            }
        }
        private int? teamAPercentage = null;


        private void Predict_Click(object sender, EventArgs e)
        {
            if (teamAPercentage == null)
            {
                Random rand = new Random();
                teamAPercentage = rand.Next(30, 71); // Random percentage for team A
                
            }

            using (PieChartForm pieChartForm = new PieChartForm(teamAPercentage.Value))
            {
                pieChartForm.ShowDialog(); // Show the pie chart form as a modal dialog
            }
            //PieChartForm.p1 = teamAPercentage ?? 0;
            //PieChartForm.p2 = 100 - teamAPercentage ?? 0;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            playerInfos1.Clear();
            playerInfos2.Clear();
        }
    }
}
