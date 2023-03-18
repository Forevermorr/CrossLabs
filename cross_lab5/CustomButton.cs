using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab5
{
    public class CustomButton : Button
    {
        private readonly int nClicks = 3; // 3 клика
        private int timing = 200; // макс. кол-во мс между нажатиями
        private readonly List<DateTime> clickTimestamps; // временная метка

        public event EventHandler TripleClick;

        public CustomButton()
        {
            clickTimestamps = new List<DateTime>();
            timing = 200;
        }

        public int Timing
        {
            get
            {
                return timing;
            }
            set
            {
                timing = (value >= 100 && value <= 300) ? value : 200; // установка 200мс при несовпадении установленного интервала с условием
            }
        }

        protected override void OnClick(EventArgs e)
        {
            DateTime clickTime = DateTime.Now; // запись времени сразу после вызова
            base.OnClick(e);

            if (clickTimestamps.Count == nClicks) // если сделано список последних меток заполнен, то очищается самый первый
            {
                clickTimestamps.RemoveAt(0);
            }

            clickTimestamps.Add(clickTime); // добавление текущего клика

            if (clickTimestamps.Count == nClicks) // если список теперь содержит нужное кол-во элементов, то создаётся флаг checker
            {
                bool checker = true;

                for (int i = 1; i < nClicks; i++) // проверка, больше ли разница между кликами, чем макс. кол-во мс между нажатиями
                {
                    if ((clickTimestamps[i] - clickTimestamps[i - 1]).Milliseconds > timing)
                    {
                        checker = false;
                    }
                }

                if (checker == true) // если да, то вызывается обработчик события
                {
                    clickTimestamps.Clear();
                    EventHandler handler = TripleClick;
                    handler.Invoke(this, e);
                }
            }
        }
    }
}
