namespace MOSTRAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Arriba = new Button();
            Izquierda = new Button();
            Abajo = new Button();
            Derecha = new Button();
            splitter1 = new Splitter();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(95, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 52);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(310, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 56);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(88, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 55);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(193, 231);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(360, 360);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Arriba
            // 
            Arriba.Location = new Point(585, 231);
            Arriba.Name = "Arriba";
            Arriba.Size = new Size(52, 44);
            Arriba.TabIndex = 4;
            Arriba.Text = "button1";
            Arriba.UseVisualStyleBackColor = true;
            Arriba.Click += button1_Click;
            // 
            // Izquierda
            // 
            Izquierda.Location = new Point(501, 308);
            Izquierda.Name = "Izquierda";
            Izquierda.Size = new Size(52, 44);
            Izquierda.TabIndex = 5;
            Izquierda.Text = "button2";
            Izquierda.UseVisualStyleBackColor = true;
            Izquierda.Click += Izquierda_Click;
            // 
            // Abajo
            // 
            Abajo.Location = new Point(585, 394);
            Abajo.Name = "Abajo";
            Abajo.Size = new Size(52, 44);
            Abajo.TabIndex = 6;
            Abajo.Text = "button3";
            Abajo.UseVisualStyleBackColor = true;
            // 
            // Derecha
            // 
            Derecha.Location = new Point(667, 308);
            Derecha.Name = "Derecha";
            Derecha.Size = new Size(52, 44);
            Derecha.TabIndex = 7;
            Derecha.Text = "button4";
            Derecha.UseVisualStyleBackColor = true;
            Derecha.Click += button4_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(469, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(11, 450);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(pictureBox5);
            Controls.Add(splitter1);
            Controls.Add(Derecha);
            Controls.Add(Abajo);
            Controls.Add(Izquierda);
            Controls.Add(Arriba);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button Arriba;
        private Button Izquierda;
        private Button Abajo;
        private Button Derecha;
        private Splitter splitter1;
        private PictureBox pictureBox5;
    }
}
