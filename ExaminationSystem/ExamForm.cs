using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 70; i++)
            {
                Button button = new Button();
                button.Location = new Point(40, i * 40 + 5 * i);
                button.Size = new Size(90, 40);
                button.Text = "RadButton" + i.ToString();
                this.panel3.Controls.Add(button);
            }
        }
    }
}
