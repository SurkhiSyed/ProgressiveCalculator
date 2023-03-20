
namespace C_SharpCalculator
{
    partial class IntroScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.Instructions_label = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Background_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::C_SharpCalculator.Properties.Resources.imageedit_8_2626280208;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(413, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::C_SharpCalculator.Properties.Resources.imageedit_8_2626280208;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 188);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_label.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.Color.White;
            this.Welcome_label.Location = new System.Drawing.Point(125, 39);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(307, 59);
            this.Welcome_label.TabIndex = 2;
            this.Welcome_label.Text = "WELCOME";
            // 
            // Instructions_label
            // 
            this.Instructions_label.AutoSize = true;
            this.Instructions_label.BackColor = System.Drawing.Color.Transparent;
            this.Instructions_label.ForeColor = System.Drawing.Color.White;
            this.Instructions_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Instructions_label.Location = new System.Drawing.Point(8, 107);
            this.Instructions_label.Name = "Instructions_label";
            this.Instructions_label.Size = new System.Drawing.Size(536, 140);
            this.Instructions_label.TabIndex = 3;
            this.Instructions_label.Text = resources.GetString("Instructions_label.Text");
            this.Instructions_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.White;
            this.Start_btn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.Location = new System.Drawing.Point(200, 334);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(154, 37);
            this.Start_btn.TabIndex = 4;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Background_btn
            // 
            this.Background_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Background_btn.Location = new System.Drawing.Point(191, 325);
            this.Background_btn.Name = "Background_btn";
            this.Background_btn.Size = new System.Drawing.Size(171, 54);
            this.Background_btn.TabIndex = 5;
            this.Background_btn.Text = "button1";
            this.Background_btn.UseVisualStyleBackColor = false;
            // 
            // IntroScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Instructions_label);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Background_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IntroScreen";
            this.Text = "IntroScreen";
            this.Load += new System.EventHandler(this.IntroScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label Instructions_label;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Background_btn;
    }
}