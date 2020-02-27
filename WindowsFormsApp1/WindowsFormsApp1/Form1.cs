using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<int, Tuple<string, double>> currancy = new Dictionary<int, Tuple<string, double>>(); //Глобальный словарь, тут будут находиться (номер, кортеж(валюта, курс))

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] mass = new string[1400]; // Массив строк, в него помещается построчно ХТМЛ файл сайта
            string line;
            int k = 0;
            int x, y, x1, y1 = 0;
            int i = 0;
            

            WebClient client = new WebClient(); //созадем класс, короче, вся мура, чтобы вытащить строки ХТМЛ в массик
            client.Encoding = Encoding.UTF8;
            Stream data = client.OpenRead("https://cbr.ru/currency_base/daily/");
            StreamReader reader = new StreamReader(data, Encoding.UTF8);
            while ((line = reader.ReadLine()) != null)
            {
                mass[i] = line;
                i++;
            }
            data.Close();
            reader.Close();
            

            for (int j = 292; j < mass.Length; j++) // Парсим короче (с 292 строчки, потому что раньше все равно смысла нет)
            {
                
                if (mass[j].IndexOf("<tr") != -1)// находим строки, где сидят данные по валютам и курсам (там надо смотреть код дока, если есть желание разобраться
                {

                    x = mass[j + 4].IndexOf('>') + 1;
                    y = mass[j + 4].LastIndexOf('<') - mass[j + 4].IndexOf('>') - 1;

                    
                    x1 = mass[j + 5].IndexOf('>') + 1;
                    y1 = mass[j + 5].LastIndexOf('<') - mass[j + 5].IndexOf('>') - 1;
                    CurList1.Items.Add(mass[j + 4].Substring(x, y));
                    CurList2.Items.Add(mass[j + 4].Substring(x, y));
                    currancy.Add(k, new Tuple<string, double>(mass[j + 4].Substring(x, y), Convert.ToDouble(mass[j + 5].Substring(x1, y1)))); //Заполняем словарик кстате

                    k += 1;
                }
            }

            CurList1.Text = currancy[0].Item1; // это чето все равно не работает, забейте
            CurList2.Text = currancy[0].Item1;




        }

        private void Accept_Click(object sender, EventArgs e)
        {
            double x = -1, y = -1; // Тута короче все подсчеты курсов и вывод результата. Покопаться - разберешься
            for (int i = 0; i < currancy.Count; i++)
            {
                if (CurList1.Text == currancy[i].Item1) x = currancy[i].Item2;
            }
            for (int i = 0; i < currancy.Count; i++)
            {
                if (CurList2.Text == currancy[i].Item1) y = currancy[i].Item2;
            }
            Value2.Text = (Convert.ToDouble(Value1.Text) * y / x).ToString();
        }
    }
}
