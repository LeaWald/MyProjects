namespace UI
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlProd = new TabControl();
            tabPage1 = new TabPage();
            btnSave = new Button();
            nUDQuentity = new NumericUpDown();
            lblInsertQuentity = new Label();
            nUDprice = new NumericUpDown();
            lblInsertPrice = new Label();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            textInserName = new TextBox();
            lblInserName = new Label();
            tabPage2 = new TabPage();
            btnDelete = new Button();
            textCodeDelete = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            textupdateProd = new TextBox();
            label6 = new Label();
            btnSaveEdit = new Button();
            quentityEdit = new NumericUpDown();
            label2 = new Label();
            priceEdit = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            chooseCatgoEdit = new ComboBox();
            inserNameEdit = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            listSearch = new ListBox();
            button2 = new Button();
            lblfoundId = new Label();
            btnsearchById = new Button();
            searchId = new TextBox();
            button1 = new Button();
            listProd = new ListBox();
            btnListProd = new Button();
            label7 = new Label();
            editProducts = new Label();
            tabControlProd.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuentity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDprice).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quentityEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceEdit).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProd
            // 
            tabControlProd.Controls.Add(tabPage1);
            tabControlProd.Controls.Add(tabPage2);
            tabControlProd.Controls.Add(tabPage3);
            tabControlProd.Controls.Add(tabPage4);
            tabControlProd.Location = new Point(34, 79);
            tabControlProd.Name = "tabControlProd";
            tabControlProd.RightToLeft = RightToLeft.Yes;
            tabControlProd.RightToLeftLayout = true;
            tabControlProd.SelectedIndex = 0;
            tabControlProd.Size = new Size(868, 387);
            tabControlProd.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(nUDQuentity);
            tabPage1.Controls.Add(lblInsertQuentity);
            tabPage1.Controls.Add(nUDprice);
            tabPage1.Controls.Add(lblInsertPrice);
            tabPage1.Controls.Add(lblCategory);
            tabPage1.Controls.Add(cbCategory);
            tabPage1.Controls.Add(textInserName);
            tabPage1.Controls.Add(lblInserName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.Yes;
            tabPage1.Size = new Size(860, 354);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(458, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "שמירה";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nUDQuentity
            // 
            nUDQuentity.Location = new Point(321, 176);
            nUDQuentity.Name = "nUDQuentity";
            nUDQuentity.Size = new Size(84, 27);
            nUDQuentity.TabIndex = 7;
            // 
            // lblInsertQuentity
            // 
            lblInsertQuentity.AutoSize = true;
            lblInsertQuentity.Font = new Font("Segoe UI", 13F);
            lblInsertQuentity.Location = new Point(411, 173);
            lblInsertQuentity.Name = "lblInsertQuentity";
            lblInsertQuentity.Size = new Size(185, 30);
            lblInsertQuentity.TabIndex = 6;
            lblInsertQuentity.Text = "הכנס כמות במלאי";
            // 
            // nUDprice
            // 
            nUDprice.Location = new Point(388, 130);
            nUDprice.Name = "nUDprice";
            nUDprice.Size = new Size(84, 27);
            nUDprice.TabIndex = 5;
            // 
            // lblInsertPrice
            // 
            lblInsertPrice.AutoSize = true;
            lblInsertPrice.Font = new Font("Segoe UI", 13F);
            lblInsertPrice.Location = new Point(478, 124);
            lblInsertPrice.Name = "lblInsertPrice";
            lblInsertPrice.Size = new Size(118, 30);
            lblInsertPrice.TabIndex = 4;
            lblInsertPrice.Text = "הכנס מחיר";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13F);
            lblCategory.Location = new Point(458, 70);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(138, 30);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "בחר קטגוריה";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(255, 75);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(187, 28);
            cbCategory.TabIndex = 2;
            cbCategory.Text = "בנים";
            // 
            // textInserName
            // 
            textInserName.Location = new Point(308, 25);
            textInserName.Name = "textInserName";
            textInserName.Size = new Size(180, 27);
            textInserName.TabIndex = 1;
            // 
            // lblInserName
            // 
            lblInserName.AutoSize = true;
            lblInserName.Font = new Font("Segoe UI", 13F);
            lblInserName.Location = new Point(494, 22);
            lblInserName.Name = "lblInserName";
            lblInserName.Size = new Size(102, 30);
            lblInserName.TabIndex = 0;
            lblInserName.Text = "הכנס שם";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(textCodeDelete);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(860, 354);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(358, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 58);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "מחיקה";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textCodeDelete
            // 
            textCodeDelete.Location = new Point(270, 42);
            textCodeDelete.Name = "textCodeDelete";
            textCodeDelete.Size = new Size(119, 27);
            textCodeDelete.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 45);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס קוד מוצר למחיקה";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textupdateProd);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(btnSaveEdit);
            tabPage3.Controls.Add(quentityEdit);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(priceEdit);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(chooseCatgoEdit);
            tabPage3.Controls.Add(inserNameEdit);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(860, 354);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textupdateProd
            // 
            textupdateProd.Location = new Point(212, 23);
            textupdateProd.Name = "textupdateProd";
            textupdateProd.Size = new Size(129, 27);
            textupdateProd.TabIndex = 19;
            textupdateProd.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(347, 20);
            label6.Name = "label6";
            label6.Size = new Size(220, 30);
            label6.TabIndex = 18;
            label6.Text = "הכנס קוד מוצר לעדכון";
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveEdit.Location = new Point(432, 277);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(135, 43);
            btnSaveEdit.TabIndex = 17;
            btnSaveEdit.Text = "עדכון";
            btnSaveEdit.UseVisualStyleBackColor = true;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // quentityEdit
            // 
            quentityEdit.Location = new Point(295, 221);
            quentityEdit.Name = "quentityEdit";
            quentityEdit.Size = new Size(84, 27);
            quentityEdit.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(385, 218);
            label2.Name = "label2";
            label2.Size = new Size(185, 30);
            label2.TabIndex = 15;
            label2.Text = "הכנס כמות במלאי";
            // 
            // priceEdit
            // 
            priceEdit.Location = new Point(362, 175);
            priceEdit.Name = "priceEdit";
            priceEdit.Size = new Size(84, 27);
            priceEdit.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(452, 169);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 13;
            label3.Text = "הכנס מחיר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(432, 115);
            label4.Name = "label4";
            label4.Size = new Size(138, 30);
            label4.TabIndex = 12;
            label4.Text = "בחר קטגוריה";
            // 
            // chooseCatgoEdit
            // 
            chooseCatgoEdit.FormattingEnabled = true;
            chooseCatgoEdit.Location = new Point(229, 120);
            chooseCatgoEdit.Name = "chooseCatgoEdit";
            chooseCatgoEdit.Size = new Size(187, 28);
            chooseCatgoEdit.TabIndex = 11;
            // 
            // inserNameEdit
            // 
            inserNameEdit.Location = new Point(282, 70);
            inserNameEdit.Name = "inserNameEdit";
            inserNameEdit.Size = new Size(180, 27);
            inserNameEdit.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(468, 67);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 9;
            label5.Text = "הכנס שם";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listSearch);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(lblfoundId);
            tabPage4.Controls.Add(btnsearchById);
            tabPage4.Controls.Add(searchId);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(listProd);
            tabPage4.Controls.Add(btnListProd);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(860, 354);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "תצוגה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listSearch
            // 
            listSearch.FormattingEnabled = true;
            listSearch.Location = new Point(16, 103);
            listSearch.Name = "listSearch";
            listSearch.Size = new Size(189, 224);
            listSearch.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(16, 23);
            button2.Name = "button2";
            button2.Size = new Size(162, 55);
            button2.TabIndex = 8;
            button2.Text = "לסינון לפי מחיר נמוך מ50 שח";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblfoundId
            // 
            lblfoundId.AutoSize = true;
            lblfoundId.Location = new Point(396, 179);
            lblfoundId.Name = "lblfoundId";
            lblfoundId.Size = new Size(0, 20);
            lblfoundId.TabIndex = 7;
            // 
            // btnsearchById
            // 
            btnsearchById.Location = new Point(393, 125);
            btnsearchById.Name = "btnsearchById";
            btnsearchById.Size = new Size(126, 35);
            btnsearchById.TabIndex = 6;
            btnsearchById.Text = "חפש";
            btnsearchById.UseVisualStyleBackColor = true;
            btnsearchById.Click += btnsearchById_Click;
            // 
            // searchId
            // 
            searchId.Location = new Point(407, 75);
            searchId.Name = "searchId";
            searchId.Size = new Size(111, 27);
            searchId.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(396, 31);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 4;
            button1.Text = "לסינון לפי id:";
            button1.UseVisualStyleBackColor = true;
            // 
            // listProd
            // 
            listProd.FormattingEnabled = true;
            listProd.Location = new Point(630, 103);
            listProd.Name = "listProd";
            listProd.Size = new Size(202, 224);
            listProd.TabIndex = 3;
            // 
            // btnListProd
            // 
            btnListProd.Location = new Point(679, 31);
            btnListProd.Name = "btnListProd";
            btnListProd.Size = new Size(140, 55);
            btnListProd.TabIndex = 1;
            btnListProd.Text = "לרשימת המוצרים המלאה";
            btnListProd.UseVisualStyleBackColor = true;
            btnListProd.Click += btnListProd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(708, 16);
            label7.Name = "label7";
            label7.Size = new Size(13, 20);
            label7.TabIndex = 0;
            label7.Text = " ";
            // 
            // editProducts
            // 
            editProducts.AutoSize = true;
            editProducts.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            editProducts.Location = new Point(379, 21);
            editProducts.Name = "editProducts";
            editProducts.Size = new Size(177, 35);
            editProducts.TabIndex = 6;
            editProducts.Text = "עריכת מוצרים";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(editProducts);
            Controls.Add(tabControlProd);
            Name = "Product";
            Text = "Product";
            tabControlProd.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuentity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDprice).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quentityEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceEdit).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlProd;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label editProducts;
        private TextBox textInserName;
        private Label lblInserName;
        private ComboBox cbCategory;
        private Label lblCategory;
        private NumericUpDown nUDprice;
        private Label lblInsertPrice;
        private NumericUpDown nUDQuentity;
        private Label lblInsertQuentity;
        private Button btnSave;
        private Button btnDelete;
        private TextBox textCodeDelete;
        private Label label1;
        private TextBox textupdateProd;
        private Label label6;
        private Button btnSaveEdit;
        private NumericUpDown quentityEdit;
        private Label label2;
        private NumericUpDown priceEdit;
        private Label label3;
        private Label label4;
        private ComboBox chooseCatgoEdit;
        private TextBox inserNameEdit;
        private Label label5;
        private Label label7;
        private Button btnListProd;
        private ListBox listProd;
        private Label lblfoundId;
        private Button btnsearchById;
        private TextBox searchId;
        private Button button1;
        private ListBox listSearch;
        private Button button2;
    }
}