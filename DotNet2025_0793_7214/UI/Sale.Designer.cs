namespace UI
{
    partial class Sale
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
            editSales = new Label();
            tabControlProd = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBoxClub = new CheckBox();
            btnSave = new Button();
            nUDQuentityToSale = new NumericUpDown();
            lblInsertQuentity = new Label();
            nUDprice = new NumericUpDown();
            lblInsertPrice = new Label();
            textInserCode = new TextBox();
            lblIsertCode = new Label();
            tabPage2 = new TabPage();
            btnDelete = new Button();
            textCodeDelete = new TextBox();
            label3 = new Label();
            tabPage3 = new TabPage();
            textCodeUd = new TextBox();
            label9 = new Label();
            label4 = new Label();
            dateTimePickerF = new DateTimePicker();
            label5 = new Label();
            dateTimePickerS = new DateTimePicker();
            checkBox1club = new CheckBox();
            buttonUpdate = new Button();
            nUDQuentity = new NumericUpDown();
            label6 = new Label();
            price = new NumericUpDown();
            label7 = new Label();
            textCode = new TextBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            listSearch = new ListBox();
            button2 = new Button();
            lblfoundId = new Label();
            btnsearchById = new Button();
            searchId = new TextBox();
            button1 = new Button();
            listSales = new ListBox();
            btnListProd = new Button();
            tabControlProd.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuentityToSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDprice).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuentity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // editSales
            // 
            editSales.AutoSize = true;
            editSales.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            editSales.Location = new Point(379, 23);
            editSales.Name = "editSales";
            editSales.Size = new Size(185, 35);
            editSales.TabIndex = 8;
            editSales.Text = "עריכת מבצעים";
            // 
            // tabControlProd
            // 
            tabControlProd.Controls.Add(tabPage1);
            tabControlProd.Controls.Add(tabPage2);
            tabControlProd.Controls.Add(tabPage3);
            tabControlProd.Controls.Add(tabPage4);
            tabControlProd.Location = new Point(32, 81);
            tabControlProd.Name = "tabControlProd";
            tabControlProd.RightToLeft = RightToLeft.Yes;
            tabControlProd.RightToLeftLayout = true;
            tabControlProd.SelectedIndex = 0;
            tabControlProd.Size = new Size(857, 387);
            tabControlProd.TabIndex = 7;
            tabControlProd.SelectedIndexChanged += tabControlProd_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(checkBoxClub);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(nUDQuentityToSale);
            tabPage1.Controls.Add(lblInsertQuentity);
            tabPage1.Controls.Add(nUDprice);
            tabPage1.Controls.Add(lblInsertPrice);
            tabPage1.Controls.Add(textInserCode);
            tabPage1.Controls.Add(lblIsertCode);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.Yes;
            tabPage1.Size = new Size(849, 354);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(540, 257);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 22;
            label2.Text = "תאריך סיום המבצע";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(292, 263);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(233, 27);
            dateTimePicker2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(522, 209);
            label1.Name = "label1";
            label1.Size = new Size(218, 30);
            label1.TabIndex = 20;
            label1.Text = "תאריך תחילת המבצע";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(274, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // checkBoxClub
            // 
            checkBoxClub.AutoSize = true;
            checkBoxClub.Font = new Font("Segoe UI", 13F);
            checkBoxClub.Location = new Point(442, 169);
            checkBoxClub.Name = "checkBoxClub";
            checkBoxClub.Size = new Size(294, 34);
            checkBoxClub.TabIndex = 18;
            checkBoxClub.Text = "האם ללקוחות מועדון בלבד?";
            checkBoxClub.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(39, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 43);
            btnSave.TabIndex = 17;
            btnSave.Text = "שמירה";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nUDQuentityToSale
            // 
            nUDQuentityToSale.Location = new Point(370, 85);
            nUDQuentityToSale.Name = "nUDQuentityToSale";
            nUDQuentityToSale.Size = new Size(84, 27);
            nUDQuentityToSale.TabIndex = 16;
            // 
            // lblInsertQuentity
            // 
            lblInsertQuentity.AutoSize = true;
            lblInsertQuentity.Font = new Font("Segoe UI", 13F);
            lblInsertQuentity.Location = new Point(460, 82);
            lblInsertQuentity.Name = "lblInsertQuentity";
            lblInsertQuentity.Size = new Size(281, 30);
            lblInsertQuentity.TabIndex = 15;
            lblInsertQuentity.Text = "כמות נדרשת לקבלת המבצע";
            // 
            // nUDprice
            // 
            nUDprice.Location = new Point(532, 130);
            nUDprice.Name = "nUDprice";
            nUDprice.Size = new Size(84, 27);
            nUDprice.TabIndex = 14;
            // 
            // lblInsertPrice
            // 
            lblInsertPrice.AutoSize = true;
            lblInsertPrice.Font = new Font("Segoe UI", 13F);
            lblInsertPrice.Location = new Point(622, 124);
            lblInsertPrice.Name = "lblInsertPrice";
            lblInsertPrice.Size = new Size(118, 30);
            lblInsertPrice.TabIndex = 13;
            lblInsertPrice.Text = "הכנס מחיר";
            // 
            // textInserCode
            // 
            textInserCode.Location = new Point(320, 41);
            textInserCode.Name = "textInserCode";
            textInserCode.Size = new Size(180, 27);
            textInserCode.TabIndex = 10;
            // 
            // lblIsertCode
            // 
            lblIsertCode.AutoSize = true;
            lblIsertCode.Font = new Font("Segoe UI", 13F);
            lblIsertCode.Location = new Point(516, 36);
            lblIsertCode.Name = "lblIsertCode";
            lblIsertCode.Size = new Size(225, 30);
            lblIsertCode.TabIndex = 9;
            lblIsertCode.Text = "הכנס קוד מוצר למבצע";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(textCodeDelete);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(849, 354);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(353, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 58);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "מחיקה";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textCodeDelete
            // 
            textCodeDelete.Location = new Point(265, 62);
            textCodeDelete.Name = "textCodeDelete";
            textCodeDelete.Size = new Size(119, 27);
            textCodeDelete.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 65);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 3;
            label3.Text = "הכנס קוד מבצע למחיקה";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textCodeUd);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dateTimePickerF);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dateTimePickerS);
            tabPage3.Controls.Add(checkBox1club);
            tabPage3.Controls.Add(buttonUpdate);
            tabPage3.Controls.Add(nUDQuentity);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(price);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textCode);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(849, 354);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textCodeUd
            // 
            textCodeUd.Location = new Point(311, 35);
            textCodeUd.Name = "textCodeUd";
            textCodeUd.Size = new Size(180, 27);
            textCodeUd.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.Location = new Point(507, 30);
            label9.Name = "label9";
            label9.Size = new Size(228, 30);
            label9.TabIndex = 35;
            label9.Text = "הכנס קוד מבצע לעדכון";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(531, 285);
            label4.Name = "label4";
            label4.Size = new Size(196, 30);
            label4.TabIndex = 34;
            label4.Text = "תאריך סיום המבצע";
            // 
            // dateTimePickerF
            // 
            dateTimePickerF.Location = new Point(283, 291);
            dateTimePickerF.Name = "dateTimePickerF";
            dateTimePickerF.Size = new Size(233, 27);
            dateTimePickerF.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(513, 237);
            label5.Name = "label5";
            label5.Size = new Size(218, 30);
            label5.TabIndex = 32;
            label5.Text = "תאריך תחילת המבצע";
            // 
            // dateTimePickerS
            // 
            dateTimePickerS.Location = new Point(265, 243);
            dateTimePickerS.Name = "dateTimePickerS";
            dateTimePickerS.Size = new Size(233, 27);
            dateTimePickerS.TabIndex = 31;
            // 
            // checkBox1club
            // 
            checkBox1club.AutoSize = true;
            checkBox1club.Font = new Font("Segoe UI", 13F);
            checkBox1club.Location = new Point(433, 197);
            checkBox1club.Name = "checkBox1club";
            checkBox1club.Size = new Size(294, 34);
            checkBox1club.TabIndex = 30;
            checkBox1club.Text = "האם ללקוחות מועדון בלבד?";
            checkBox1club.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonUpdate.Location = new Point(26, 291);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(135, 43);
            buttonUpdate.TabIndex = 29;
            buttonUpdate.Text = "עדכון";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // nUDQuentity
            // 
            nUDQuentity.Location = new Point(361, 113);
            nUDQuentity.Name = "nUDQuentity";
            nUDQuentity.Size = new Size(84, 27);
            nUDQuentity.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(451, 110);
            label6.Name = "label6";
            label6.Size = new Size(281, 30);
            label6.TabIndex = 27;
            label6.Text = "כמות נדרשת לקבלת המבצע";
            // 
            // price
            // 
            price.Location = new Point(523, 158);
            price.Name = "price";
            price.Size = new Size(84, 27);
            price.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(613, 152);
            label7.Name = "label7";
            label7.Size = new Size(118, 30);
            label7.TabIndex = 25;
            label7.Text = "הכנס מחיר";
            // 
            // textCode
            // 
            textCode.Location = new Point(311, 69);
            textCode.Name = "textCode";
            textCode.Size = new Size(180, 27);
            textCode.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(507, 64);
            label8.Name = "label8";
            label8.Size = new Size(225, 30);
            label8.TabIndex = 23;
            label8.Text = "הכנס קוד מוצר למבצע";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listSearch);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(lblfoundId);
            tabPage4.Controls.Add(btnsearchById);
            tabPage4.Controls.Add(searchId);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(listSales);
            tabPage4.Controls.Add(btnListProd);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(849, 354);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "תצוגה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listSearch
            // 
            listSearch.FormattingEnabled = true;
            listSearch.Location = new Point(13, 112);
            listSearch.Name = "listSearch";
            listSearch.Size = new Size(223, 224);
            listSearch.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(13, 32);
            button2.Name = "button2";
            button2.Size = new Size(162, 55);
            button2.TabIndex = 17;
            button2.Text = "לסינון לפי כמות למבצע גדול מ-3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblfoundId
            // 
            lblfoundId.AutoSize = true;
            lblfoundId.Location = new Point(344, 185);
            lblfoundId.Name = "lblfoundId";
            lblfoundId.Size = new Size(0, 20);
            lblfoundId.TabIndex = 16;
            // 
            // btnsearchById
            // 
            btnsearchById.Location = new Point(390, 134);
            btnsearchById.Name = "btnsearchById";
            btnsearchById.Size = new Size(126, 35);
            btnsearchById.TabIndex = 15;
            btnsearchById.Text = "חפש";
            btnsearchById.UseVisualStyleBackColor = true;
            btnsearchById.Click += btnsearchById_Click;
            // 
            // searchId
            // 
            searchId.Location = new Point(404, 84);
            searchId.Name = "searchId";
            searchId.Size = new Size(111, 27);
            searchId.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(393, 40);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 13;
            button1.Text = "לסינון לפי id:";
            button1.UseVisualStyleBackColor = true;
            // 
            // listSales
            // 
            listSales.FormattingEnabled = true;
            listSales.Location = new Point(592, 112);
            listSales.Name = "listSales";
            listSales.Size = new Size(237, 224);
            listSales.TabIndex = 12;
            // 
            // btnListProd
            // 
            btnListProd.Location = new Point(676, 40);
            btnListProd.Name = "btnListProd";
            btnListProd.Size = new Size(140, 55);
            btnListProd.TabIndex = 11;
            btnListProd.Text = "לרשימת המבצעים המלאה";
            btnListProd.UseVisualStyleBackColor = true;
            btnListProd.Click += btnListProd_Click;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(editSales);
            Controls.Add(tabControlProd);
            Name = "Sale";
            Text = "Sale";
            Load += Sale_Load;
            tabControlProd.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuentityToSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDprice).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuentity).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label editSales;
        private TabControl tabControlProd;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnSave;
        private NumericUpDown nUDQuentityToSale;
        private Label lblInsertQuentity;
        private NumericUpDown nUDprice;
        private Label lblInsertPrice;
        private TextBox textInserCode;
        private Label lblIsertCode;
        private CheckBox checkBoxClub;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnDelete;
        private TextBox textCodeDelete;
        private Label label3;
        private TextBox textCodeUd;
        private Label label9;
        private Label label4;
        private DateTimePicker dateTimePickerF;
        private Label label5;
        private DateTimePicker dateTimePickerS;
        private CheckBox checkBox1club;
        private Button buttonUpdate;
        private NumericUpDown nUDQuentity;
        private Label label6;
        private NumericUpDown price;
        private Label label7;
        private TextBox textCode;
        private Label label8;
        private ListBox listSearch;
        private Button button2;
        private Label lblfoundId;
        private Button btnsearchById;
        private TextBox searchId;
        private Button button1;
        private ListBox listSales;
        private Button btnListProd;
    }
}