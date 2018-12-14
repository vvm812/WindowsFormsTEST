using System;
using System.Windows.Forms;

namespace WindowsFormsTEST
{
    partial class MyButtonClass : Form
    {
        private Button mrButton;

        public MyButtonClass()
        {
            InitializeComponent();
            mrButton = new Button();
            mrButton.Text = "Надпись вот тут изменилась!";
            mrButton.Top = 100;
            mrButton.Left = 100;
            mrButton.Height = 50;
            mrButton.Width = 70;
            mrButton.Click += MrButton_Click;
            mrButton.MouseDown += MrButton_MouseDown;
            this.Controls.Add(mrButton);
        }

        private void MrButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MrButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Text = "Нажата левая кнопка мыши";
        }
    }
}
