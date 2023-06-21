using EntityFramework_DBFirstYaklasimiOrnek.Models;

namespace EntityFramework_DBFirstYaklasimiOrnek
{
    public partial class Form1 : Form
    {
        //contex dosyamýzla nesne olusturuyoruz.
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();

            //FORM AÇILDIGI ANDA BÜTÜN BÖLGELERÝ GRÝDVÝEW VE LÝSTBOXTA GOSTER.
            var bolgeler = _db.Regions.ToList();
            lstBolgeler.DataSource = bolgeler;
            Listele();
         

        }

        private void Listele()
        {
            dgvBolgeler.DataSource = null;
            dgvBolgeler.DataSource = _db.Regions.OrderBy(b => b.RegionId).ToList();//region ýd ye göre sýraladýk
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Önce yeni bir region oluþturmamýz ve proplarýný da atamamýz lazým.
            // Sonra bu region'ý database'e ekleyip kaydetmemiz lazým.

            //eðer yazýlan ýd ye ait bölge varsa hata versin.
            if(_db.Regions.Find(Convert.ToInt32(textBox1.Text))!= null)
            // if(_db.Regions.FirstOrDefault(r=>r.RegionId== Convert.ToInt32(txtId.Text))!=null)
            //if(_db.Regions.Where(r=>r.RegionId== Convert.ToInt32(txtId.Text)).ToList()[0]!=null)
            // if (_db.Regions.Where(r => r.RegionId == Convert.ToInt32(txtId.Text)).ToList().ElementAt(0) != null)
            {
                
                MessageBox.Show("Ekleme calýþtýgýnýz ýd listede bulunuyor. Lütfen baska ID giriniz");
                return;
            }
            //FIND PRIMARY KEY DE KULLANILIR. ÝÇÝNE PRIMARY KEY ALIR.

            EntityFramework_DBFirstYaklasimiOrnek.Models.Region yenieklenenbolge = new EntityFramework_DBFirstYaklasimiOrnek.Models.Region();
            yenieklenenbolge.RegionId = Convert.ToInt32(textBox1.Text);
            yenieklenenbolge.RegionDescription = textBox2.Text;

            //bölgelere ekle database.
            _db.Regions.Add(yenieklenenbolge);

            //ve sonra kaydedelim kaydet demezsek anlýk bir ekleme olur.
            _db.SaveChanges();

            //tabloyu güncelleyelim ki ekleyince görelimm
            Listele();

            MessageBox.Show("Baþarýyla eklenmiþtir.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Id textbox'ýna yazýlan o ID'1i bölgeyi, yine taným textbox' ýna yazýlan yeni
            //deðerle güncellenecek.

            //ilk önce o ýd'ye ait olan bölgeyi veritabannýndan çekelimm
            EntityFramework_DBFirstYaklasimiOrnek.Models.Region guncellenecekBolge = _db.Regions.FirstOrDefault(r => r.RegionId == Convert.ToInt32(textBox1.Text));

            //.ektiðimiz bölgenin tanýmýný guncelle
            guncellenecekBolge.RegionDescription = textBox2.Text;

            _db.SaveChanges();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            //ýd textboxýna yazýlan o IDli bölgeyi silecek.
            EntityFramework_DBFirstYaklasimiOrnek.Models.Region silinecekBolge
                = _db.Regions.FirstOrDefault(r => r.RegionId == Convert.ToInt32(textBox1.Text));

            //önce o ýdye ait bölge var mý yokmu kontrol edelim:

            if(silinecekBolge == null)
            {
                MessageBox.Show("Silinecek bölge seçmediniz");
            }
            _db.Regions.Remove(silinecekBolge);
            _db.SaveChanges();
            Listele();
            MessageBox.Show("Baþarýyla silinmiþtir.");

        }
    }
}