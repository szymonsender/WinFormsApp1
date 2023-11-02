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


        private Stopwatch stopwatch = new Stopwatch();

        private double getTime()
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }

            return stopwatch.Elapsed.TotalMilliseconds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] numbers = GetNumbersFromTextBoxOrGenerated();
            double startTime = getTime();
            numbers = InsertionSort(numbers);
            textBox3.Text = string.Join(" ", numbers);

            double endTime = getTime();
            double elapsedTime = (endTime - startTime) / 1000.0;

            textBox2.Text = $"\n{elapsedTime}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            //Split ma parametr i ma omijaæ puste wartoœæi
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

            int[] numbers = GetNumbersFromTextBoxOrGenerated();

            double startTime = getTime();

            numbers = BubbleSort(numbers);

            textBox3.Text = string.Join(" ", numbers);

            double endTime = getTime();
            double elapsedTime = (endTime - startTime) / 1000.0;

            textBox2.Text = $"\n{elapsedTime}";

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
            double startTime = getTime();
            numbers = SelectionSort(numbers);
            textBox3.Text = string.Join(" ", numbers);

            double endTime = getTime();
            double elapsedTime = (endTime - startTime) / 1000.0;

            textBox2.Text = $"\n{elapsedTime}";
        }

        private void quick_Click(object sender, EventArgs e)
        {
            int[] numbers = GetNumbersFromTextBoxOrGenerated();
            double startTime = getTime();
            QuickSort(numbers, 0, numbers.Length - 1);


            textBox3.Text = string.Join(" ", numbers);

            double endTime = getTime();
            double elapsedTime = (endTime - startTime) / 1000.0;

            textBox2.Text = $"\n{elapsedTime}";
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
            int[] numbers = GetNumbersFromTextBoxOrGenerated();

            double startTime = getTime();

            numbers = MergeSort(numbers);

            textBox3.Text = string.Join(" ", numbers);

            double endTime = getTime();
            double elapsedTime = (endTime - startTime) / 1000.0;

            textBox2.Text = $"\n{elapsedTime}";
        }



        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int middleIndex = array.Length / 2;
            int[] leftArray = array.Take(middleIndex).ToArray();
            int[] rightArray = array.Skip(middleIndex).ToArray();

            return Merge(MergeSort(leftArray), MergeSort(rightArray));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result.Add(left[leftIndex++]);
                }
                else
                {
                    result.Add(right[rightIndex++]);
                }
            }

            while (leftIndex < left.Length)
            {
                result.Add(left[leftIndex++]);
            }

            while (rightIndex < right.Length)
            {
                result.Add(right[rightIndex++]);
            }

            return result.ToArray();
        }








    }
}