using System;
using System.Windows.Forms;

namespace Lr8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxRadius.Text, out double radius))
            {
                Circle circle = new Circle(Convert.ToDouble(radius));
                labelSquare.Text = $"Площадь круга = {circle.Square()}";
                labelLenght.Text = $"Длинна окружности = {circle.CircleLenght()}";
                if (double.TryParse(textBoxX.Text, out double x) & double.TryParse(textBoxY.Text, out double y))
                {
                    if (circle.PointAffiliation(x, y)) labelPointAffiliation.Text = "Точка находится в пределах круга";
                    else labelPointAffiliation.Text = "Точка выходит за пределы круга";
                    if (double.TryParse(textBoxExternalRadius.Text, out double externalRadius))
                    {
                        Ring ring = new Ring(radius, externalRadius);
                        if (ring.PointAffiliation(x, y)) labelPointAffiliationForRing.Text = "Точка в пределах кольца";
                        else labelPointAffiliationForRing.Text = "точка за пределами кольца";
                    }
                }
                else { PrintException(); }
            }
            else { PrintException(); }
        }

        private void button_Click(object sender, EventArgs e)
        {
            
        }

        public void PrintException()
        {
            MessageBox.Show("Введено некорректное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
