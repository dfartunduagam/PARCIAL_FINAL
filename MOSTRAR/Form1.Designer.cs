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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(310, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(88, 281);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(295, 343);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(85, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Arriba
            // 
            Arriba.Location = new Point(598, 187);
            Arriba.Name = "Arriba";
            Arriba.Size = new Size(79, 44);
            Arriba.TabIndex = 4;
            Arriba.Text = "ARRIBA";
            Arriba.UseVisualStyleBackColor = true;
            Arriba.Click += button1_Click;
            // 
            // Izquierda
            // 
            Izquierda.Location = new Point(517, 237);
            Izquierda.Name = "Izquierda";
            Izquierda.Size = new Size(81, 44);
            Izquierda.TabIndex = 5;
            Izquierda.Text = "IZQUIERDA";
            Izquierda.UseVisualStyleBackColor = true;
            Izquierda.Click += Izquierda_Click;
            // 
            // Abajo
            // 
            Abajo.Location = new Point(598, 292);
            Abajo.Name = "Abajo";
            Abajo.Size = new Size(79, 44);
            Abajo.TabIndex = 6;
            Abajo.Text = "ABAJO";
            Abajo.UseVisualStyleBackColor = true;
            // 
            // Derecha
            // 
            Derecha.Location = new Point(674, 237);
            Derecha.Name = "Derecha";
            Derecha.Size = new Size(81, 44);
            Derecha.TabIndex = 7;
            Derecha.Text = "DERECHA";
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
            // textBox1
            // 
            textBox1.Location = new Point(517, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "SELECIONE UN MODO DE JUEGO";
            // 
            // button1
            // 
            button1.Location = new Point(575, 97);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 11;
            button1.Text = "MODO CAPTURA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(575, 126);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 12;
            button2.Text = "MODO REPETICIÓN";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(602, 402);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "FIANLIZAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
