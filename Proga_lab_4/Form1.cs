using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Google.Apis.Sheets.v4;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.IO;
using ZedGraph;

namespace Proga_lab_4
{
    public partial class Form1 : Form
    {

        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string SpreadsheetId = "1BbjZxzIjTQ1ACC0q3kYqXJl-0RChhXQe_viwL7tF1PI";
        static readonly string sheet = "Data";
        static SheetsService service;
        List<string> sortOrder = new List<string>();
        List<double> dataSorting = new List<double>();


        public Form1()
        {
            InitializeComponent();
        }


        private static void CreateGraph3(ZedGraphControl zgc, List<double> arr)
        {
            // get a reference to the GraphPane
            GraphPane pane = zgc.GraphPane;
            pane.CurveList.Clear();
            pane.Title.Text = "Sorting";
            pane.CurveList.Clear();

            double[] values = new double[arr.Count];

            for (int i = 0; i < arr.Count; i++) {

                values[i] = arr[i];
            }


            //create histogram
            BarItem curve = pane.AddBar("Elements", null, values, Color.Blue);

            pane.BarSettings.MinClusterGap = 9F; //set columns references


            zgc.AxisChange();

            zgc.Invalidate();
        }




        private void methodBubbleSort() // работает правильно
        {

            new Thread(() =>
            {
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                Invoke((System.Action)(() =>
                {
                    bubbleInfo.Text = "";
                }));

                List<double> array = new List<double>(dataSorting);

                double temp = 0;
                myStopwatch.Start();
                for (int i = 0; i < array.Count; ++i)
                {
                    for (int j = 0; j < array.Count - 1; ++j)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            CreateGraph3(zedGraphControl1, array);
                        }
                    }
                }
                myStopwatch.Stop();

                Invoke((System.Action)(() =>
                {
                    bubbleInfo.Text = "Время: " + myStopwatch.Elapsed.ToString() + "\n";
                    if (sortDescending.Checked == true)
                    {
                        array.Reverse();
                    }
                }));

                for (int i = 0; i < array.Count; ++i)
                {
                    Invoke((System.Action)(() =>
                    {
                        bubbleInfo.Text += array[i].ToString() + " ";
                        
                    }));
                }
            }).Start();


        }

        static void Swap1(ref double e1, ref double e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }



        private void methodShakerSotring() // по возрастанию
        {
            new Thread(() =>
            {
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                Invoke((System.Action)(() =>
                {
                    shakerInfo.Text = "";
                }));

                List<double> array = new List<double>(dataSorting);
                myStopwatch.Start();
                for (var i = 0; i < (array.Count - 1) / 2; ++i)
                {
                    var swapFlag = false;
                    //проход слева направо
                    for (var j = i; j < array.Count - i - 1; ++j)
                    {
                        if (array[j] > array[j + 1])
                        {

                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            swapFlag = true;
                        }
                    }

                    //проход справа налево
                    for (var j = array.Count - 2 - i; j > i; --j)
                    {
                        if (array[j - 1] > array[j])
                        {
                            var temp = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = temp;
                            swapFlag = true;
                        }

                    }

                    //если обменов не было выходим
                    if (!swapFlag)
                    {
                        break;
                    }
                }

                myStopwatch.Stop();

                Invoke((System.Action)(() =>
                {
                    shakerInfo.Text = "Время: " + myStopwatch.Elapsed.ToString() + "\n";
                    if (sortDescending.Checked == true)
                    {
                        array.Reverse();
                    }
                }));

                for (int i = 0; i < array.Count; ++i)
                {
                    Invoke((System.Action)(() =>
                    {
                        shakerInfo.Text += array[i].ToString() + " ";
                    }));
                }


            }).Start();



        }



        private void methodInsertSotring() // по возрастанию - правильно
        {
            new Thread(() =>
                {
                    System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                    Invoke((System.Action)(() =>
                    {
                        insertInfo.Text = "";
                    }));


                    List<double> array = new List<double>(dataSorting);
                    double temp = 0;
                    int j;
                    myStopwatch.Start();
                    for (int i = 1; i < array.Count; ++i)
                    {
                        temp = array[i]; // сам 2 элемент
                        j = i;
                        while (j > 0 && array[j - 1] > temp)
                        {
                            double dop = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = dop;
                            j -= 1;
                        }
                        array[j] = temp;
                    }
                    myStopwatch.Stop();

                    Invoke((System.Action)(() =>
                    {
                        insertInfo.Text = "Время: " + myStopwatch.Elapsed.ToString() + "\n";
                        if (sortDescending.Checked == true)
                        {
                            array.Reverse();
                        }
                    }));

                    for (int i = 0; i < array.Count; ++i)
                    {
                        Invoke((System.Action)(() =>
                        {
                            insertInfo.Text += array[i].ToString() + " ";
                        }));
                    }
                }
            ).Start();


        }



        private void methodQuickSotring()
        {

        }

        static bool IsSorted(List<double> array) // Метод для проверки упорядоченности массива
        {
            for (int i = 0; i < array.Count - 2; ++i)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }
        static List<double> Random(List<double> array) // Метод для перемешивания элементов массива
        {
            Random random = new Random();
            for (int i = array.Count - 2; i >= 0; --i)
            {
                int j = random.Next(i); // Возвращение случайного числа
                double dop = array[i];
                array[i] = array[j];
                array[j] = dop;
            }
            return array;
        }



        private void methodBogoSorting()
        {
            List<double> array = new List<double>(dataSorting);
            while (!IsSorted(array)) // Пока массив не упорядочен
            {
                array = Random(array); // Меняем местами дальше
            }

            for (int i = 0; i < array.Count; ++i)
            {
                bogoSort.Text += array[i].ToString() + " ";
            }
        }


        private bool dataValidation()
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Введите данные");
                return false;
            }

            if (dataGridView1.Rows.Count == 2)
            {
                MessageBox.Show("Недостаточно данных для сортировки");
                return false; ;
            }

            if (bubbleSort.Checked == false && shakerSorting.Checked == false && quickSorting.Checked == false && bogoSort.Checked == false && sortingInsert.Checked == false)
            {
                MessageBox.Show("Не выбрана ни одна сортировка");
                return false;
            }

            if (sortAscending.Checked == false && sortDescending.Checked == false)
            {
                MessageBox.Show("Выберите сортировку по возрастанию или убыванию");
                return false;
            }

            if (sortAscending.Checked == true && sortDescending.Checked == true)
            {
                MessageBox.Show("Нельзя выбрать одновременно сортировку по возрастанию и убыванию");
                return false;
            }

            return true;
        }

        private void startSorting_Click(object sender, EventArgs e)
        {
            if (dataValidation())
            {
                dataSorting.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                {
                    dataSorting.Add(Convert.ToDouble(dataGridView1[0, i].Value));
                }


                for (int i = 0; i < sortOrder.Count; ++i)
                {
                    switch (sortOrder[i])
                    {
                        case "Пузырьковая сортировка":
                            methodBubbleSort();
                            break;

                        case "Шейкерная сортировка":
                            methodShakerSotring();
                            break;
                        case "Сортировка вставками":
                            methodInsertSotring();
                            break;
                        case "Быстрая сортировка":
                            methodQuickSotring();
                            break;
                        case "BOGO сортировка":
                            methodBogoSorting();
                            break;

                    }
                }
            }

        }


        private void dataExcelBtn_Click(object sender, EventArgs e)
        {

            new Thread(() =>
            {
                try
                {
                    Invoke((System.Action)(() =>
                    {
                        dataGridView1.Rows.Clear();
                    }));

                    openFileDialog1.ShowDialog();
                    string path = openFileDialog1.FileName;


                    Excel.Application ObjExcel = new Excel.Application();
                    Workbook ObjWorkBook = ObjExcel.Workbooks.Open(path);
                    Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];

                    Range xRange = ObjWorkSheet.UsedRange.Columns[1];

                    Array xCells = (Array)xRange.Cells.Value2;

                    string[] xColumn = xCells.OfType<object>().Select(o => o.ToString()).ToArray();


                    for (int i = 0; i < xColumn.Length; ++i)
                    {
                        Invoke((System.Action)(() =>
                        {
                            dataGridView1.Rows.Add(xColumn[i]);
                        }));

                    }
                    ObjWorkBook.Close();
                    ObjExcel.Quit();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка при считывания данных");
                }
            }).Start();

        }

        private void bubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            if (bubbleSort.Checked == true)
            {
                sortOrder.Add("Пузырьковая сортировка");
            }
            else
            {
                sortOrder.Remove("Пузырьковая сортировка");
            }
        }

        private void shakerSorting_CheckedChanged(object sender, EventArgs e)
        {
            if (shakerSorting.Checked == true)
            {
                sortOrder.Add("Шейкерная сортировка");
            }
            else
            {
                sortOrder.Remove("Шейкерная сортировка");
            }

        }

        private void sortingInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (sortingInsert.Checked == true)
            {
                sortOrder.Add("Сортировка вставками");
            }
            else
            {
                sortOrder.Remove("Сортировка вставками");
            }

        }

        private void quickSorting_CheckedChanged(object sender, EventArgs e)
        {
            if (quickSorting.Checked == true)
            {
                sortOrder.Add("Быстрая сортировка");
            }
            else
            {
                sortOrder.Remove("Быстрая сортировка");
            }

        }

        private void bogoSort_CheckedChanged(object sender, EventArgs e)
        {
            if (bogoSort.Checked == true)
            {
                sortOrder.Add("BOGO сортировка");
            }
            else
            {
                sortOrder.Remove("BOGO сортировка");
            }

        }

        private void googleSheetsBtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    Invoke((System.Action)(() =>
                    {
                        dataGridView1.Rows.Clear();
                    }));

                    GoogleCredential credential;
                    using (var stream = new FileStream("creds.json", FileMode.Open, FileAccess.Read))
                    {
                        credential = GoogleCredential.FromStream(stream)
                            .CreateScoped(Scopes);
                    }

                    service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                    });

                    var range = $"Point!A:A";
                    SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

                    var response = request.Execute();
                    IList<IList<object>> values = response.Values;

                    if (values != null && values.Count > 0)
                    {
                        foreach (var row in values)
                        {
                            Invoke((System.Action)(() =>
                            {
                                dataGridView1.Rows.Add(row[0]);
                            }));
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка при считывания данных");
                }
            }).Start();
        }

        private void zedGraphControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
