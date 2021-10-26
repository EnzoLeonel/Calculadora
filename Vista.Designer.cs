
namespace Calculadora
{
    partial class Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnParent1 = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMultip = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnParent2 = new System.Windows.Forms.Button();
            this.pantallaRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.AccessibleName = "pantalla";
            this.pantalla.Location = new System.Drawing.Point(12, 12);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pantalla.Size = new System.Drawing.Size(223, 25);
            this.pantalla.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 76);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 36);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnParent1
            // 
            this.btnParent1.Location = new System.Drawing.Point(90, 76);
            this.btnParent1.Name = "btnParent1";
            this.btnParent1.Size = new System.Drawing.Size(42, 36);
            this.btnParent1.TabIndex = 3;
            this.btnParent1.Text = "( ";
            this.btnParent1.UseVisualStyleBackColor = true;
            this.btnParent1.Click += new System.EventHandler(this.btnParent1_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(186, 76);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(49, 36);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 118);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 36);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(70, 118);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 36);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(128, 118);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 36);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 160);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 36);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(70, 160);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 36);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(128, 160);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 36);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 202);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 36);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(70, 202);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 36);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(128, 202);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 36);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(12, 244);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(52, 36);
            this.btnPunto.TabIndex = 14;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(70, 244);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 36);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(128, 244);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(107, 36);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMultip
            // 
            this.btnMultip.Location = new System.Drawing.Point(186, 118);
            this.btnMultip.Name = "btnMultip";
            this.btnMultip.Size = new System.Drawing.Size(49, 36);
            this.btnMultip.TabIndex = 17;
            this.btnMultip.Text = "X";
            this.btnMultip.UseVisualStyleBackColor = true;
            this.btnMultip.Click += new System.EventHandler(this.btnMultip_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(186, 160);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(49, 36);
            this.btnResta.TabIndex = 18;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(186, 202);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(49, 36);
            this.btnSuma.TabIndex = 19;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnParent2
            // 
            this.btnParent2.Location = new System.Drawing.Point(138, 76);
            this.btnParent2.Name = "btnParent2";
            this.btnParent2.Size = new System.Drawing.Size(42, 36);
            this.btnParent2.TabIndex = 20;
            this.btnParent2.Text = ")";
            this.btnParent2.UseVisualStyleBackColor = true;
            this.btnParent2.Click += new System.EventHandler(this.btnParent2_Click);
            // 
            // pantallaRes
            // 
            this.pantallaRes.AccessibleName = "pantallaRes";
            this.pantallaRes.Location = new System.Drawing.Point(12, 36);
            this.pantallaRes.Multiline = true;
            this.pantallaRes.Name = "pantallaRes";
            this.pantallaRes.Size = new System.Drawing.Size(223, 34);
            this.pantallaRes.TabIndex = 21;
            this.pantallaRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 292);
            this.Controls.Add(this.pantallaRes);
            this.Controls.Add(this.btnParent2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultip);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnParent1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pantalla);
            this.Name = "Vista";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox pantalla;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.Button btnParent1;
        public System.Windows.Forms.Button btnDividir;
        public System.Windows.Forms.Button btn7;
        public System.Windows.Forms.Button btn8;
        public System.Windows.Forms.Button btn9;
        public System.Windows.Forms.Button btn4;
        public System.Windows.Forms.Button btn5;
        public System.Windows.Forms.Button btn6;
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button btnPunto;
        public System.Windows.Forms.Button btn0;
        public System.Windows.Forms.Button btnIgual;
        public System.Windows.Forms.Button btnMultip;
        public System.Windows.Forms.Button btnResta;
        public System.Windows.Forms.Button btnSuma;
        public System.Windows.Forms.Button btnParent2;
        public System.Windows.Forms.TextBox pantallaRes;
    }
}

