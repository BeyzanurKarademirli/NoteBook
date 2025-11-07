namespace NoteBook
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcdeAcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acikTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koyuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ozelTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.boyutComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.renkButton = new System.Windows.Forms.ToolStripButton();
            this.yaziRengiButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.pcdeAcToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acToolStripMenuItem.Text = "Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // pcdeAcToolStripMenuItem
            // 
            this.pcdeAcToolStripMenuItem.Name = "pcdeAcToolStripMenuItem";
            this.pcdeAcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pcdeAcToolStripMenuItem.Text = "PC\'de Aç";
            this.pcdeAcToolStripMenuItem.Click += new System.EventHandler(this.pcdeAcToolStripMenuItem_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acikTemaToolStripMenuItem,
            this.koyuTemaToolStripMenuItem,
            this.ozelTemaToolStripMenuItem});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // acikTemaToolStripMenuItem
            // 
            this.acikTemaToolStripMenuItem.Name = "acikTemaToolStripMenuItem";
            this.acikTemaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acikTemaToolStripMenuItem.Text = "Açık Tema";
            this.acikTemaToolStripMenuItem.Click += new System.EventHandler(this.acikTemaToolStripMenuItem_Click);
            // 
            // koyuTemaToolStripMenuItem
            // 
            this.koyuTemaToolStripMenuItem.Name = "koyuTemaToolStripMenuItem";
            this.koyuTemaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.koyuTemaToolStripMenuItem.Text = "Koyu Tema";
            this.koyuTemaToolStripMenuItem.Click += new System.EventHandler(this.koyuTemaToolStripMenuItem_Click);
            // 
            // ozelTemaToolStripMenuItem
            // 
            this.ozelTemaToolStripMenuItem.Name = "ozelTemaToolStripMenuItem";
            this.ozelTemaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ozelTemaToolStripMenuItem.Text = "Özel Tema";
            this.ozelTemaToolStripMenuItem.Click += new System.EventHandler(this.ozelTemaToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontComboBox,
            this.boyutComboBox,
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.yaziRengiButton,
            this.renkButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // fontComboBox
            // 
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 25);
            this.fontComboBox.Text = "Arial";
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // boyutComboBox
            // 
            this.boyutComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "48",
            "72"});
            this.boyutComboBox.Name = "boyutComboBox";
            this.boyutComboBox.Size = new System.Drawing.Size(75, 25);
            this.boyutComboBox.Text = "12";
            this.boyutComboBox.SelectedIndexChanged += new System.EventHandler(this.boyutComboBox_SelectedIndexChanged);
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(23, 22);
            this.boldButton.Text = "B";
            this.boldButton.ToolTipText = "Kalın";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(23, 22);
            this.italicButton.Text = "I";
            this.italicButton.ToolTipText = "İtalik";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineButton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 22);
            this.underlineButton.Text = "U";
            this.underlineButton.ToolTipText = "Altı Çizili";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // renkButton
            // 
            this.renkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.renkButton.Name = "renkButton";
            this.renkButton.Size = new System.Drawing.Size(44, 22);
            this.renkButton.Text = "Arka Plan";
            this.renkButton.ToolTipText = "Arka Plan Rengi";
            this.renkButton.Click += new System.EventHandler(this.renkButton_Click);
            // 
            // yaziRengiButton
            // 
            this.yaziRengiButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.yaziRengiButton.Name = "yaziRengiButton";
            this.yaziRengiButton.Size = new System.Drawing.Size(58, 22);
            this.yaziRengiButton.Text = "Yazı Rengi";
            this.yaziRengiButton.ToolTipText = "Yazı Rengi";
            this.yaziRengiButton.BackColor = System.Drawing.Color.Black;
            this.yaziRengiButton.Click += new System.EventHandler(this.yaziRengiButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 628);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Hazır";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 49);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1000, 579);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|RTF Dosyaları (*.rtf)|*.rtf|Tüm Dosyalar (*.*)|*.*";
            this.openFileDialog.Title = "Dosya Aç";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|RTF Dosyaları (*.rtf)|*.rtf|Tüm Dosyalar (*.*)|*.*";
            this.saveFileDialog.Title = "Dosya Kaydet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Defteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pcdeAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acikTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koyuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ozelTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox fontComboBox;
        private System.Windows.Forms.ToolStripComboBox boyutComboBox;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripButton renkButton;
        private System.Windows.Forms.ToolStripButton yaziRengiButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

