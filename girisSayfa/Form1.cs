using System;
using System.Windows.Forms;

namespace girisForm
{
    public partial class LoginForm : Form
    {
        private Button loginButton;
        private Button closeButton;
        private MenuStrip menuStrip;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Erdal Mak.";
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Arka plan rengini ayarladık
            this.BackColor = System.Drawing.Color.Teal;

            // MenuStrip oluşturma
            menuStrip = new MenuStrip();
            menuStrip.Dock = DockStyle.Top; 
            this.Controls.Add(menuStrip);

            // Menü seçenekleri ekleme
            ToolStripMenuItem islemMenuItem = new ToolStripMenuItem("İŞLEMLER");
            ToolStripMenuItem ayarlarMenuItem = new ToolStripMenuItem("AYARLAR");
            ToolStripMenuItem recetelerMenuItem = new ToolStripMenuItem("REÇETELER");
            ToolStripMenuItem cikisMenuItem = new ToolStripMenuItem("ÇIKIŞ");

            menuStrip.Items.Add(islemMenuItem);
            menuStrip.Items.Add(ayarlarMenuItem);
            menuStrip.Items.Add(recetelerMenuItem);
            menuStrip.Items.Add(cikisMenuItem);

            // Formun MenuStrip'i ayarlandı
            this.MainMenuStrip = menuStrip;

            // Başlık etiketi ekleme
            Label titleLabel = new Label();
            titleLabel.Text = "BOYLAMA MAKİNASI KULLANICI GİRİŞ EKRANI";
            titleLabel.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(150, 50);  
            this.Controls.Add(titleLabel);

            // Kullanıcı Adı etiketi
            Label userLabel = new Label();
            userLabel.Text = "KULLANICI ADI";
            userLabel.Location = new System.Drawing.Point(100, 100);
            this.Controls.Add(userLabel);

            // Kullanıcı Adı TextBox'u
            TextBox userTextBox = new TextBox();
            userTextBox.Location = new System.Drawing.Point(220, 95);
            this.Controls.Add(userTextBox);

            // Şifre etiketi
            Label passwordLabel = new Label();
            passwordLabel.Text = "ŞİFRE";
            passwordLabel.Location = new System.Drawing.Point(100, 150);
            this.Controls.Add(passwordLabel);

            // Şifre TextBox'u
            TextBox passwordTextBox = new TextBox();
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.Location = new System.Drawing.Point(220, 145);
            this.Controls.Add(passwordTextBox);

            // Giriş Yap butonu
            loginButton = new Button();
            loginButton.Text = "GİRİŞ YAP";
            loginButton.Location = new System.Drawing.Point(150, 200);
            loginButton.BackColor = System.Drawing.Color.White;
            this.Controls.Add(loginButton);

            // Kapat butonu
            closeButton = new Button();
            closeButton.Text = "KAPAT";
            closeButton.Location = new System.Drawing.Point(300, 200);
            closeButton.BackColor = System.Drawing.Color.White;
            this.Controls.Add(closeButton);

            // Durum etiketi
            Label statusLabel = new Label();
            statusLabel.Text = "1 nolu yetki ile giriş yapıldı.";
            statusLabel.Font = new System.Drawing.Font("Arial", 10);
            statusLabel.ForeColor = System.Drawing.Color.Green;
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(150, 250);
            this.Controls.Add(statusLabel);

            // Resim ekleme
            PictureBox pictureBox = new PictureBox();
            pictureBox.ImageLocation = "path_to_image.jpg"; 
            pictureBox.Size = new System.Drawing.Size(250, 100);
            pictureBox.Location = new System.Drawing.Point(350, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            
            loginButton.Click += LoginButton_Click;
            closeButton.Click += CloseButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 nolu yetki ile giriş yapıldı.");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
