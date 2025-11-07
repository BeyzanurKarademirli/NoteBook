using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Türkçe karakter desteği için kültür ayarları
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            
            // Yazı tiplerini ComboBox'a yükle
            LoadFonts();
            fontComboBox.SelectedItem = "Arial";
            boyutComboBox.SelectedItem = "12";
            
            // RichTextBox için Türkçe klavye desteği
            // RichTextBox varsayılan olarak sistem klavye düzenini kullanır
            
            // Varsayılan tema
            ApplyLightTheme();
        }

        private void LoadFonts()
        {
            fontComboBox.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }
        }

        #region Dosya İşlemleri

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentFilePath = openFileDialog.FileName;
                    
                    if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                    {
                        richTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // UTF-8 encoding ile dosya açma (Türkçe karakter desteği)
                        // Auto-detect encoding (UTF-8, UTF-8 BOM, Windows-1254, vb.)
                        using (FileStream fs = new FileStream(currentFilePath, FileMode.Open, FileAccess.Read))
                        {
                            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8, true))
                            {
                                richTextBox.Text = reader.ReadToEnd();
                            }
                        }
                    }
                    
                    this.Text = "Not Defteri - " + Path.GetFileName(currentFilePath);
                    statusLabel.Text = "Dosya açıldı: " + currentFilePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açılırken hata oluştu: " + ex.Message, "Hata", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {
                if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                {
                    richTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // UTF-8 BOM ile dosya kaydetme (Türkçe karakter desteği)
                    // UTF-8 BOM Windows Notepad ile uyumlu olması için
                    Encoding utf8WithBom = new UTF8Encoding(true);
                    using (StreamWriter writer = new StreamWriter(currentFilePath, false, utf8WithBom))
                    {
                        writer.Write(richTextBox.Text);
                    }
                }
                
                this.Text = "Not Defteri - " + Path.GetFileName(currentFilePath);
                statusLabel.Text = "Dosya kaydedildi: " + currentFilePath;
                MessageBox.Show("Dosya başarıyla kaydedildi!", "Bilgi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya kaydedilirken hata oluştu: " + ex.Message, "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcdeAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("Önce bir dosya açmalısınız!", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (File.Exists(currentFilePath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = currentFilePath,
                        UseShellExecute = true
                    });
                    statusLabel.Text = "Dosya PC'de açıldı: " + currentFilePath;
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı!", "Hata", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya açılırken hata oluştu: " + ex.Message, "Hata", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metin Formatlama

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateFormattingButtons();
        }

        private void UpdateFormattingButtons()
        {
            Font currentFont = richTextBox.SelectionFont;
            if (currentFont != null)
            {
                boldButton.Checked = currentFont.Bold;
                italicButton.Checked = currentFont.Italic;
                underlineButton.Checked = currentFont.Underline;
                
                if (fontComboBox.Items.Contains(currentFont.FontFamily.Name))
                {
                    fontComboBox.SelectedItem = currentFont.FontFamily.Name;
                }
                
                boyutComboBox.Text = ((int)currentFont.Size).ToString();
                yaziRengiButton.BackColor = richTextBox.SelectionColor;
            }
            else
            {
                // Seçim yoksa, varsayılan font bilgilerini göster
                boldButton.Checked = richTextBox.Font.Bold;
                italicButton.Checked = richTextBox.Font.Italic;
                underlineButton.Checked = richTextBox.Font.Underline;
                
                if (fontComboBox.Items.Contains(richTextBox.Font.FontFamily.Name))
                {
                    fontComboBox.SelectedItem = richTextBox.Font.FontFamily.Name;
                }
                
                boyutComboBox.Text = ((int)richTextBox.Font.Size).ToString();
                yaziRengiButton.BackColor = richTextBox.ForeColor;
            }
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontComboBox.SelectedItem == null) return;
            
            string fontName = fontComboBox.SelectedItem.ToString();
            float fontSize = 12;
            FontStyle style = FontStyle.Regular;
            
            if (richTextBox.SelectionLength > 0)
            {
                if (richTextBox.SelectionFont != null)
                {
                    fontSize = richTextBox.SelectionFont.Size;
                    style = richTextBox.SelectionFont.Style;
                }
                else if (!string.IsNullOrEmpty(boyutComboBox.Text))
                {
                    float.TryParse(boyutComboBox.Text, out fontSize);
                }
                
                richTextBox.SelectionFont = new Font(fontName, fontSize, style);
            }
            else
            {
                // Seçim yoksa, varsayılan fontu değiştir
                if (richTextBox.Font != null)
                {
                    fontSize = richTextBox.Font.Size;
                    style = richTextBox.Font.Style;
                }
                else if (!string.IsNullOrEmpty(boyutComboBox.Text))
                {
                    float.TryParse(boyutComboBox.Text, out fontSize);
                }
                
                richTextBox.Font = new Font(fontName, fontSize, style);
            }
        }

        private void boyutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boyutComboBox.Text)) return;
            
            float fontSize;
            if (!float.TryParse(boyutComboBox.Text, out fontSize)) return;
            
            string fontName = "Arial";
            FontStyle style = FontStyle.Regular;
            
            if (richTextBox.SelectionLength > 0)
            {
                if (richTextBox.SelectionFont != null)
                {
                    fontName = richTextBox.SelectionFont.FontFamily.Name;
                    style = richTextBox.SelectionFont.Style;
                }
                richTextBox.SelectionFont = new Font(fontName, fontSize, style);
            }
            else
            {
                if (richTextBox.Font != null)
                {
                    fontName = richTextBox.Font.FontFamily.Name;
                    style = richTextBox.Font.Style;
                }
                richTextBox.Font = new Font(fontName, fontSize, style);
            }
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newStyle = currentFont.Style;
                
                if (currentFont.Bold)
                {
                    newStyle &= ~FontStyle.Bold;
                }
                else
                {
                    newStyle |= FontStyle.Bold;
                }
                
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
            else
            {
                // Seçim yoksa, sonraki yazılacak metin için ayarla
                Font currentFont = richTextBox.Font;
                FontStyle newStyle = currentFont.Bold ? (currentFont.Style & ~FontStyle.Bold) : (currentFont.Style | FontStyle.Bold);
                richTextBox.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newStyle = currentFont.Style;
                
                if (currentFont.Italic)
                {
                    newStyle &= ~FontStyle.Italic;
                }
                else
                {
                    newStyle |= FontStyle.Italic;
                }
                
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
            else
            {
                Font currentFont = richTextBox.Font;
                FontStyle newStyle = currentFont.Italic ? (currentFont.Style & ~FontStyle.Italic) : (currentFont.Style | FontStyle.Italic);
                richTextBox.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newStyle = currentFont.Style;
                
                if (currentFont.Underline)
                {
                    newStyle &= ~FontStyle.Underline;
                }
                else
                {
                    newStyle |= FontStyle.Underline;
                }
                
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
            else
            {
                Font currentFont = richTextBox.Font;
                FontStyle newStyle = currentFont.Underline ? (currentFont.Style & ~FontStyle.Underline) : (currentFont.Style | FontStyle.Underline);
                richTextBox.Font = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void yaziRengiButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = richTextBox.SelectionColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectionLength > 0)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                }
                else
                {
                    richTextBox.ForeColor = colorDialog.Color;
                }
                yaziRengiButton.BackColor = colorDialog.Color;
            }
        }

        private void renkButton_Click(object sender, EventArgs e)
        {
            colorDialog.Color = richTextBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.BackColor = colorDialog.Color;
            }
        }

        #endregion

        #region Tema İşlemleri

        private void acikTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyLightTheme();
        }

        private void koyuTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyDarkTheme();
        }

        private void ozelTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyCustomTheme();
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.White;
            richTextBox.BackColor = Color.White;
            richTextBox.ForeColor = Color.Black;
            menuStrip.BackColor = Color.WhiteSmoke;
            toolStrip.BackColor = Color.WhiteSmoke;
            statusStrip.BackColor = Color.WhiteSmoke;
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = "Açık tema uygulandı";
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox.BackColor = Color.FromArgb(40, 40, 40);
            richTextBox.ForeColor = Color.White;
            menuStrip.BackColor = Color.FromArgb(45, 45, 45);
            toolStrip.BackColor = Color.FromArgb(45, 45, 45);
            statusStrip.BackColor = Color.FromArgb(45, 45, 45);
            statusLabel.ForeColor = Color.White;
            statusLabel.Text = "Koyu tema uygulandı";
        }

        private void ApplyCustomTheme()
        {
            ColorDialog themeDialog = new ColorDialog();
            themeDialog.Color = this.BackColor;
            
            if (themeDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = themeDialog.Color;
                
                // Arka plan rengini ayarla
                this.BackColor = selectedColor;
                richTextBox.BackColor = Color.FromArgb(
                    Math.Min(255, selectedColor.R + 10),
                    Math.Min(255, selectedColor.G + 10),
                    Math.Min(255, selectedColor.B + 10));
                
                // Kontrast metin rengi
                int brightness = (selectedColor.R + selectedColor.G + selectedColor.B) / 3;
                Color textColor = brightness > 128 ? Color.Black : Color.White;
                
                richTextBox.ForeColor = textColor;
                statusLabel.ForeColor = textColor;
                
                // Menü ve toolbar için biraz daha koyu ton
                menuStrip.BackColor = Color.FromArgb(
                    Math.Max(0, selectedColor.R - 20),
                    Math.Max(0, selectedColor.G - 20),
                    Math.Max(0, selectedColor.B - 20));
                toolStrip.BackColor = menuStrip.BackColor;
                statusStrip.BackColor = menuStrip.BackColor;
                
                statusLabel.Text = "Özel tema uygulandı";
            }
        }

        #endregion
    }
}
