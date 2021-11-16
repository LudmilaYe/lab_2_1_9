using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_1_9 {
  public partial class Form1 : Form {
    public Form1() { // автоматически запускается при открытии программы
      // берём сохранённые данные, пока они не стали равны нулю
      decimal _num1 = Properties.Settings.Default.num1Saved;
      decimal _num2 = Properties.Settings.Default.num2Saved;
      decimal _num3 = Properties.Settings.Default.num3Saved;

      InitializeComponent(); // инициализируем интерфейс

      // добавляем сохранённые данные в поля ввода
      num1.Value = _num1;
      num2.Value = _num2;
      num3.Value = _num3;

      WriteNewInfo(); // обновляем вывод в строке
    }
    public static string GetMultipliedTwoMinNums(int[] nums) { // метод для вычисления множества
            int count = 1;
            Array.Sort(nums); // сортировка массива
       for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) count++;
            }
            if (count == nums.Length)
            {
                return ("Все цифры одинаковые");
            }
      return (nums[0] + "*" + nums[1] + "=" + nums[0] * nums[1]);
    }
    private void WriteNewInfo() { // вызываем сами по необходимости
      // получаем значения из полей ввода
      int _num1 = decimal.ToInt32(num1.Value);
      int _num2 = decimal.ToInt32(num2.Value);
      int _num3 = decimal.ToInt32(num3.Value);

      // вычисляем и выводим полученное значение в интерфейсе
      outLabel.Text = GetMultipliedTwoMinNums(new int[] { _num1, _num2, _num3 });

      // добавляем значения в память для следующего запуска программы
      Properties.Settings.Default.num1Saved = num1.Value;
      Properties.Settings.Default.num2Saved = num2.Value;
      Properties.Settings.Default.num3Saved = num3.Value;
      Properties.Settings.Default.Save();
    }
    private void NumChanged(object sender, EventArgs e) { // запускается при изменении полей
      WriteNewInfo();
    }
    private void NumChangedByKey(object sender, KeyEventArgs e) { // запускается при вводе в поле
      WriteNewInfo();
    }
    private void DeleteNums(object sender, EventArgs e) { // запускается при нажатии "очистить"
      num1.Value = 0;
      num2.Value = 0;
      num3.Value = 0;
    }
    private void ShowTask(object sender, EventArgs e) { // запускается при нажатии "очистить"
      MessageBox.Show("Составить программу нахождения произведения двух наименьших из трех различных чисел.");
    }

        private void outLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
