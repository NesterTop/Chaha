using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace Chaha
{
    public partial class Form1 : Form
    {
        int l1 = 0, l2 = 1, l3 = 2, l4 = 3, l5 = 4, l6 = 5;

        

        List<string> iphone14_Nazvanie;
        List<string> iphone14_Img;
        List<string> iphone14_Cena;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetData("https://woap.ru/zapchasti-dlya-iphone/zapchasti-iphone-14-pro-max");
        }

        public void SetData(string uri)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(uri);

            HtmlNodeCollection iphone14_Nazvanie_Nodes = document.DocumentNode.SelectNodes("//div[@class='field-item odd']");
            HtmlNodeCollection iphone14_Img_Nodes = document.DocumentNode.SelectNodes("//div[@class='field field-name-uc-product-image field-type-image field-label-hidden']");
            HtmlNodeCollection iphone14_Cena_Nodes = document.DocumentNode.SelectNodes("//span[@class='uc-price']");

            iphone14_Nazvanie = new List<string>();
            iphone14_Img = new List<string>();
            iphone14_Cena = new List<string>();

            foreach (var item in iphone14_Nazvanie_Nodes)
            {
                iphone14_Nazvanie.Add(item.ChildNodes[0].InnerText);
            }

            foreach (var item in iphone14_Img_Nodes)
            {
                iphone14_Img.Add(item.ChildNodes.First().ChildNodes.First().Attributes["src"].Value);
            }

            foreach (var item in iphone14_Cena_Nodes)
            {
                iphone14_Cena.Add(item.InnerText);
            }

            

            label2.Text = iphone14_Nazvanie[0];
            label4.Text = iphone14_Nazvanie[1];
            label6.Text = iphone14_Nazvanie[2];
            label10.Text = iphone14_Nazvanie[3];
            label12.Text = iphone14_Nazvanie[4];
            label14.Text = iphone14_Nazvanie[5];


            pictureBox1.Load(iphone14_Img[0]);
            pictureBox2.Load(iphone14_Img[1]);
            pictureBox3.Load(iphone14_Img[2]);
            pictureBox5.Load(iphone14_Img[3]);
            pictureBox6.Load(iphone14_Img[4]);
            pictureBox7.Load(iphone14_Img[5]);

            label3.Text = iphone14_Cena[0];
            label5.Text = iphone14_Cena[1];
            label7.Text = iphone14_Cena[2];
            label11.Text = iphone14_Cena[3];
            label13.Text = iphone14_Cena[4];
            label15.Text = iphone14_Cena[5];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pageSize = 6;

            if(l6 + pageSize <= iphone14_Nazvanie.Count)
            {
                l1 += pageSize;
                l2 += pageSize;
                l3 += pageSize;
                l4 += pageSize;
                l5 += pageSize;
                l6 += pageSize;
            }

            label2.Text = iphone14_Nazvanie[l1];
            label4.Text = iphone14_Nazvanie[l2];
            label6.Text = iphone14_Nazvanie[l3];
            label10.Text = iphone14_Nazvanie[l4];
            label12.Text = iphone14_Nazvanie[l5];
            label14.Text = iphone14_Nazvanie[l6];


            pictureBox1.Load(iphone14_Img[l1]);
            pictureBox2.Load(iphone14_Img[l2]);
            pictureBox3.Load(iphone14_Img[l3]);
            pictureBox5.Load(iphone14_Img[l4]);
            pictureBox6.Load(iphone14_Img[l5]);
            pictureBox7.Load(iphone14_Img[l6]);


            label3.Text = iphone14_Cena[l1];
            label5.Text = iphone14_Cena[l2];
            label7.Text = iphone14_Cena[l3];
            label11.Text = iphone14_Cena[l4];
            label13.Text = iphone14_Cena[l5];
            label15.Text = iphone14_Cena[l6];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pageSize = 6;

            if(l6 - pageSize >= 0)
            {
                l1 -= pageSize;
                l2 -= pageSize;
                l3 -= pageSize;
                l4 -= pageSize;
                l5 -= pageSize;
                l6 -= pageSize;
            }

            label2.Text = iphone14_Nazvanie[l1];
            label4.Text = iphone14_Nazvanie[l2];
            label6.Text = iphone14_Nazvanie[l3];
            label10.Text = iphone14_Nazvanie[l4];
            label12.Text = iphone14_Nazvanie[l5];
            label14.Text = iphone14_Nazvanie[l6];


            pictureBox1.Load(iphone14_Img[l1]);
            pictureBox2.Load(iphone14_Img[l2]);
            pictureBox3.Load(iphone14_Img[l3]);
            pictureBox5.Load(iphone14_Img[l4]);
            pictureBox6.Load(iphone14_Img[l5]);
            pictureBox7.Load(iphone14_Img[l6]);


            label3.Text = iphone14_Cena[l1];
            label5.Text = iphone14_Cena[l2];
            label7.Text = iphone14_Cena[l3];
            label11.Text = iphone14_Cena[l4];
            label13.Text = iphone14_Cena[l5];
            label15.Text = iphone14_Cena[l6];
        }
    }
}
