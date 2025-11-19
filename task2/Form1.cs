using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public class ColorEventArgs : EventArgs
    {
        public string SelectedColor { get; }

        public ColorEventArgs(string color)
        {
            SelectedColor = color;
        }
    }

    public delegate void TextChangedEventHandler(string newText);

    public class EventPublisher
    {
        public event EventHandler<ColorEventArgs> ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        public void RaiseColorChanged(string color)
        {
            ColorChangedEvent?.Invoke(this, new ColorEventArgs(color));
        }

        public void RaiseTextChanged(string newText)
        {
            TextChangedEvent?.Invoke(newText);
        }
    }

    public partial class Form1 : Form
    {
        EventPublisher publisher = new EventPublisher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            publisher.ColorChangedEvent += UpdateLabelColor;
            publisher.ColorChangedEvent += ShowNotification;
            publisher.TextChangedEvent += UpdateLabelText;
        }


        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            labelMessage.ForeColor = Color.FromName(e.SelectedColor);
        }

        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show("Selected Color: " + e.SelectedColor, "Notification");
        }

        private void UpdateLabelText(string newText)
        {
            labelMessage.Text = newText;
        }


        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            string selectedColor = comboColors.SelectedItem?.ToString();

            if (selectedColor != null)
                publisher.RaiseColorChanged(selectedColor);
            else
                MessageBox.Show("Please select a color first.");
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString();
            publisher.RaiseTextChanged(currentTime);
        }
    }
}
