namespace EntityFramework_Model_First
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_CategoryİD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_CategoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Description = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Picture = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Listele = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Ekle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Güncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Sil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(476, 12);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(402, 461);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // txt_CategoryİD
            // 
            this.txt_CategoryİD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_CategoryİD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CategoryİD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CategoryİD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CategoryİD.HintForeColor = System.Drawing.Color.Empty;
            this.txt_CategoryİD.HintText = "";
            this.txt_CategoryİD.isPassword = false;
            this.txt_CategoryİD.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_CategoryİD.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_CategoryİD.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_CategoryİD.LineThickness = 1;
            this.txt_CategoryİD.Location = new System.Drawing.Point(33, 47);
            this.txt_CategoryİD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CategoryİD.Name = "txt_CategoryİD";
            this.txt_CategoryİD.Size = new System.Drawing.Size(191, 33);
            this.txt_CategoryİD.TabIndex = 1;
            this.txt_CategoryİD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_CategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CategoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CategoryName.HintForeColor = System.Drawing.Color.Empty;
            this.txt_CategoryName.HintText = "";
            this.txt_CategoryName.isPassword = false;
            this.txt_CategoryName.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_CategoryName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_CategoryName.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_CategoryName.LineThickness = 1;
            this.txt_CategoryName.Location = new System.Drawing.Point(33, 97);
            this.txt_CategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(191, 33);
            this.txt_CategoryName.TabIndex = 2;
            this.txt_CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Description.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Description.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Description.HintText = "";
            this.txt_Description.isPassword = false;
            this.txt_Description.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_Description.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Description.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_Description.LineThickness = 1;
            this.txt_Description.Location = new System.Drawing.Point(33, 147);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(191, 33);
            this.txt_Description.TabIndex = 3;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Picture
            // 
            this.txt_Picture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Picture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Picture.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Picture.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Picture.HintText = "";
            this.txt_Picture.isPassword = false;
            this.txt_Picture.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_Picture.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Picture.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_Picture.LineThickness = 1;
            this.txt_Picture.Location = new System.Drawing.Point(33, 197);
            this.txt_Picture.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Picture.Name = "txt_Picture";
            this.txt_Picture.Size = new System.Drawing.Size(191, 33);
            this.txt_Picture.TabIndex = 4;
            this.txt_Picture.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox5.LineThickness = 1;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(33, 247);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(191, 33);
            this.bunifuMaterialTextbox5.TabIndex = 5;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Listele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Listele.BorderRadius = 0;
            this.btn_Listele.ButtonText = "Listele";
            this.btn_Listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Listele.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Listele.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Listele.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Listele.Iconimage")));
            this.btn_Listele.Iconimage_right = null;
            this.btn_Listele.Iconimage_right_Selected = null;
            this.btn_Listele.Iconimage_Selected = null;
            this.btn_Listele.IconMarginLeft = 0;
            this.btn_Listele.IconMarginRight = 0;
            this.btn_Listele.IconRightVisible = true;
            this.btn_Listele.IconRightZoom = 0D;
            this.btn_Listele.IconVisible = true;
            this.btn_Listele.IconZoom = 90D;
            this.btn_Listele.IsTab = false;
            this.btn_Listele.Location = new System.Drawing.Point(30, 347);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Listele.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Listele.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Listele.selected = false;
            this.btn_Listele.Size = new System.Drawing.Size(194, 36);
            this.btn_Listele.TabIndex = 6;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Listele.Textcolor = System.Drawing.Color.White;
            this.btn_Listele.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ekle.BorderRadius = 0;
            this.btn_Ekle.ButtonText = "Ekle";
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Ekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Ekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Iconimage")));
            this.btn_Ekle.Iconimage_right = null;
            this.btn_Ekle.Iconimage_right_Selected = null;
            this.btn_Ekle.Iconimage_Selected = null;
            this.btn_Ekle.IconMarginLeft = 0;
            this.btn_Ekle.IconMarginRight = 0;
            this.btn_Ekle.IconRightVisible = true;
            this.btn_Ekle.IconRightZoom = 0D;
            this.btn_Ekle.IconVisible = true;
            this.btn_Ekle.IconZoom = 90D;
            this.btn_Ekle.IsTab = false;
            this.btn_Ekle.Location = new System.Drawing.Point(30, 394);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Ekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Ekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ekle.selected = false;
            this.btn_Ekle.Size = new System.Drawing.Size(194, 36);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ekle.Textcolor = System.Drawing.Color.White;
            this.btn_Ekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Güncelle.BorderRadius = 0;
            this.btn_Güncelle.ButtonText = "Güncelle";
            this.btn_Güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Güncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Güncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Güncelle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Güncelle.Iconimage")));
            this.btn_Güncelle.Iconimage_right = null;
            this.btn_Güncelle.Iconimage_right_Selected = null;
            this.btn_Güncelle.Iconimage_Selected = null;
            this.btn_Güncelle.IconMarginLeft = 0;
            this.btn_Güncelle.IconMarginRight = 0;
            this.btn_Güncelle.IconRightVisible = true;
            this.btn_Güncelle.IconRightZoom = 0D;
            this.btn_Güncelle.IconVisible = true;
            this.btn_Güncelle.IconZoom = 90D;
            this.btn_Güncelle.IsTab = false;
            this.btn_Güncelle.Location = new System.Drawing.Point(230, 347);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Güncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Güncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Güncelle.selected = false;
            this.btn_Güncelle.Size = new System.Drawing.Size(194, 36);
            this.btn_Güncelle.TabIndex = 8;
            this.btn_Güncelle.Text = "Güncelle";
            this.btn_Güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Güncelle.Textcolor = System.Drawing.Color.White;
            this.btn_Güncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Güncelle.Click += new System.EventHandler(this.btn_Güncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sil.BorderRadius = 0;
            this.btn_Sil.ButtonText = "Sil";
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sil.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.Iconimage")));
            this.btn_Sil.Iconimage_right = null;
            this.btn_Sil.Iconimage_right_Selected = null;
            this.btn_Sil.Iconimage_Selected = null;
            this.btn_Sil.IconMarginLeft = 0;
            this.btn_Sil.IconMarginRight = 0;
            this.btn_Sil.IconRightVisible = true;
            this.btn_Sil.IconRightZoom = 0D;
            this.btn_Sil.IconVisible = true;
            this.btn_Sil.IconZoom = 90D;
            this.btn_Sil.IsTab = false;
            this.btn_Sil.Location = new System.Drawing.Point(230, 394);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Sil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Sil.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sil.selected = false;
            this.btn_Sil.Size = new System.Drawing.Size(194, 36);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.Textcolor = System.Drawing.Color.White;
            this.btn_Sil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(890, 485);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Güncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.bunifuMaterialTextbox5);
            this.Controls.Add(this.txt_Picture);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.txt_CategoryİD);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CategoryİD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CategoryName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Description;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Picture;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Listele;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ekle;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Güncelle;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sil;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

