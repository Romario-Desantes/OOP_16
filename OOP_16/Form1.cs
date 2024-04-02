namespace OOP_16
{
    public partial class Form1 : Form
    {
        Address address;//��������� ��'����
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)//�� ��� �������� ������ "���������"
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)//�������� �� �������� �����
            {
                lbl_4.Text = "������ �� ��� ���!";
                return;
            }
            address = new Address(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));//����������� ��'����
            lbl_4.Text = $"���� ������: �.{address.City}, ���.{address.Street}, {address.Number}";

        }

        private void btn_2_Click(object sender, EventArgs e)//�� ��� ��������� ������ "��������"
        {
            Address.Remove(address);//��������� ��'����
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            lbl_4.Text = "���� ������: ";

        }
    }
}
