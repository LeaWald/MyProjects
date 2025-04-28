namespace UI
{
    partial class shop
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
            lblShop = new Label();
            enterManager = new Button();
            enterCashier = new Button();
            SuspendLayout();
            // 
            // lblShop
            // 
            lblShop.AutoSize = true;
            lblShop.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblShop.Location = new Point(355, 54);
            lblShop.Name = "lblShop";
            lblShop.Size = new Size(201, 46);
            lblShop.TabIndex = 0;
            lblShop.Text = "חנות מתנות";
            // 
            // enterManager
            // 
            enterManager.Font = new Font("Segoe UI", 13F);
            enterManager.Location = new Point(583, 247);
            enterManager.Name = "enterManager";
            enterManager.Size = new Size(185, 70);
            enterManager.TabIndex = 1;
            enterManager.Text = "כניסה כמנהל";
            enterManager.UseVisualStyleBackColor = true;
            enterManager.Click += enterManager_Click;
            // 
            // enterCashier
            // 
            enterCashier.Font = new Font("Segoe UI", 13F);
            enterCashier.Location = new Point(231, 247);
            enterCashier.Name = "enterCashier";
            enterCashier.Size = new Size(185, 70);
            enterCashier.TabIndex = 2;
            enterCashier.Text = "כניסה כקופאי";
            enterCashier.UseVisualStyleBackColor = true;
            enterCashier.Click += enterCashier_Click;
            // 
            // shop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(enterCashier);
            Controls.Add(enterManager);
            Controls.Add(lblShop);
            Name = "shop";
            Text = "shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShop;
        private Button enterManager;
        private Button enterCashier;
    }
}