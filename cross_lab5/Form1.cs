using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public int tripleClicksCount;

        public Form1()
        {
            InitializeComponent();
            tripleClicksCount = 0;
            label_tripleClicks.Text = $"TripleClicks: {tripleClicksCount}";
            tb_interval.Value = 200;
            label_interval.Text = $"Интервал: {customButton.Timing} мс";
        }

        private void tb_interval_ValueChanged(object sender, EventArgs e)
        {
            customButton.Timing = tb_interval.Value;
            label_interval.Text = $"Интервал: {customButton.Timing} мс";
        }

        private void customButton_TripleClick(object sender, EventArgs e)
        {
            tripleClicksCount++;
            label_tripleClicks.Text = $"TripleClicks: {tripleClicksCount}";
        }
    }
}
