using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace lab8Crossplatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<News> newslist = new List<News>();
        int counts = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Choose();

            XElement rootTag = XElement.Load("https://lenta.ru/rss/articles/"); // Создает новый элемент XElement из файла, заданного URI
            XElement root = rootTag.Element("channel"); // Получает первый дочерний элемент с заданным XName

            if (root != null)
            {
                foreach (XElement lentaNews in root.Elements("item"))
                {
                    XElement titles = lentaNews.Element("title");
                    XElement links = lentaNews.Element("link");
                    XElement info = lentaNews.Element("description");
                    XElement dates = lentaNews.Element("pubDate");

                    newslist.Add(new News(titles.Value, info.Value, links.Value, dates.Value));
                    counts++;
                    chooseBox.Items.Add(counts);
                }
            }

            counts = 0;
            chooseBox.SelectedIndex = counts;
            lbTitle.Text = newslist[counts].title;
            lbInformation.Text = newslist[counts].information;
            tbLink.Text = newslist[counts].link;
            lbDate.Text = newslist[counts].date;
            lbNews.Text = Convert.ToString(counts + 1);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            counts--;
            lbTitle.Text = newslist[counts].title;
            lbInformation.Text = newslist[counts].information;
            tbLink.Text = newslist[counts].link;
            lbDate.Text = newslist[counts].date;
            chooseBox.SelectedIndex = counts;
            lbNews.Text = Convert.ToString(counts + 1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            counts++;
            lbTitle.Text = newslist[counts].title;
            lbInformation.Text = newslist[counts].information;
            tbLink.Text = newslist[counts].link;
            lbDate.Text = newslist[counts].date;
            chooseBox.SelectedIndex = counts;
            lbNews.Text = Convert.ToString(counts + 1);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            lbTitle.Text = newslist[chooseBox.SelectedIndex].title;
            lbInformation.Text = newslist[chooseBox.SelectedIndex].information;
            tbLink.Text = newslist[chooseBox.SelectedIndex].link;
            lbDate.Text = newslist[chooseBox.SelectedIndex].date;
            counts = chooseBox.SelectedIndex;
            lbNews.Text = Convert.ToString(counts + 1);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        async void Choose()
        {
            while (true)
            {
                if (counts > 0)
                {
                    buttonPrev.Enabled = true;
                }
                else
                {
                    buttonPrev.Enabled = false;
                }

                if (counts < newslist.Count - 1)
                {
                    buttonNext.Enabled = true;
                }
                else
                {
                    buttonNext.Enabled = false;
                }
                await Task.Delay(10);
            }
        }
    }
}
