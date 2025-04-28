namespace UI
{
    partial class Manager
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
            ManagerLbl = new Label();
            productCare = new Button();
            customerCare = new Button();
            saleCare = new Button();
            SuspendLayout();
            // 
            // ManagerLbl
            // 
            ManagerLbl.AutoSize = true;
            ManagerLbl.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagerLbl.Location = new Point(416, 26);
            ManagerLbl.Name = "ManagerLbl";
            ManagerLbl.Size = new Size(99, 46);
            ManagerLbl.TabIndex = 3;
            ManagerLbl.Text = "מנהל";
            ManagerLbl.Click += ManagerLbl_Click;
            // 
            // productCare
            // 
            productCare.BackColor = SystemColors.ButtonHighlight;
            productCare.Font = new Font("Segoe UI", 15F);
            productCare.Location = new Point(654, 187);
            productCare.Name = "productCare";
            productCare.Size = new Size(196, 96);
            productCare.TabIndex = 5;
            productCare.Text = "מוצרים";
            productCare.UseVisualStyleBackColor = false;
            productCare.Click += productCare_Click;
            // 
            // customerCare
            // 
            customerCare.Font = new Font("Segoe UI", 15F);
            customerCare.Location = new Point(382, 187);
            customerCare.Name = "customerCare";
            customerCare.Size = new Size(196, 96);
            customerCare.TabIndex = 6;
            customerCare.Text = "לקוחות";
            customerCare.UseVisualStyleBackColor = true;
            customerCare.Click += customerCare_Click;
            // 
            // saleCare
            // 
            saleCare.Font = new Font("Segoe UI", 15F);
            saleCare.Location = new Point(131, 187);
            saleCare.Name = "saleCare";
            saleCare.Size = new Size(196, 96);
            saleCare.TabIndex = 7;
            saleCare.Text = "מבצעים";
            saleCare.UseVisualStyleBackColor = true;
            saleCare.Click += saleCare_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(saleCare);
            Controls.Add(customerCare);
            Controls.Add(productCare);
            Controls.Add(ManagerLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager";
            ShowInTaskbar = false;
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ManagerLbl;
        private Button productCare;
        private Button customerCare;
        private Button saleCare;
    }
}