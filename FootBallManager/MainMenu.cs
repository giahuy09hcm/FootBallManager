
using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Xceed.Wpf.Toolkit;

namespace FootBallManager
{
    public partial class MainMenu : Form
    {

        private Form currentChildForm;

        public MainMenu()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }

        private void InitializeCustomComponents()
        {
            // Initialize buttons
            //InitializeButton(out btnHome, "Home", new Point(275, 111), new Size(952, 549), btnHome_Click);
            // InitializeButton(out btnAlbums, "Albums", new Point(275, 111), new Size(952, 549), btnAlbums_Click);
            //InitializeButton(out btnArtits, "Artists", new Point(275, 111), new Size(952, 549), btnArtits_Click);
            //InitializeButton(out btnDownloaded, "Downloaded", new Point(275, 111), new Size(952, 549), btnDownloaded_Click);
            //InitializeButton(out btnFavorite, "Favorites", new Point(275, 111), new Size(952, 549), btnFavorite_Click);
            //InitializeButton(out btnPlaylist, "Playlists", new Point(275, 111), new Size(952, 549), btnPlaylist_Click);
            //InitializeButton(out btnRecently, "Recently Played", new Point(275, 111), new Size(952, 549), btnRecently_Click);

            //InitializeButton(out btnSearch, "Search", new Point(275, 111), new Size(952, 549), btnSearch_Click);
        }

        private void InitializeButton(out Guna2GradientButton button, string text, Point location, Size size, EventHandler onClick)
        {
            button = new Guna2GradientButton();
            button.Text = text;
            button.Location = location; // Set button position
            button.Size = size; // Set button size
            button.Click += onClick;

            this.Controls.Add(button);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OpenChildForm(Form childForm)
        {
            // Close the current child form if it exists
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Set the new form as the current child form
            currentChildForm = childForm;

            // Set the child form properties
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the parent form's controls
            this.Controls.Add(childForm);
            this.Tag = childForm;

            // Bring the child form to the front and show it
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new HomeForm());
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new AlbumsForm());
        }

        private void btnArtits_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ArtitsForm());
        }

        private void btnDownloaded_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new DownloadedForm());
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FavoriteSongForm());
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new PlayListForm());
        }

        private void btnRecently_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {



        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
