using System.Windows.Forms;

namespace Lab18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //�������� 1
        private void button1_Click(object sender, EventArgs e)
        {

            string[] elements = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] array;
            if (!elements.All(element => double.TryParse(element, out _)))
            {
                MessageBox.Show("����i�� ��������i �����");
                return;
            }

            array = elements.Select(double.Parse).ToArray();
            int negativeCount = array.Count(num => num < 0);
            double minAbs = array.Min(Math.Abs);
            double SummAbsAfter = array.SkipWhile(num => Math.Abs(num) != minAbs).Skip(1).Sum(Math.Abs);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    array[i] *= array[i];
            }
            Array.Sort(array);

            Console.WriteLine("�i���i��� �i�'����� �������i�:" + negativeCount);
            Console.WriteLine("���� �����i� �������i� �i��� �i�i�������� �� ������� ��������: " + SummAbsAfter);
            Console.WriteLine("��i����� �� �i����������� ����� �� ����������: " + string.Join(" ", array),"\n");
            Console.WriteLine("//////////////////////////////////////////////////\n");


        }

        //�������� 2
        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Lines;
            int rows = lines.Length;
            int columns = lines[0].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] elements = lines[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(elements[j]);
                }
            }
            Console.WriteLine("���i���i �i����� ��������, �� ������ � ��������� ������� i �������� �i���� �����\n");
            int temp = array[0, array.GetLength(1) - 1];
            array[0, array.GetLength(1) - 1] = array[array.GetLength(0) - 1, 0];
            array[array.GetLength(0) - 1, 0] = temp;
            PrintArray(array);
            Console.WriteLine("\n");



            Console.WriteLine("���i���i �i����� ��������, �� ������ � �������� ������� i ��������� �i���� �����\n");
            temp = array[array.GetLength(0) - 1, array.GetLength(1) - 1];
            array[array.GetLength(0) - 1, array.GetLength(1) - 1] = array[0, 0];
            array[0, 0] = temp;
            PrintArray(array);
            Console.WriteLine("//////////////////////////////////////////////////\n");



        }
        //����� ��� ��������� ������
        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        //������ ��� �������� ������i
        private void button3_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }
    }
}
