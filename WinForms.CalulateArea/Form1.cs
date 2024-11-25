namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("��ͧ��ûԴ�����?", "Close Windows?"
                                        , MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input  �Ѻ��Ҩҡ Textbox���� txtRadius  (�ŧ��Դ�������� Double)
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRaduis.Text);
            if (double.TryParse(txtRaduis.Text,out Radius)==false)
            {
                MessageBox.Show("��͡���������١��ͧ", "���� Error!!");
                txtRaduis.Focus();    //����� Cursor ��� Textbox
                txtRaduis.SelectAll();  //��� Selected ��ͤ���� Textbox
                return;
            }
            //process �ӹǳ��鹷�� �ٵ�  pi*r*r
            double CircleArea = Math.PI*Math.Pow(Radius, 2);
                //Math.PI  ����� Pi
                //Math.Pow(x,y)   x ¡���ѧ y
            //output  ����ʴ��ŷ�� lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRaduis.Focus();
            txtRaduis.SelectAll();
        }
    }
}
