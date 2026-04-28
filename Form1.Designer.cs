namespace Programming_Language_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            listBox1 = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblDateTime = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(333, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Favourite Programming Languages";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(239, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(562, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(239, 250);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(562, 27);
            txtLanguage.TabIndex = 2;
            txtLanguage.Text = "Enter programming language";
            txtLanguage.TextChanged += txtLanguage_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(371, 283);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Langugae";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(192, 0, 0);
            btnRemove.Location = new Point(239, 283);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(126, 31);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove ";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.ImageAlign = ContentAlignment.BottomRight;
            lblDateTime.Location = new Point(213, 313);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 20);
            lblDateTime.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 529);
            Controls.Add(lblDateTime);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(listBox1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox listBox1;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblDateTime;
    }
}
