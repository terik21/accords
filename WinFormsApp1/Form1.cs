using PianoRoll;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string tonika;
        private string ton;
        

        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tonika = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ton = comboBox2.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tonika != null && ton != null)
            {
                Bah schedule = new Bah();
                using (var sw = new System.IO.StringWriter())
                {
                    Console.SetOut(sw);

                    schedule.GenerateAccord(tonika, ton);

                    string result = sw.ToString();
                    
                    MessageBox.Show($"Аккорд\n\n{result}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите значения в обоих ComboBox.");
            }
        }

        
    }
}
