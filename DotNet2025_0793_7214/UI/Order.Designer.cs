namespace UI
{
    partial class Order
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
            label1 = new Label();
            ManagerLbl = new Label();
            label2 = new Label();
            lblHello = new Label();
            cbName = new ComboBox();
            label3 = new Label();
            nUDQuentity = new NumericUpDown();
            Products = new ListBox();
            btnAddProd = new Button();
            label4 = new Label();
            toPay = new TextBox();
            finish = new Button();
            label5 = new Label();
            btnSearch = new Button();
            Sales = new ListBox();
            prodInOrd = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nUDQuentity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // ManagerLbl
            // 
            ManagerLbl.AutoSize = true;
            ManagerLbl.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagerLbl.Location = new Point(361, 9);
            ManagerLbl.Name = "ManagerLbl";
            ManagerLbl.Size = new Size(204, 46);
            ManagerLbl.TabIndex = 4;
            ManagerLbl.Text = "ביצוע הזמנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(728, 87);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "בחר שם מוצר";
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(50, 27);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(0, 20);
            lblHello.TabIndex = 7;
            // 
            // cbName
            // 
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(638, 127);
            cbName.Name = "cbName";
            cbName.Size = new Size(187, 28);
            cbName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(752, 188);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 9;
            label3.Text = "בחר כמות";
            // 
            // nUDQuentity
            // 
            nUDQuentity.Location = new Point(687, 186);
            nUDQuentity.Name = "nUDQuentity";
            nUDQuentity.Size = new Size(59, 27);
            nUDQuentity.TabIndex = 10;
            // 
            // Products
            // 
            Products.FormattingEnabled = true;
            Products.Location = new Point(330, 127);
            Products.Name = "Products";
            Products.Size = new Size(233, 384);
            Products.TabIndex = 13;
            // 
            // btnAddProd
            // 
            btnAddProd.Location = new Point(726, 242);
            btnAddProd.Name = "btnAddProd";
            btnAddProd.Size = new Size(99, 39);
            btnAddProd.TabIndex = 14;
            btnAddProd.Text = "הוסף מוצר";
            btnAddProd.UseVisualStyleBackColor = true;
            btnAddProd.Click += btnAddProd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(430, 528);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 15;
            label4.Text = "סה\"כ לתשלום";
            // 
            // toPay
            // 
            toPay.Location = new Point(335, 531);
            toPay.Name = "toPay";
            toPay.Size = new Size(92, 27);
            toPay.TabIndex = 16;
            // 
            // finish
            // 
            finish.Location = new Point(41, 528);
            finish.Name = "finish";
            finish.Size = new Size(187, 39);
            finish.TabIndex = 17;
            finish.Text = "לסיום הזמנה";
            finish.UseVisualStyleBackColor = true;
            finish.Click += finish_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 87);
            label5.Name = "label5";
            label5.Size = new Size(333, 20);
            label5.TabIndex = 18;
            label5.Text = "לרשימת מבצעים למוצר מסוים בחר מוצר מההזמנה";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(22, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "חפש";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Sales
            // 
            Sales.FormattingEnabled = true;
            Sales.Location = new Point(22, 163);
            Sales.Name = "Sales";
            Sales.Size = new Size(233, 344);
            Sales.TabIndex = 21;
            // 
            // prodInOrd
            // 
            prodInOrd.FormattingEnabled = true;
            prodInOrd.Location = new Point(106, 125);
            prodInOrd.Name = "prodInOrd";
            prodInOrd.Size = new Size(187, 28);
            prodInOrd.TabIndex = 22;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(prodInOrd);
            Controls.Add(Sales);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(finish);
            Controls.Add(toPay);
            Controls.Add(label4);
            Controls.Add(btnAddProd);
            Controls.Add(Products);
            Controls.Add(nUDQuentity);
            Controls.Add(label3);
            Controls.Add(cbName);
            Controls.Add(lblHello);
            Controls.Add(label2);
            Controls.Add(ManagerLbl);
            Controls.Add(label1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)nUDQuentity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ManagerLbl;
        private Label label2;
        private Label lblHello;
        private ComboBox cbName;
        private Label label3;
        private NumericUpDown nUDQuentity;
        private ListBox Products;
        private Button btnAddProd;
        private Label label4;
        private TextBox toPay;
        private Button finish;
        private Label label5;
        private Button btnSearch;
        private ListBox Sales;
        private ComboBox prodInOrd;
    }
}