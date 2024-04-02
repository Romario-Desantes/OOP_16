namespace OOP_16
{
    public partial class Form1 : Form
    {
        Address address;//створення об'єкта
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)//дія при натиснені кнопки "Розпочати"
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)//Перевірка на введення даних
            {
                lbl_4.Text = "Введіть всі свої дані!";
                return;
            }
            address = new Address(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));//ініціалізація об'єкта
            lbl_4.Text = $"Ваша адреса: м.{address.City}, вул.{address.Street}, {address.Number}";

        }

        private void btn_2_Click(object sender, EventArgs e)//дія при натисненні кнопки "Видалити"
        {
            Address.Remove(address);//видалення об'єкта
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            lbl_4.Text = "Ваша адреса: ";

        }
    }
}
