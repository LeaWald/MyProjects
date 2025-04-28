namespace UI
{
    partial class Customer
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
            editCustomer = new Label();
            tabControlProd = new TabControl();
            tabPage1 = new TabPage();
            btnSave = new Button();
            textPhone = new TextBox();
            label3 = new Label();
            textAdrress = new TextBox();
            label2 = new Label();
            textName = new TextBox();
            label1 = new Label();
            textIdCust = new TextBox();
            lblInserName = new Label();
            tabPage2 = new TabPage();
            btnDelete = new Button();
            textCodeDelete = new TextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            btnSaveUD = new Button();
            textPhoneUD = new TextBox();
            label5 = new Label();
            textAddressUD = new TextBox();
            label6 = new Label();
            textNameUD = new TextBox();
            label7 = new Label();
            textIdUpdate = new TextBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            listSearch = new ListBox();
            button2 = new Button();
            lblfoundId = new Label();
            btnsearchById = new Button();
            searchId = new TextBox();
            button1 = new Button();
            listCust = new ListBox();
            btnListCust = new Button();
            tabControlProd.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // editCustomer
            // 
            editCustomer.AutoSize = true;
            editCustomer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            editCustomer.Location = new Point(416, 9);
            editCustomer.Name = "editCustomer";
            editCustomer.Size = new Size(179, 35);
            editCustomer.TabIndex = 8;
            editCustomer.Text = "עריכת לקוחות";
            // 
            // tabControlProd
            // 
            tabControlProd.Controls.Add(tabPage1);
            tabControlProd.Controls.Add(tabPage2);
            tabControlProd.Controls.Add(tabPage3);
            tabControlProd.Controls.Add(tabPage4);
            tabControlProd.Location = new Point(37, 61);
            tabControlProd.Name = "tabControlProd";
            tabControlProd.RightToLeft = RightToLeft.Yes;
            tabControlProd.RightToLeftLayout = true;
            tabControlProd.SelectedIndex = 0;
            tabControlProd.Size = new Size(848, 387);
            tabControlProd.TabIndex = 7;
            tabControlProd.SelectedIndexChanged += tabControlProd_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(textPhone);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textAdrress);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textName);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textIdCust);
            tabPage1.Controls.Add(lblInserName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.Yes;
            tabPage1.Size = new Size(840, 354);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(603, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 43);
            btnSave.TabIndex = 10;
            btnSave.Text = "שמירה";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(385, 183);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(180, 27);
            textPhone.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(571, 180);
            label3.Name = "label3";
            label3.Size = new Size(177, 30);
            label3.TabIndex = 8;
            label3.Text = "הכנס מס' פלאפון";
            // 
            // textAdrress
            // 
            textAdrress.Location = new Point(428, 138);
            textAdrress.Name = "textAdrress";
            textAdrress.Size = new Size(180, 27);
            textAdrress.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(614, 135);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 6;
            label2.Text = "הכנס כתובת";
            // 
            // textName
            // 
            textName.Location = new Point(459, 89);
            textName.Name = "textName";
            textName.Size = new Size(180, 27);
            textName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(645, 86);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 4;
            label1.Text = "הכנס שם";
            // 
            // textIdCust
            // 
            textIdCust.Location = new Point(349, 38);
            textIdCust.Name = "textIdCust";
            textIdCust.Size = new Size(180, 27);
            textIdCust.TabIndex = 3;
            // 
            // lblInserName
            // 
            lblInserName.AutoSize = true;
            lblInserName.Font = new Font("Segoe UI", 13F);
            lblInserName.Location = new Point(535, 35);
            lblInserName.Name = "lblInserName";
            lblInserName.Size = new Size(212, 30);
            lblInserName.TabIndex = 2;
            lblInserName.Text = "הכנס מס מזהה לקוח";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(textCodeDelete);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(840, 354);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(457, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 58);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "מחיקה";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textCodeDelete
            // 
            textCodeDelete.Location = new Point(369, 49);
            textCodeDelete.Name = "textCodeDelete";
            textCodeDelete.Size = new Size(119, 27);
            textCodeDelete.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 52);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 6;
            label4.Text = "הכנס קוד  לקוח למחיקה";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSaveUD);
            tabPage3.Controls.Add(textPhoneUD);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textAddressUD);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textNameUD);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textIdUpdate);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(840, 354);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaveUD
            // 
            btnSaveUD.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveUD.Location = new Point(613, 269);
            btnSaveUD.Name = "btnSaveUD";
            btnSaveUD.Size = new Size(135, 43);
            btnSaveUD.TabIndex = 19;
            btnSaveUD.Text = "עדכון";
            btnSaveUD.UseVisualStyleBackColor = true;
            btnSaveUD.Click += btnSaveUD_Click;
            // 
            // textPhoneUD
            // 
            textPhoneUD.Location = new Point(427, 193);
            textPhoneUD.Name = "textPhoneUD";
            textPhoneUD.Size = new Size(180, 27);
            textPhoneUD.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(613, 190);
            label5.Name = "label5";
            label5.Size = new Size(143, 30);
            label5.TabIndex = 17;
            label5.Text = "הכנס מס' נייד";
            // 
            // textAddressUD
            // 
            textAddressUD.Location = new Point(438, 146);
            textAddressUD.Name = "textAddressUD";
            textAddressUD.Size = new Size(180, 27);
            textAddressUD.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(624, 143);
            label6.Name = "label6";
            label6.Size = new Size(133, 30);
            label6.TabIndex = 15;
            label6.Text = "הכנס כתובת";
            // 
            // textNameUD
            // 
            textNameUD.Location = new Point(469, 97);
            textNameUD.Name = "textNameUD";
            textNameUD.Size = new Size(180, 27);
            textNameUD.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(655, 94);
            label7.Name = "label7";
            label7.Size = new Size(102, 30);
            label7.TabIndex = 13;
            label7.Text = "הכנס שם";
            // 
            // textIdUpdate
            // 
            textIdUpdate.Location = new Point(292, 51);
            textIdUpdate.Name = "textIdUpdate";
            textIdUpdate.Size = new Size(180, 27);
            textIdUpdate.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(478, 48);
            label8.Name = "label8";
            label8.Size = new Size(278, 30);
            label8.TabIndex = 11;
            label8.Text = "הכנס מס מזהה לקוח לעדכון";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listSearch);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(lblfoundId);
            tabPage4.Controls.Add(btnsearchById);
            tabPage4.Controls.Add(searchId);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(listCust);
            tabPage4.Controls.Add(btnListCust);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(840, 354);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "תצוגה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listSearch
            // 
            listSearch.FormattingEnabled = true;
            listSearch.Location = new Point(12, 109);
            listSearch.Name = "listSearch";
            listSearch.Size = new Size(189, 224);
            listSearch.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(12, 29);
            button2.Name = "button2";
            button2.Size = new Size(162, 55);
            button2.TabIndex = 17;
            button2.Text = "לסינון לפי לקוחות שרשומים עם מס' נייד";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblfoundId
            // 
            lblfoundId.AutoSize = true;
            lblfoundId.Location = new Point(392, 185);
            lblfoundId.Name = "lblfoundId";
            lblfoundId.Size = new Size(0, 20);
            lblfoundId.TabIndex = 16;
            // 
            // btnsearchById
            // 
            btnsearchById.Location = new Point(389, 131);
            btnsearchById.Name = "btnsearchById";
            btnsearchById.Size = new Size(126, 35);
            btnsearchById.TabIndex = 15;
            btnsearchById.Text = "חפש";
            btnsearchById.UseVisualStyleBackColor = true;
            btnsearchById.Click += btnsearchById_Click;
            // 
            // searchId
            // 
            searchId.Location = new Point(403, 81);
            searchId.Name = "searchId";
            searchId.Size = new Size(111, 27);
            searchId.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(392, 37);
            button1.Name = "button1";
            button1.Size = new Size(122, 38);
            button1.TabIndex = 13;
            button1.Text = "לסינון לפי id:";
            button1.UseVisualStyleBackColor = true;
            // 
            // listCust
            // 
            listCust.FormattingEnabled = true;
            listCust.Location = new Point(626, 109);
            listCust.Name = "listCust";
            listCust.Size = new Size(202, 224);
            listCust.TabIndex = 12;
            // 
            // btnListCust
            // 
            btnListCust.Location = new Point(675, 37);
            btnListCust.Name = "btnListCust";
            btnListCust.Size = new Size(140, 55);
            btnListCust.TabIndex = 11;
            btnListCust.Text = "לרשימת הלקוחות המלאה";
            btnListCust.UseVisualStyleBackColor = true;
            btnListCust.Click += btnListCust_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(editCustomer);
            Controls.Add(tabControlProd);
            Name = "Customer";
            Text = "Customer";
            tabControlProd.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label editCustomer;
        private TabControl tabControlProd;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox textName;
        private Label label1;
        private TextBox textIdCust;
        private Label lblInserName;
        private TextBox textPhone;
        private Label label3;
        private TextBox textAdrress;
        private Label label2;
        private Button btnSave;
        private Button btnDelete;
        private TextBox textCodeDelete;
        private Label label4;
        private Button btnSaveUD;
        private TextBox textPhoneUD;
        private Label label5;
        private TextBox textAddressUD;
        private Label label6;
        private TextBox textNameUD;
        private Label label7;
        private TextBox textIdUpdate;
        private Label label8;
        private ListBox listSearch;
        private Button button2;
        private Label lblfoundId;
        private Button btnsearchById;
        private TextBox searchId;
        private Button button1;
        private ListBox listCust;
        private Button btnListCust;
    }
}