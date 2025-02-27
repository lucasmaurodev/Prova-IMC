namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblResult = new Label();
            label7 = new Label();
            label6 = new Label();
            txtIMC = new TextBox();
            label5 = new Label();
            txtAltura = new TextBox();
            label4 = new Label();
            txtPeso = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button13 = new Button();
            button9 = new Button();
            btn = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btnVirgula = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIMC);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAltura);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPeso);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "'";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.balanca;
            pictureBox2.Location = new Point(34, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.metro;
            pictureBox1.Location = new Point(36, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Gray;
            lblResult.Location = new Point(19, 166);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(104, 23);
            lblResult.TabIndex = 10;
            lblResult.Text = "Situação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(254, 106);
            label7.Name = "label7";
            label7.Size = new Size(30, 23);
            label7.TabIndex = 9;
            label7.Text = "m";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(254, 74);
            label6.Name = "label6";
            label6.Size = new Size(36, 23);
            label6.TabIndex = 8;
            label6.Text = "kg";
            // 
            // txtIMC
            // 
            txtIMC.Enabled = false;
            txtIMC.Location = new Point(176, 140);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(72, 23);
            txtIMC.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(117, 140);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 6;
            label5.Text = "IMC";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(176, 106);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(72, 23);
            txtAltura.TabIndex = 5;
            txtAltura.Enter += txtAltura_Enter;
            txtAltura.Leave += txtAltura_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(93, 106);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 4;
            label4.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(176, 74);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(72, 23);
            txtPeso.TabIndex = 3;
            txtPeso.Tag = "ativar";
            txtPeso.Enter += txtPeso_Enter;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(109, 74);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 2;
            label3.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(34, 44);
            label2.Name = "label2";
            label2.Size = new Size(237, 18);
            label2.TabIndex = 1;
            label2.Text = "Informe seu Peso e Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 19);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de IMC";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(btn);
            groupBox2.Controls.Add(btn6);
            groupBox2.Controls.Add(btn9);
            groupBox2.Controls.Add(btn0);
            groupBox2.Controls.Add(btn2);
            groupBox2.Controls.Add(btn5);
            groupBox2.Controls.Add(btn8);
            groupBox2.Controls.Add(btnVirgula);
            groupBox2.Controls.Add(btn1);
            groupBox2.Controls.Add(btn4);
            groupBox2.Controls.Add(btn7);
            groupBox2.Location = new Point(15, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 311);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "'";
            // 
            // button13
            // 
            button13.BackColor = Color.Gold;
            button13.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(22, 260);
            button13.Name = "button13";
            button13.Size = new Size(294, 34);
            button13.TabIndex = 12;
            button13.Text = "Calcular Índice de Massa Corporal";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(218, 196);
            button9.Name = "button9";
            button9.Size = new Size(81, 55);
            button9.TabIndex = 11;
            button9.Text = "Del";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.Gold;
            btn.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.Location = new Point(218, 135);
            btn.Name = "btn";
            btn.Size = new Size(81, 55);
            btn.TabIndex = 10;
            btn.Text = "3";
            btn.UseVisualStyleBackColor = false;
            btn.Click += AdicionarNmr;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gold;
            btn6.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(218, 74);
            btn6.Name = "btn6";
            btn6.Size = new Size(81, 55);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += AdicionarNmr;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gold;
            btn9.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(218, 13);
            btn9.Name = "btn9";
            btn9.Size = new Size(81, 55);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += AdicionarNmr;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gold;
            btn0.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(126, 196);
            btn0.Name = "btn0";
            btn0.Size = new Size(81, 55);
            btn0.TabIndex = 7;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += AdicionarNmr;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gold;
            btn2.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(126, 135);
            btn2.Name = "btn2";
            btn2.Size = new Size(81, 55);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += AdicionarNmr;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gold;
            btn5.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(126, 74);
            btn5.Name = "btn5";
            btn5.Size = new Size(81, 55);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += AdicionarNmr;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gold;
            btn8.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(126, 13);
            btn8.Name = "btn8";
            btn8.Size = new Size(81, 55);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += AdicionarNmr;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Gold;
            btnVirgula.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgula.Location = new Point(32, 196);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(81, 55);
            btnVirgula.TabIndex = 3;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += AdicionarNmr;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gold;
            btn1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(32, 135);
            btn1.Name = "btn1";
            btn1.Size = new Size(81, 55);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += AdicionarNmr;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gold;
            btn4.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(32, 74);
            btn4.Name = "btn4";
            btn4.Size = new Size(81, 55);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += AdicionarNmr;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gold;
            btn7.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(32, 13);
            btn7.Name = "btn7";
            btn7.Size = new Size(81, 55);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += AdicionarNmr;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(353, 544);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn7;
        private Label label1;
        private Button button13;
        private Button button9;
        private Button btn;
        private Button btn6;
        private Button btn9;
        private Button btn0;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btnVirgula;
        private Button btn1;
        private Button btn4;
        private TextBox txtPeso;
        private Label label3;
        private Label label2;
        private Label lblResult;
        private Label label7;
        private Label label6;
        private TextBox txtIMC;
        private Label label5;
        private TextBox txtAltura;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
