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
            int[] numbers = GetNumbersFromTextBoxOrGenerated();
            numbers = InsertionSort(numbers);
            textBox2.Text = string.Join(" ", numbers);

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
                numbers = GenerateRandomNumbers(count);
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

        private int[] GenerateRandomNumbers(int count)
        {
            Random rand = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(0, 20);
            }

            return numbers;
        }

        private void sb_Click(object sender, EventArgs e)
        {
            int[] numbers = Convert(textBox1.Text);
            numbers = BubbleSort(numbers);
            textBox2.Text = string.Join(" ", numbers);
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

        private int[] SelectionSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }


        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;

            return i + 1;
        }

        private int[] GetNumbersFromTextBoxOrGenerated()
        {
            int[] numbers;

            if (checkBox1.Checked)
            {
                int count = (int)numericUpDown1.Value;
                numbers = GenerateRandomNumbers(count);
            }
            else
            {
                numbers = Convert(textBox1.Text);
            }

            return numbers;
        }

        private void selection_Click(object sender, EventArgs e)
        {
            int[] numbers = GetNumbersFromTextBoxOrGenerated();
            numbers = SelectionSort(numbers);
            textBox2.Text = string.Join(" ", numbers);
        }

        private void quick_Click(object sender, EventArgs e)
        {
            int[] numbers = GetNumbersFromTextBoxOrGenerated();
            QuickSort(numbers, 0, numbers.Length - 1);
            textBox2.Text = string.Join(" ", numbers);
        }



        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private void merge_Click(object sender, EventArgs e)
        {

        }
    }
}