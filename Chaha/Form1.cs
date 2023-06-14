using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace Chaha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel panel = GeneratePanel();
            panel.Location = new Point(panel5.Location.X, panel5.Location.Y + panel5.Size.Height);
            this.Controls.Add(panel);

            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://woap.ru/zapchasti-dlya-iphone/zapchasti-iphone-14-pro-max");

            HtmlNodeCollection iphone14_Nazvanie_Nodes = document.DocumentNode.SelectNodes("//div[@class='field-item odd']");
            HtmlNodeCollection iphone14_Img_Nodes = document.DocumentNode.SelectNodes("//div[@class='field field-name-uc-product-image field-type-image field-label-hidden']");
            HtmlNodeCollection iphone14_Cena_Nodes = document.DocumentNode.SelectNodes("//span[@class='uc-price']");

            List<string> iphone14_Nazvanie = new List<string>();
            List<string> iphone14_Img = new List<string>();
            List<string> iphone14_Cena = new List<string>();

            foreach(var item in iphone14_Nazvanie_Nodes)
            {
                iphone14_Nazvanie.Add(item.ChildNodes[0].InnerText);
            }

            foreach(var item in iphone14_Img_Nodes)
            {
                iphone14_Img.Add(item.ChildNodes.First().ChildNodes.First().Attributes["src"].Value);
            }

            foreach (var item in iphone14_Cena_Nodes)
            {
                iphone14_Cena.Add(item.InnerText);
            }

            label2.Text = iphone14_Nazvanie[0];
            pictureBox1.Load(iphone14_Img[0]);
            label3.Text = iphone14_Cena[0];
        }

        public Panel GeneratePanel()
        {
            Panel main = new Panel();
            //main.BorderStyle = BorderStyle.FixedSingle;
            main.Size = panel5.Size;

            Panel panel1 = new Panel();
            Panel panel2 = new Panel();
            Panel panel3 = new Panel();
            Panel panel4 = new Panel();

            PictureBox picture1 = new PictureBox();
            PictureBox picture2 = new PictureBox();
            PictureBox picture3 = new PictureBox();
            PictureBox picture4 = new PictureBox();

            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();

            Label clabel1 = new Label();
            Label clabel2 = new Label();
            Label clabel3 = new Label();
            Label clabel4 = new Label();

            panel1.Controls.Add(label1);
            panel1.Controls.Add(picture1);
            panel1.Controls.Add(clabel1);

            panel2.Controls.Add(label2);
            panel2.Controls.Add(picture2);
            panel2.Controls.Add(clabel2);

            panel3.Controls.Add(label3);
            panel3.Controls.Add(picture3);
            panel3.Controls.Add(clabel3);

            panel4.Controls.Add(label4);
            panel4.Controls.Add(picture4);
            panel4.Controls.Add(clabel4);

            panel1.Size = this.panel1.Size;
            panel2.Size = this.panel2.Size;
            panel3.Size = this.panel3.Size;
            panel4.Size = this.panel4.Size;

            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel4.BorderStyle = BorderStyle.FixedSingle;

            panel1.Margin = new Padding(3);
            panel2.Margin = new Padding(3);
            panel3.Margin = new Padding(3);
            panel4.Margin = new Padding(3);

            panel2.Location = new Point(panel1.Location.X + panel1.Size.Width + 6, panel1.Location.Y);
            panel3.Location = new Point(panel2.Location.X + panel2.Size.Width + 6, panel2.Location.Y);
            panel4.Location = new Point(panel3.Location.X + panel3.Size.Width + 6, panel3.Location.Y);

            picture1.Size = pictureBox1.Size; 
            picture2.Size = pictureBox2.Size;
            picture3.Size = pictureBox3.Size;
            picture4.Size = pictureBox4.Size;

            label1.Size = this.label2.Size;
            label2.Size = this.label4.Size;
            label3.Size = this.label6.Size;
            label4.Size = this.label8.Size;

            clabel1.Size = this.label3.Size;
            clabel2.Size = this.label5.Size;
            clabel3.Size = this.label7.Size;
            clabel4.Size = this.label9.Size;

            main.Controls.Add(panel1);
            main.Controls.Add(panel2);
            main.Controls.Add(panel3);
            main.Controls.Add(panel4);

            return main;
        }
    }
}
