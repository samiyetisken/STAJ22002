using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeknisyenAyarEkrani
{
    public class TeknisyenAyarForm : Form
    {
        public TeknisyenAyarForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlMakinaAyar = new System.Windows.Forms.Panel();
            this.lblMakinaAyar = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.lblHatSayisi = new System.Windows.Forms.Label();
            this.nudHatSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblKameraSayisi = new System.Windows.Forms.Label();
            this.nudKameraSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblCikisSayisi = new System.Windows.Forms.Label();
            this.nudCikisSayisi = new System.Windows.Forms.NumericUpDown();
            this.pnlKameraAyar = new System.Windows.Forms.Panel();
            this.lblKamera = new System.Windows.Forms.Label();
            this.cbKamera = new System.Windows.Forms.ComboBox();
            this.btnFotoYukle = new System.Windows.Forms.Button();
            this.lblBoyutX = new System.Windows.Forms.Label();
            this.nudBoyutX = new System.Windows.Forms.NumericUpDown();
            this.lblBoyutY = new System.Windows.Forms.Label();
            this.nudBoyutY = new System.Windows.Forms.NumericUpDown();
            this.lblKoordinatX = new System.Windows.Forms.Label();
            this.nudKoordinatX = new System.Windows.Forms.NumericUpDown();
            this.lblKoordinatY = new System.Windows.Forms.Label();
            this.nudKoordinatY = new System.Windows.Forms.NumericUpDown();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pnlMakinaAyar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHatSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKameraSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCikisSayisi)).BeginInit();
            this.pnlKameraAyar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoyutX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoyutY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoordinatX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoordinatY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMakinaAyar
            // 
            this.pnlMakinaAyar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMakinaAyar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMakinaAyar.Controls.Add(this.lblMakinaAyar);
            this.pnlMakinaAyar.Controls.Add(this.lblMusteri);
            this.pnlMakinaAyar.Controls.Add(this.txtMusteri);
            this.pnlMakinaAyar.Controls.Add(this.lblHatSayisi);
            this.pnlMakinaAyar.Controls.Add(this.nudHatSayisi);
            this.pnlMakinaAyar.Controls.Add(this.lblKameraSayisi);
            this.pnlMakinaAyar.Controls.Add(this.nudKameraSayisi);
            this.pnlMakinaAyar.Controls.Add(this.lblCikisSayisi);
            this.pnlMakinaAyar.Controls.Add(this.nudCikisSayisi);
            this.pnlMakinaAyar.Location = new System.Drawing.Point(20, 20);
            this.pnlMakinaAyar.Name = "pnlMakinaAyar";
            this.pnlMakinaAyar.Size = new System.Drawing.Size(350, 250);
            this.pnlMakinaAyar.TabIndex = 0;
            // 
            // lblMakinaAyar
            // 
            this.lblMakinaAyar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMakinaAyar.Location = new System.Drawing.Point(10, 10);
            this.lblMakinaAyar.Name = "lblMakinaAyar";
            this.lblMakinaAyar.Size = new System.Drawing.Size(100, 23);
            this.lblMakinaAyar.TabIndex = 0;
            this.lblMakinaAyar.Text = "MAKİNA AYAR";
            // 
            // lblMusteri
            // 
            this.lblMusteri.Location = new System.Drawing.Point(10, 50);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(100, 23);
            this.lblMusteri.TabIndex = 1;
            this.lblMusteri.Text = "MÜŞTERİ:";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(150, 50);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(150, 22);
            this.txtMusteri.TabIndex = 2;
            this.txtMusteri.Text = "Erdal Mak.";
            // 
            // lblHatSayisi
            // 
            this.lblHatSayisi.Location = new System.Drawing.Point(10, 90);
            this.lblHatSayisi.Name = "lblHatSayisi";
            this.lblHatSayisi.Size = new System.Drawing.Size(100, 23);
            this.lblHatSayisi.TabIndex = 3;
            this.lblHatSayisi.Text = "HAT SAYISI:";
            // 
            // nudHatSayisi
            // 
            this.nudHatSayisi.Location = new System.Drawing.Point(150, 90);
            this.nudHatSayisi.Name = "nudHatSayisi";
            this.nudHatSayisi.Size = new System.Drawing.Size(150, 22);
            this.nudHatSayisi.TabIndex = 4;
            this.nudHatSayisi.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblKameraSayisi
            // 
            this.lblKameraSayisi.Location = new System.Drawing.Point(10, 130);
            this.lblKameraSayisi.Name = "lblKameraSayisi";
            this.lblKameraSayisi.Size = new System.Drawing.Size(100, 23);
            this.lblKameraSayisi.TabIndex = 5;
            this.lblKameraSayisi.Text = "KAMERA SAYISI:";
            // 
            // nudKameraSayisi
            // 
            this.nudKameraSayisi.Location = new System.Drawing.Point(150, 130);
            this.nudKameraSayisi.Name = "nudKameraSayisi";
            this.nudKameraSayisi.Size = new System.Drawing.Size(150, 22);
            this.nudKameraSayisi.TabIndex = 6;
            this.nudKameraSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCikisSayisi
            // 
            this.lblCikisSayisi.Location = new System.Drawing.Point(10, 170);
            this.lblCikisSayisi.Name = "lblCikisSayisi";
            this.lblCikisSayisi.Size = new System.Drawing.Size(100, 23);
            this.lblCikisSayisi.TabIndex = 7;
            this.lblCikisSayisi.Text = "ÇIKIŞ SAYISI:";
            // 
            // nudCikisSayisi
            // 
            this.nudCikisSayisi.Location = new System.Drawing.Point(150, 170);
            this.nudCikisSayisi.Name = "nudCikisSayisi";
            this.nudCikisSayisi.Size = new System.Drawing.Size(150, 22);
            this.nudCikisSayisi.TabIndex = 8;
            this.nudCikisSayisi.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // pnlKameraAyar
            // 
            this.pnlKameraAyar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlKameraAyar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKameraAyar.Controls.Add(this.lblKamera);
            this.pnlKameraAyar.Controls.Add(this.cbKamera);
            this.pnlKameraAyar.Controls.Add(this.btnFotoYukle);
            this.pnlKameraAyar.Controls.Add(this.lblBoyutX);
            this.pnlKameraAyar.Controls.Add(this.nudBoyutX);
            this.pnlKameraAyar.Controls.Add(this.lblBoyutY);
            this.pnlKameraAyar.Controls.Add(this.nudBoyutY);
            this.pnlKameraAyar.Controls.Add(this.lblKoordinatX);
            this.pnlKameraAyar.Controls.Add(this.nudKoordinatX);
            this.pnlKameraAyar.Controls.Add(this.lblKoordinatY);
            this.pnlKameraAyar.Controls.Add(this.nudKoordinatY);
            this.pnlKameraAyar.Location = new System.Drawing.Point(20, 300);
            this.pnlKameraAyar.Name = "pnlKameraAyar";
            this.pnlKameraAyar.Size = new System.Drawing.Size(350, 250);
            this.pnlKameraAyar.TabIndex = 1;
            // 
            // lblKamera
            // 
            this.lblKamera.Location = new System.Drawing.Point(10, 10);
            this.lblKamera.Name = "lblKamera";
            this.lblKamera.Size = new System.Drawing.Size(100, 23);
            this.lblKamera.TabIndex = 0;
            this.lblKamera.Text = "Kamera";
            // 
            // cbKamera
            // 
            this.cbKamera.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbKamera.Location = new System.Drawing.Point(70, 10);
            this.cbKamera.Name = "cbKamera";
            this.cbKamera.Size = new System.Drawing.Size(121, 24);
            this.cbKamera.TabIndex = 1;
            // 
            // btnFotoYukle
            // 
            this.btnFotoYukle.Location = new System.Drawing.Point(220, 10);
            this.btnFotoYukle.Name = "btnFotoYukle";
            this.btnFotoYukle.Size = new System.Drawing.Size(100, 30);
            this.btnFotoYukle.TabIndex = 2;
            this.btnFotoYukle.Text = "Foto Yükle";
            // 
            // lblBoyutX
            // 
            this.lblBoyutX.Location = new System.Drawing.Point(10, 60);
            this.lblBoyutX.Name = "lblBoyutX";
            this.lblBoyutX.Size = new System.Drawing.Size(100, 23);
            this.lblBoyutX.TabIndex = 3;
            this.lblBoyutX.Text = "Boyut X:";
            // 
            // nudBoyutX
            // 
            this.nudBoyutX.Location = new System.Drawing.Point(70, 60);
            this.nudBoyutX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBoyutX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBoyutX.Name = "nudBoyutX";
            this.nudBoyutX.Size = new System.Drawing.Size(120, 22);
            this.nudBoyutX.TabIndex = 4;
            this.nudBoyutX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblBoyutY
            // 
            this.lblBoyutY.Location = new System.Drawing.Point(150, 60);
            this.lblBoyutY.Name = "lblBoyutY";
            this.lblBoyutY.Size = new System.Drawing.Size(100, 23);
            this.lblBoyutY.TabIndex = 5;
            this.lblBoyutY.Text = "Boyut Y:";
            // 
            // nudBoyutY
            // 
            this.nudBoyutY.Location = new System.Drawing.Point(200, 60);
            this.nudBoyutY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBoyutY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBoyutY.Name = "nudBoyutY";
            this.nudBoyutY.Size = new System.Drawing.Size(120, 22);
            this.nudBoyutY.TabIndex = 6;
            this.nudBoyutY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblKoordinatX
            // 
            this.lblKoordinatX.Location = new System.Drawing.Point(119, 148);
            this.lblKoordinatX.Name = "lblKoordinatX";
            this.lblKoordinatX.Size = new System.Drawing.Size(100, 23);
            this.lblKoordinatX.TabIndex = 7;
            this.lblKoordinatX.Text = "Koordinat X:";
            // 
            // nudKoordinatX
            // 
            this.nudKoordinatX.Location = new System.Drawing.Point(225, 148);
            this.nudKoordinatX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKoordinatX.Name = "nudKoordinatX";
            this.nudKoordinatX.Size = new System.Drawing.Size(120, 22);
            this.nudKoordinatX.TabIndex = 8;
            this.nudKoordinatX.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // lblKoordinatY
            // 
            this.lblKoordinatY.Location = new System.Drawing.Point(120, 185);
            this.lblKoordinatY.Name = "lblKoordinatY";
            this.lblKoordinatY.Size = new System.Drawing.Size(100, 23);
            this.lblKoordinatY.TabIndex = 9;
            this.lblKoordinatY.Text = "Koordinat Y:";
            // 
            // nudKoordinatY
            // 
            this.nudKoordinatY.Location = new System.Drawing.Point(225, 186);
            this.nudKoordinatY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKoordinatY.Name = "nudKoordinatY";
            this.nudKoordinatY.Size = new System.Drawing.Size(120, 22);
            this.nudKoordinatY.TabIndex = 10;
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(400, 20);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(500, 400);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 2;
            this.pbResim.TabStop = false;
            // 
            // lblBilgi
            // 
            this.lblBilgi.Location = new System.Drawing.Point(400, 430);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(500, 30);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "Ürünler 2 sıra halinde aşağıdan yukarı doğru hareket etmeli.";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(20, 620);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 50);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.LightGray;
            this.btnKapat.Location = new System.Drawing.Point(200, 620);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(150, 50);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // TeknisyenAyarForm
            // 
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.pnlMakinaAyar);
            this.Controls.Add(this.pnlKameraAyar);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKapat);
            this.Name = "TeknisyenAyarForm";
            this.Text = "TEKNİSYEN AYAR EKRANI";
            this.pnlMakinaAyar.ResumeLayout(false);
            this.pnlMakinaAyar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHatSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKameraSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCikisSayisi)).EndInit();
            this.pnlKameraAyar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBoyutX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoyutY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoordinatX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKoordinatY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TeknisyenAyarForm());
        }

        private Panel pnlMakinaAyar;
        private Label lblMakinaAyar;
        private Label lblMusteri;
        private TextBox txtMusteri;
        private Label lblHatSayisi;
        private NumericUpDown nudHatSayisi;
        private Label lblKameraSayisi;
        private NumericUpDown nudKameraSayisi;
        private Label lblCikisSayisi;
        private NumericUpDown nudCikisSayisi;
        private Panel pnlKameraAyar;
        private Label lblKamera;
        private ComboBox cbKamera;
        private Button btnFotoYukle;
        private Label lblBoyutX;
        private NumericUpDown nudBoyutX;
        private Label lblBoyutY;
        private NumericUpDown nudBoyutY;
        private Label lblKoordinatX;
        private NumericUpDown nudKoordinatX;
        private Label lblKoordinatY;
        private NumericUpDown nudKoordinatY;
        private PictureBox pbResim;
        private Label lblBilgi;
        private Button btnKaydet;
        private Button btnKapat;
    }
}
