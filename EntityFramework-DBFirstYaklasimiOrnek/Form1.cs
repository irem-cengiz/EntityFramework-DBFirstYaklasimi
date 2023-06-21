using EntityFramework_DBFirstYaklasimiOrnek.Models;

namespace EntityFramework_DBFirstYaklasimiOrnek
{
    public partial class Form1 : Form
    {
        //contex dosyam�zla nesne olusturuyoruz.
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();

            //FORM A�ILDIGI ANDA B�T�N B�LGELER� GR�DV�EW VE L�STBOXTA GOSTER.
            var bolgeler = _db.Regions.ToList();
            lstBolgeler.DataSource = bolgeler;
            Listele();
         

        }

        private void Listele()
        {
            dgvBolgeler.DataSource = null;
            dgvBolgeler.DataSource = _db.Regions.OrderBy(b => b.RegionId).ToList();//region �d ye g�re s�ralad�k
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //�nce yeni bir region olu�turmam�z ve proplar�n� da atamam�z laz�m.
            // Sonra bu region'� database'e ekleyip kaydetmemiz laz�m.

            //e�er yaz�lan �d ye ait b�lge varsa hata versin.
            if(_db.Regions.Find(Convert.ToInt32(textBox1.Text))!= null)
            // if(_db.Regions.FirstOrDefault(r=>r.RegionId== Convert.ToInt32(txtId.Text))!=null)
            //if(_db.Regions.Where(r=>r.RegionId== Convert.ToInt32(txtId.Text)).ToList()[0]!=null)
            // if (_db.Regions.Where(r => r.RegionId == Convert.ToInt32(txtId.Text)).ToList().ElementAt(0) != null)
            {
                
                MessageBox.Show("Ekleme cal��t�g�n�z �d listede bulunuyor. L�tfen baska ID giriniz");
                return;
            }
            //FIND PRIMARY KEY DE KULLANILIR. ���NE PRIMARY KEY ALIR.

            EntityFramework_DBFirstYaklasimiOrnek.Models.Region yenieklenenbolge = new EntityFramework_DBFirstYaklasimiOrnek.Models.Region();
            yenieklenenbolge.RegionId = Convert.ToInt32(textBox1.Text);
            yenieklenenbolge.RegionDescription = textBox2.Text;

            //b�lgelere ekle database.
            _db.Regions.Add(yenieklenenbolge);

            //ve sonra kaydedelim kaydet demezsek anl�k bir ekleme olur.
            _db.SaveChanges();

            //tabloyu g�ncelleyelim ki ekleyince g�relimm
            Listele();

            MessageBox.Show("Ba�ar�yla eklenmi�tir.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Id textbox'�na yaz�lan o ID'1i b�lgeyi, yine tan�m textbox' �na yaz�lan yeni
            //de�erle g�ncellenecek.

            //ilk �nce o �d'ye ait olan b�lgeyi veritabann�ndan �ekelimm
            EntityFramework_DBFirstYaklasimiOrnek.Models.Region guncellenecekBolge = _db.Regions.FirstOrDefault(r => r.RegionId == Convert.ToInt32(textBox1.Text));

            //.ekti�imiz b�lgenin tan�m�n� guncelle
            guncellenecekBolge.RegionDescription = textBox2.Text;

            _db.SaveChanges();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            //�d textbox�na yaz�lan o IDli b�lgeyi silecek.
            EntityFramework_DBFirstYaklasimiOrnek.Models.Region silinecekBolge
                = _db.Regions.FirstOrDefault(r => r.RegionId == Convert.ToInt32(textBox1.Text));

            //�nce o �dye ait b�lge var m� yokmu kontrol edelim:

            if(silinecekBolge == null)
            {
                MessageBox.Show("Silinecek b�lge se�mediniz");
            }
            _db.Regions.Remove(silinecekBolge);
            _db.SaveChanges();
            Listele();
            MessageBox.Show("Ba�ar�yla silinmi�tir.");

        }
    }
}