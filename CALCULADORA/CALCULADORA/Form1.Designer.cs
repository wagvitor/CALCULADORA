namespace CALCULADORA
{
    partial class Form1
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.somar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(64, 100);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(214, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.painel_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(121, 142);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(177, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(231, 142);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(47, 28);
            this.somar.TabIndex = 10;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(177, 185);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 28);
            this.button11.TabIndex = 13;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // subtrair
            // 
            this.subtrair.Location = new System.Drawing.Point(231, 185);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(47, 28);
            this.subtrair.TabIndex = 14;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(121, 230);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 28);
            this.button12.TabIndex = 16;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(177, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 28);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(231, 230);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(47, 28);
            this.multiplicar.TabIndex = 18;
            this.multiplicar.Text = "X";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(64, 274);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(47, 28);
            this.limpar.TabIndex = 19;
            this.limpar.Text = "C";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(121, 274);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(47, 28);
            this.button14.TabIndex = 20;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(177, 274);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(47, 28);
            this.resultado.TabIndex = 21;
            this.resultado.Text = "=";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(231, 274);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(47, 28);
            this.dividir.TabIndex = 22;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cirilo Neto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Larissa Tayane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Wagner Vitor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

