namespace UI
{
    partial class EnterToOrder
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
            textIdCust = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 48);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס מספר מזהה לקוח";
            // 
            // textIdCust
            // 
            textIdCust.Location = new Point(323, 84);
            textIdCust.Name = "textIdCust";
            textIdCust.Size = new Size(168, 27);
            textIdCust.TabIndex = 1;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(332, 141);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(139, 39);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "כניסה";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // EnterToOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(textIdCust);
            Controls.Add(label1);
            Name = "EnterToOrder";
            Text = "EnterToOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textIdCust;
        private Button btnEnter;
    }
}