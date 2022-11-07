namespace AppCalculadora
{
  partial class Form1
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
      this.btnSuma = new System.Windows.Forms.Button();
      this.btnResta = new System.Windows.Forms.Button();
      this.btnMult = new System.Windows.Forms.Button();
      this.lbDatoA = new System.Windows.Forms.Label();
      this.tbDatoA = new System.Windows.Forms.TextBox();
      this.tbDatoB = new System.Windows.Forms.TextBox();
      this.btnDivision = new System.Windows.Forms.Button();
      this.btnMayor = new System.Windows.Forms.Button();
      this.btnPot = new System.Windows.Forms.Button();
      this.btnMenor = new System.Windows.Forms.Button();
      this.btnrc = new System.Windows.Forms.Button();
      this.btnOpA = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.btnRed = new System.Windows.Forms.Button();
      this.btnP = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnSuma
      // 
      this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSuma.Location = new System.Drawing.Point(198, 114);
      this.btnSuma.Name = "btnSuma";
      this.btnSuma.Size = new System.Drawing.Size(30, 31);
      this.btnSuma.TabIndex = 0;
      this.btnSuma.Text = "+";
      this.btnSuma.UseVisualStyleBackColor = true;
      this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
      // 
      // btnResta
      // 
      this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnResta.Location = new System.Drawing.Point(230, 114);
      this.btnResta.Name = "btnResta";
      this.btnResta.Size = new System.Drawing.Size(30, 31);
      this.btnResta.TabIndex = 1;
      this.btnResta.Text = "-";
      this.btnResta.UseVisualStyleBackColor = true;
      this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
      // 
      // btnMult
      // 
      this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMult.Location = new System.Drawing.Point(198, 150);
      this.btnMult.Name = "btnMult";
      this.btnMult.Size = new System.Drawing.Size(30, 31);
      this.btnMult.TabIndex = 2;
      this.btnMult.Text = "x";
      this.btnMult.UseVisualStyleBackColor = true;
      this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
      // 
      // lbDatoA
      // 
      this.lbDatoA.AutoSize = true;
      this.lbDatoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbDatoA.Location = new System.Drawing.Point(5, 47);
      this.lbDatoA.Name = "lbDatoA";
      this.lbDatoA.Size = new System.Drawing.Size(182, 16);
      this.lbDatoA.TabIndex = 3;
      this.lbDatoA.Text = "Ingrese el primer valor(a)";
      // 
      // tbDatoA
      // 
      this.tbDatoA.Location = new System.Drawing.Point(193, 43);
      this.tbDatoA.Name = "tbDatoA";
      this.tbDatoA.Size = new System.Drawing.Size(67, 20);
      this.tbDatoA.TabIndex = 4;
      this.tbDatoA.TextChanged += new System.EventHandler(this.tbDatoA_TextChanged);
      // 
      // tbDatoB
      // 
      this.tbDatoB.Location = new System.Drawing.Point(193, 81);
      this.tbDatoB.Name = "tbDatoB";
      this.tbDatoB.Size = new System.Drawing.Size(67, 20);
      this.tbDatoB.TabIndex = 6;
      this.tbDatoB.TextChanged += new System.EventHandler(this.tbDatoB_TextChanged);
      // 
      // btnDivision
      // 
      this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDivision.Location = new System.Drawing.Point(230, 150);
      this.btnDivision.Name = "btnDivision";
      this.btnDivision.Size = new System.Drawing.Size(30, 31);
      this.btnDivision.TabIndex = 7;
      this.btnDivision.Text = "/";
      this.btnDivision.UseVisualStyleBackColor = true;
      this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
      // 
      // btnMayor
      // 
      this.btnMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMayor.Location = new System.Drawing.Point(85, 184);
      this.btnMayor.Name = "btnMayor";
      this.btnMayor.Size = new System.Drawing.Size(30, 31);
      this.btnMayor.TabIndex = 11;
      this.btnMayor.Text = ">";
      this.btnMayor.UseVisualStyleBackColor = true;
      this.btnMayor.Visible = false;
      this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
      // 
      // btnPot
      // 
      this.btnPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPot.Location = new System.Drawing.Point(121, 184);
      this.btnPot.Name = "btnPot";
      this.btnPot.Size = new System.Drawing.Size(41, 31);
      this.btnPot.TabIndex = 10;
      this.btnPot.Text = "a´b";
      this.btnPot.UseVisualStyleBackColor = true;
      this.btnPot.Visible = false;
      this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
      // 
      // btnMenor
      // 
      this.btnMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMenor.Location = new System.Drawing.Point(49, 184);
      this.btnMenor.Name = "btnMenor";
      this.btnMenor.Size = new System.Drawing.Size(30, 31);
      this.btnMenor.TabIndex = 9;
      this.btnMenor.Text = "<";
      this.btnMenor.UseVisualStyleBackColor = true;
      this.btnMenor.Visible = false;
      this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
      // 
      // btnrc
      // 
      this.btnrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnrc.Location = new System.Drawing.Point(8, 184);
      this.btnrc.Name = "btnrc";
      this.btnrc.Size = new System.Drawing.Size(30, 31);
      this.btnrc.TabIndex = 8;
      this.btnrc.Text = "RAIZ";
      this.btnrc.UseVisualStyleBackColor = true;
      this.btnrc.Visible = false;
      this.btnrc.Click += new System.EventHandler(this.btnrc_Click_1);
      // 
      // btnOpA
      // 
      this.btnOpA.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOpA.Location = new System.Drawing.Point(8, 147);
      this.btnOpA.Name = "btnOpA";
      this.btnOpA.Size = new System.Drawing.Size(138, 31);
      this.btnOpA.TabIndex = 12;
      this.btnOpA.Text = "Operaciones avanzadas";
      this.btnOpA.UseVisualStyleBackColor = true;
      this.btnOpA.Click += new System.EventHandler(this.btnOpA_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(5, 82);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(182, 16);
      this.label1.TabIndex = 13;
      this.label1.Text = "Ingrese el primer valor(b)";
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLimpiar.Location = new System.Drawing.Point(8, 110);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(138, 31);
      this.btnLimpiar.TabIndex = 14;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // btnRed
      // 
      this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRed.Location = new System.Drawing.Point(165, 184);
      this.btnRed.Name = "btnRed";
      this.btnRed.Size = new System.Drawing.Size(30, 31);
      this.btnRed.TabIndex = 15;
      this.btnRed.Text = "=";
      this.btnRed.UseVisualStyleBackColor = true;
      this.btnRed.Visible = false;
      this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
      // 
      // btnP
      // 
      this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnP.Location = new System.Drawing.Point(200, 184);
      this.btnP.Name = "btnP";
      this.btnP.Size = new System.Drawing.Size(30, 31);
      this.btnP.TabIndex = 16;
      this.btnP.Text = "pi";
      this.btnP.UseVisualStyleBackColor = true;
      this.btnP.Visible = false;
      this.btnP.Click += new System.EventHandler(this.btnP_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(0, 0);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(54, 23);
      this.btnSalir.TabIndex = 17;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(297, 450);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnP);
      this.Controls.Add(this.btnRed);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOpA);
      this.Controls.Add(this.btnMayor);
      this.Controls.Add(this.btnPot);
      this.Controls.Add(this.btnMenor);
      this.Controls.Add(this.btnrc);
      this.Controls.Add(this.btnDivision);
      this.Controls.Add(this.tbDatoB);
      this.Controls.Add(this.tbDatoA);
      this.Controls.Add(this.lbDatoA);
      this.Controls.Add(this.btnMult);
      this.Controls.Add(this.btnResta);
      this.Controls.Add(this.btnSuma);
      this.Name = "Form1";
      this.Text = "Calculadora";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Label lbDatoA;
        private System.Windows.Forms.TextBox tbDatoA;
        private System.Windows.Forms.TextBox tbDatoB;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnPot;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnrc;
        private System.Windows.Forms.Button btnOpA;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnRed;
    private System.Windows.Forms.Button btnP;
    private System.Windows.Forms.Button btnSalir;
  }
}

