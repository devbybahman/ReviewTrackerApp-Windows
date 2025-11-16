using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;


namespace PdfTracker
{
    public partial class Form1 : Form
    {

        private static readonly string AppDataFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ReviewTrackerApp");
        private static readonly string DataFileName = Path.Combine(AppDataFolder, "pdf_review_data.json");

        private List<PdfItem> _pdfItems = new List<PdfItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            RefreshPdfList();
        }

        private void LoadData()
        {
            if (!File.Exists(DataFileName))
            {
                _pdfItems = new List<PdfItem>();
                return;
            }

            try
            {
                string json = File.ReadAllText(DataFileName);
                _pdfItems = JsonSerializer.Deserialize<List<PdfItem>>(json) ?? new List<PdfItem>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در خواندن فایل داده: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _pdfItems = new List<PdfItem>();
            }
        }
        private void SaveData()
        {
            try
            {
            
                Directory.CreateDirectory(AppDataFolder);

                var options = new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                string json = JsonSerializer.Serialize(_pdfItems, options);
                File.WriteAllText(DataFileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره فایل داده: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshPdfList()
        {
            pnlPdfList.Controls.Clear();

            var sortedList = _pdfItems.OrderByDescending(item => item.Count).ToList();

            foreach (var item in sortedList)
            {
               
                var rowPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    Height = 40,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

               
                var plusOneButton = new Button
                {
                    Text = "+1",
                    Dock = DockStyle.Left,
                    Width = 40,
                    Font = new Font("Tahoma", 8F, FontStyle.Bold)
                };
               
                plusOneButton.Click += (s, e) => { IncrementReview(item); };

               
                var infoLabel = new Label
                {
                    Text = $"{item.Name}  |  تعداد مرور: {item.Count}",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleRight,
                    Padding = new Padding(0, 0, 10, 0),
                    RightToLeft = RightToLeft.Yes
                };

                rowPanel.Controls.Add(infoLabel);
                rowPanel.Controls.Add(plusOneButton);

                pnlPdfList.Controls.Add(rowPanel);
            }
        }
        private void IncrementReview(PdfItem itemToUpdate)
        {
            itemToUpdate.Count++;
            SaveData();
            RefreshPdfList();
        }



        private void btnAddPdf_Click(object sender, EventArgs e)
        {
            string newName = txtNewPdfName.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("لطفاً یک نام برای PDF وارد کنید.", "ورودی نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_pdfItems.Any(item => item.Name.Equals(newName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("این PDF قبلاً در لیست وجود دارد.", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _pdfItems.Add(new PdfItem { Name = newName, Count = 0 });
            SaveData();
            RefreshPdfList();
            txtNewPdfName.Clear();
            txtNewPdfName.Focus();
        }
    }
}
    
