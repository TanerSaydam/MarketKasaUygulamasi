using Excel = Microsoft.Office.Interop.Excel;

namespace MarketKasaApp
{
    public partial class Form1 : Form
    {
        decimal toplam = 0;
        List<Sepet> sepetim = new List<Sepet>();
        Sepet sepet = new Sepet();
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplami();
        }

        void FisOlustur(string message)
        {
            Excel.Application excel = new Excel.Application();
            object Missing = Type.Missing;
            Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.Sheets[1];

            worksheet.Range["A1"].Value = "#";
            worksheet.Range["B1"].Value = "Ürün Adý";
            worksheet.Range["C1"].Value = "Adet";
            worksheet.Range["D1"].Value = "Birim Fiyatý";
            worksheet.Range["E1"].Value = "Toplam Tutar";

            worksheet.Range["A1"].ColumnWidth = 3.43;
            worksheet.Range["B1"].ColumnWidth = 13.29;
            worksheet.Range["C1"].ColumnWidth = 4.57;
            worksheet.Range["D1"].ColumnWidth = 10.57;
            worksheet.Range["E1"].ColumnWidth = 13.71;

            worksheet.Range["A1:E1"].Font.ColorIndex = 3;

            int rowCount = worksheet.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;

            rowCount++;
            for (int x = 0; x < sepetim.Count; x++)
            {
                worksheet.Range["A" + rowCount].Value = (x + 1);
                worksheet.Range["B" + rowCount].Value = sepetim[x].UrunAdi;
                worksheet.Range["C" + rowCount].Value = sepetim[x].Adet;
                worksheet.Range["D" + rowCount].Value = sepetim[x].BirimFiyati;
                worksheet.Range["E" + rowCount].Value = sepetim[x].Toplam;
                rowCount++;
            }

            worksheet.Range["A1:E" + (rowCount - 1)].Borders.LineStyle = 1;

            worksheet.Range["E" + rowCount].Formula = "=Sum(E2:E" + (rowCount - 1) + ")";
            worksheet.Range["E" + rowCount].Borders.LineStyle = 1;
            rowCount++;

            worksheet.Range["A" + rowCount].Value = message;
            worksheet.Range["A" + rowCount + ":E" + rowCount].MergeCells = true;
            worksheet.Range["A" + rowCount].HorizontalAlignment = 3;
            worksheet.Range["A" + rowCount].VerticalAlignment = 2;
            worksheet.Range["A" + rowCount].Font.ColorIndex = 3;
            worksheet.Range["A" + rowCount].Font.Bold = true;

            worksheet.Range["D2:E" + rowCount].NumberFormat = "#,##0.00";

            // worksheet.PrintOutEx();

            workbook.SaveAs(@"C:\1\Test.xlsx");

            excel.Visible = true;
        }

        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Coca Cola", 1, 17);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        void Form2Cagir(Sepet sepet)
        {
            form2 = new Form2(sepet);
            form2.Show();
            form2._form1 = this;
        }
        void BtnlariKapat()
        {
            bool status = false;
            gBAdet.Visible = true;
            btnCocaCola.Enabled = status;
            btnFanta.Enabled = status;
            btnDondurma.Enabled = status;
            btnDomates.Enabled = status;
            btnBiber.Enabled = status;
            btnPatlican.Enabled = status;
            btnNakit.Enabled = status;
            btnKrediKarti.Enabled = status;
        }

        void SepetiGoster()
        {
            dG1.DataSource = "";
            dG1.DataSource = sepetim;
            SepetToplami();
        }

        void SepetToplami()
        {
            toplam = 0;

            foreach (var item in sepetim)
            {
                toplam = item.Toplam + toplam;
            }
            lbToplam.Text = String.Format("{0:C2}", toplam);
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            sepet = new Sepet();
            sepet.UrunAdi = "Fanta";
            sepet.Adet = 1;
            sepet.BirimFiyati = 16;
            sepet.Toplam = sepet.Adet * sepet.BirimFiyati;
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnDondurma_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Dondurma", 1, 3);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnDomates_Click(object sender, EventArgs e)
        {
            sepet = new Sepet()
            {
                UrunAdi = "Domates",
                Adet = 1,
                BirimFiyati = 5,
                Toplam = 1 * 5
            };
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnBiber_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Biber", 1, 6);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnPatlican_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Patlýcan", 1, 7);
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            Vazgeç();
        }

        void Vazgeç()
        {
            txtAdet.Text = "1";
            bool status = true;
            gBAdet.Visible = false;
            btnCocaCola.Enabled = status;
            btnFanta.Enabled = status;
            btnDondurma.Enabled = status;
            btnDomates.Enabled = status;
            btnBiber.Enabled = status;
            btnPatlican.Enabled = status;
            btnNakit.Enabled = status;
            btnKrediKarti.Enabled = status;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SepeteUrunEkle();
        }

        public void SepeteUrunEkle(Sepet sepet)
        {
            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string urunAdi = dG1.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();

                if (MessageBox.Show($"{urunAdi} adli ürünü silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sepetim.RemoveAt(e.RowIndex);
                    SepetiGoster();
                }
            }
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler nakit olarak ödendi");
        }

        void MesajGoster(string message)
        {
            if (sepetim.Count > 0)
            {
                FisOlustur(message);
                return;
                sepetim = new List<Sepet>();
                SepetiGoster();
                MessageBox.Show(message, "Ödeme Yapýldý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sepetiniz boþ", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler kredi kartý ile ödendi");
        }
    }
}