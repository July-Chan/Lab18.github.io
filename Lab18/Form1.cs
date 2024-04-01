using System.Windows.Forms;

namespace Lab18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Завдання 1
        private void button1_Click(object sender, EventArgs e)
        {

            string[] elements = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] array;
            if (!elements.All(element => double.TryParse(element, out _)))
            {
                MessageBox.Show("Введiть правильнi числа");
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

            Console.WriteLine("Кiлькiсть вiд'ємних елементiв:" + negativeCount);
            Console.WriteLine("Сума модулiв елементiв пiсля мiнiмального за модулем елементу: " + SummAbsAfter);
            Console.WriteLine("Змiнений та вiдсортований масив за зростанням: " + string.Join(" ", array),"\n");
            Console.WriteLine("//////////////////////////////////////////////////\n");


        }

        //Завдання 2
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
            Console.WriteLine("Помiнянi мiсцями елементи, що стоять у верхньому правому i нижньому лiвому кутах\n");
            int temp = array[0, array.GetLength(1) - 1];
            array[0, array.GetLength(1) - 1] = array[array.GetLength(0) - 1, 0];
            array[array.GetLength(0) - 1, 0] = temp;
            PrintArray(array);
            Console.WriteLine("\n");



            Console.WriteLine("Помiнянi мiсцями елементи, що стоять у нижньому правому i верхньому лiвому кутах\n");
            temp = array[array.GetLength(0) - 1, array.GetLength(1) - 1];
            array[array.GetLength(0) - 1, array.GetLength(1) - 1] = array[0, 0];
            array[0, 0] = temp;
            PrintArray(array);
            Console.WriteLine("//////////////////////////////////////////////////\n");



        }
        //Метод для виведення масиву
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


        //Кнопки для очищення консолi
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
