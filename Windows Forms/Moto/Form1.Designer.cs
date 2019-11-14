namespace SistemaMoto {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maiorMarchaDaMoto = new System.Windows.Forms.TextBox();
            this.menorMarchaDaMoto = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.nomeDaMoto = new System.Windows.Forms.TextBox();
            this.corDaMoto = new System.Windows.Forms.TextBox();
            this.modeloDaMoto = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.marcaDaMoto = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.Desligado = new System.Windows.Forms.RadioButton();
            this.Ligado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.marchaMenos = new System.Windows.Forms.Button();
            this.marchaMais = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maiorMarchaDaMotoca = new System.Windows.Forms.Label();
            this.menorMarchaDaMotoca = new System.Windows.Forms.Label();
            this.marchaDaMotoca = new System.Windows.Forms.Label();
            this.corDaMotoca = new System.Windows.Forms.Label();
            this.modeloDaMotoca = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nomeDaMotoca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marcaDaMotoca = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maiorMarchaDaMoto);
            this.groupBox1.Controls.Add(this.menorMarchaDaMoto);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.nomeDaMoto);
            this.groupBox1.Controls.Add(this.corDaMoto);
            this.groupBox1.Controls.Add(this.modeloDaMoto);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.marcaDaMoto);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Painel de Informações da Moto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Menor Marcha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Maior Marcha";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // maiorMarchaDaMoto
            // 
            this.maiorMarchaDaMoto.Location = new System.Drawing.Point(118, 180);
            this.maiorMarchaDaMoto.Name = "maiorMarchaDaMoto";
            this.maiorMarchaDaMoto.Size = new System.Drawing.Size(100, 20);
            this.maiorMarchaDaMoto.TabIndex = 17;
            // 
            // menorMarchaDaMoto
            // 
            this.menorMarchaDaMoto.Location = new System.Drawing.Point(118, 154);
            this.menorMarchaDaMoto.Name = "menorMarchaDaMoto";
            this.menorMarchaDaMoto.Size = new System.Drawing.Size(100, 20);
            this.menorMarchaDaMoto.TabIndex = 16;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(6, 57);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(77, 13);
            this.a.TabIndex = 15;
            this.a.Text = "Nome da Moto";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // nomeDaMoto
            // 
            this.nomeDaMoto.Location = new System.Drawing.Point(118, 50);
            this.nomeDaMoto.Name = "nomeDaMoto";
            this.nomeDaMoto.Size = new System.Drawing.Size(100, 20);
            this.nomeDaMoto.TabIndex = 14;
            this.nomeDaMoto.TextChanged += new System.EventHandler(this.nomeDaMoto_TextChanged);
            // 
            // corDaMoto
            // 
            this.corDaMoto.Location = new System.Drawing.Point(118, 128);
            this.corDaMoto.Name = "corDaMoto";
            this.corDaMoto.Size = new System.Drawing.Size(100, 20);
            this.corDaMoto.TabIndex = 12;
            // 
            // modeloDaMoto
            // 
            this.modeloDaMoto.Location = new System.Drawing.Point(118, 102);
            this.modeloDaMoto.Name = "modeloDaMoto";
            this.modeloDaMoto.Size = new System.Drawing.Size(100, 20);
            this.modeloDaMoto.TabIndex = 11;
            this.modeloDaMoto.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(6, 135);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(23, 13);
            this.d.TabIndex = 9;
            this.d.Text = "Cor";
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(6, 109);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(42, 13);
            this.c.TabIndex = 8;
            this.c.Text = "Modelo";
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(78, 247);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // marcaDaMoto
            // 
            this.marcaDaMoto.Location = new System.Drawing.Point(118, 76);
            this.marcaDaMoto.Name = "marcaDaMoto";
            this.marcaDaMoto.Size = new System.Drawing.Size(100, 20);
            this.marcaDaMoto.TabIndex = 4;
            this.marcaDaMoto.TextChanged += new System.EventHandler(this.marcaDaMoto_TextChanged);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(6, 83);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(37, 13);
            this.b.TabIndex = 2;
            this.b.Text = "Marca";
            this.b.Click += new System.EventHandler(this.label2_Click);
            // 
            // Desligado
            // 
            this.Desligado.AutoSize = true;
            this.Desligado.Enabled = false;
            this.Desligado.Location = new System.Drawing.Point(395, 81);
            this.Desligado.Name = "Desligado";
            this.Desligado.Size = new System.Drawing.Size(72, 17);
            this.Desligado.TabIndex = 3;
            this.Desligado.TabStop = true;
            this.Desligado.Text = "Desligado";
            this.Desligado.UseVisualStyleBackColor = true;
            this.Desligado.CheckedChanged += new System.EventHandler(this.Desligado_CheckedChanged);
            // 
            // Ligado
            // 
            this.Ligado.AutoSize = true;
            this.Ligado.Enabled = false;
            this.Ligado.Location = new System.Drawing.Point(332, 81);
            this.Ligado.Name = "Ligado";
            this.Ligado.Size = new System.Drawing.Size(57, 17);
            this.Ligado.TabIndex = 4;
            this.Ligado.TabStop = true;
            this.Ligado.Text = "Ligado";
            this.Ligado.UseVisualStyleBackColor = true;
            this.Ligado.CheckedChanged += new System.EventHandler(this.Ligado_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.marchaMenos);
            this.groupBox2.Controls.Add(this.marchaMais);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maiorMarchaDaMotoca);
            this.groupBox2.Controls.Add(this.menorMarchaDaMotoca);
            this.groupBox2.Controls.Add(this.marchaDaMotoca);
            this.groupBox2.Controls.Add(this.corDaMotoca);
            this.groupBox2.Controls.Add(this.modeloDaMotoca);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nomeDaMotoca);
            this.groupBox2.Controls.Add(this.Desligado);
            this.groupBox2.Controls.Add(this.Ligado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.marcaDaMotoca);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(279, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 497);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Marcha";
            // 
            // marchaMenos
            // 
            this.marchaMenos.Enabled = false;
            this.marchaMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marchaMenos.Location = new System.Drawing.Point(413, 213);
            this.marchaMenos.Name = "marchaMenos";
            this.marchaMenos.Size = new System.Drawing.Size(75, 23);
            this.marchaMenos.TabIndex = 31;
            this.marchaMenos.Text = "-";
            this.marchaMenos.UseVisualStyleBackColor = true;
            this.marchaMenos.Click += new System.EventHandler(this.button2_Click);
            // 
            // marchaMais
            // 
            this.marchaMais.Enabled = false;
            this.marchaMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marchaMais.Location = new System.Drawing.Point(332, 213);
            this.marchaMais.Name = "marchaMais";
            this.marchaMais.Size = new System.Drawing.Size(75, 23);
            this.marchaMais.TabIndex = 20;
            this.marchaMais.Text = "+";
            this.marchaMais.UseVisualStyleBackColor = true;
            this.marchaMais.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ligado / Desligado";
            // 
            // maiorMarchaDaMotoca
            // 
            this.maiorMarchaDaMotoca.AutoSize = true;
            this.maiorMarchaDaMotoca.Location = new System.Drawing.Point(106, 213);
            this.maiorMarchaDaMotoca.Name = "maiorMarchaDaMotoca";
            this.maiorMarchaDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.maiorMarchaDaMotoca.TabIndex = 29;
            this.maiorMarchaDaMotoca.Click += new System.EventHandler(this.maiorMarchaDaMotoca_Click);
            // 
            // menorMarchaDaMotoca
            // 
            this.menorMarchaDaMotoca.AutoSize = true;
            this.menorMarchaDaMotoca.Location = new System.Drawing.Point(111, 189);
            this.menorMarchaDaMotoca.Name = "menorMarchaDaMotoca";
            this.menorMarchaDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.menorMarchaDaMotoca.TabIndex = 28;
            // 
            // marchaDaMotoca
            // 
            this.marchaDaMotoca.AutoSize = true;
            this.marchaDaMotoca.Location = new System.Drawing.Point(103, 163);
            this.marchaDaMotoca.Name = "marchaDaMotoca";
            this.marchaDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.marchaDaMotoca.TabIndex = 27;
            // 
            // corDaMotoca
            // 
            this.corDaMotoca.AutoSize = true;
            this.corDaMotoca.Location = new System.Drawing.Point(42, 137);
            this.corDaMotoca.Name = "corDaMotoca";
            this.corDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.corDaMotoca.TabIndex = 26;
            // 
            // modeloDaMotoca
            // 
            this.modeloDaMotoca.AutoSize = true;
            this.modeloDaMotoca.Location = new System.Drawing.Point(66, 111);
            this.modeloDaMotoca.Name = "modeloDaMotoca";
            this.modeloDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.modeloDaMotoca.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Marcha Atual:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Menor Marcha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Maior Marcha:";
            // 
            // nomeDaMotoca
            // 
            this.nomeDaMotoca.AutoSize = true;
            this.nomeDaMotoca.Location = new System.Drawing.Point(112, 55);
            this.nomeDaMotoca.Name = "nomeDaMotoca";
            this.nomeDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.nomeDaMotoca.TabIndex = 20;
            this.nomeDaMotoca.Click += new System.EventHandler(this.nomeDaMotoca_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome da Moto:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Modelo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // marcaDaMotoca
            // 
            this.marcaDaMotoca.AutoSize = true;
            this.marcaDaMotoca.Location = new System.Drawing.Point(59, 81);
            this.marcaDaMotoca.Name = "marcaDaMotoca";
            this.marcaDaMotoca.Size = new System.Drawing.Size(0, 13);
            this.marcaDaMotoca.TabIndex = 8;
            this.marcaDaMotoca.Click += new System.EventHandler(this.marcaDaMotoca_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Marca:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox marcaDaMoto;
        private System.Windows.Forms.RadioButton Desligado;
        private System.Windows.Forms.RadioButton Ligado;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox corDaMoto;
        private System.Windows.Forms.TextBox modeloDaMoto;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox nomeDaMoto;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maiorMarchaDaMoto;
        private System.Windows.Forms.TextBox menorMarchaDaMoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label marcaDaMotoca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label nomeDaMotoca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maiorMarchaDaMotoca;
        private System.Windows.Forms.Label menorMarchaDaMotoca;
        private System.Windows.Forms.Label corDaMotoca;
        private System.Windows.Forms.Label modeloDaMotoca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button marchaMenos;
        private System.Windows.Forms.Button marchaMais;
        private System.Windows.Forms.Label marchaDaMotoca;
    }
}

