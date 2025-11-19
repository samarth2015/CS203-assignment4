using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public delegate void ColorChangedEventHandler(string color);
    public delegate void TextChangedEventHandler(string newText);

    public class EventPublisher
    {
        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        public void RaiseColorChanged(string color)
        {
            ColorChangedEvent?.Invoke(color);
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
            publisher.TextChangedEvent += UpdateLabelText;
        }

        private void UpdateLabelColor(string color)
        {
            labelMessage.ForeColor = Color.FromName(color);
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
