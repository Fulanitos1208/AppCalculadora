using System;
using System.Windows.Forms;
namespace AppCalculadora
{
  public partial class Form1 : Form
  {
    double r, a, b = 0;
    public Form1()
    {
      InitializeComponent();

    }
    private void tbDatoA_TextChanged(object sender, EventArgs e)
    {
      a = double.Parse(tbDatoA.Text);
    }
    private void tbDatoB_TextChanged(object sender, EventArgs e)
    {
      b = double.Parse(tbDatoB.Text);
    }
    private void btnSuma_Click(object sender, EventArgs e)
    {
      r = a + b;
      MessageBox.Show("La suma es:" + r);
    }
    private void btnResta_Click(object sender, EventArgs e)
    {
      r = a - b;
      MessageBox.Show("La resta de a-b es:" + r);
    }
    private void btnMult_Click(object sender, EventArgs e)
    {
      r = a * b;
      MessageBox.Show("El resultado de la multiplicación es: " + r);
    }
    private void btnDivision_Click(object sender, EventArgs e)
    {
      r = a / b;
      MessageBox.Show("El resultado de a/b es:" + r);
    }
    private void btnrc_Click_1(object sender, EventArgs e)
    {
      r = Math.Sqrt(a);
      MessageBox.Show("La raiz cuadrada de a es:" + r);
    }
    private void btnMenor_Click(object sender, EventArgs e)
    {
      r = Math.Min(a, b);
      MessageBox.Show("El numero menor de a-b es: " + r);
    }
    private void btnMayor_Click(object sender, EventArgs e)
    {
      r = Math.Max(a, b);
      MessageBox.Show("El numero mayor de a-b es: " + r);
    }
    private void btnPot_Click(object sender, EventArgs e)
    {
      r = Math.Pow(a,b);
      MessageBox.Show("Potencia de ´a´ a la ´b´ es: " + r);
    }
    private void btnRed_Click(object sender, EventArgs e)
    {
      r= Math.Round(a);
      MessageBox.Show("Es: " + r);
    }
    private void btnP_Click(object sender, EventArgs e)
    {
      r = Math.PI/a;
    }
    private void btnOpA_Click(object sender, EventArgs e)
    {
      Mostrar();
    }
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      tbDatoA.Clear();
      tbDatoB.Clear();
    }
    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    public void Mostrar()
    {
      btnMenor.Visible = true;
      btnMayor.Visible = true;
      btnPot.Visible = true;
      btnRed.Visible = true;
      btnrc.Visible = true;
      btnP.Visible = true;
    }
  }
}
