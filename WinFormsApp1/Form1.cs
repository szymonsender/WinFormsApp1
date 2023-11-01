using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            int[] numbers;

            if (checkBox1.Checked)
            {
                int count = (int)numericUpDown1.Value;
                numbers = GenerateRandomNumbers(count, 200);
            }
            else
            {
                numbers = Convert(textBox1.Text);
            }

        }
        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            //Split ma parametr i ma omija� puste warto��i
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i].Trim());
            }
            return liczby;
        }

        private int[] GenerateRandomNumbers(int count, int maxVal)
        {
            Random rand = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(maxVal);
            }
            return numbers;
        }

        private void sb_Click(object sender, EventArgs e)
        {

        }


        private int[] BubbleSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }


        private int[] InsertionSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }


















    }
}