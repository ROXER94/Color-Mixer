// Inspired by: https://youtu.be/LscHhkyRnck
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class frmColorMixer : Form
    {
        private Brush brush = Brushes.Black;
        private Font font = new Font(new FontFamily("Microsoft Sans Serif"), 12);

        public frmColorMixer()
        {
            InitializeComponent();
            MinimumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void frmColorPicker_Load(object sender, EventArgs e)
        {
            scrollBarRed.Value = 255;
            scrollBarGreen.Value = 255;
            scrollBarBlue.Value = 255;
            updateRedLabels();
            updateGreenLabels();
            updateBlueLabels();
        }

        private void frmColorPicker_Paint(object sender, PaintEventArgs e)
        {
            int circleRadius = 400;

            int redValue = Convert.ToInt32(txtRed.Text);
            int greenValue = Convert.ToInt32(txtGreen.Text);
            int blueValue = Convert.ToInt32(txtBlue.Text);

            GraphicsPath redGraphicsPath = new GraphicsPath();
            GraphicsPath greenGraphicsPath = new GraphicsPath();
            GraphicsPath blueGraphicsPath = new GraphicsPath();

            Brush redBrush = new System.Drawing.SolidBrush(Color.FromArgb(redValue, 0, 0));
            Brush greenBrush = new System.Drawing.SolidBrush(Color.FromArgb(0, greenValue, 0));
            Brush blueBrush = new System.Drawing.SolidBrush(Color.FromArgb(0, 0, blueValue));

            redGraphicsPath.AddEllipse(200, 50, circleRadius, circleRadius);
            greenGraphicsPath.AddEllipse(100, 250, circleRadius, circleRadius);
            blueGraphicsPath.AddEllipse(300, 250, circleRadius, circleRadius);

            e.Graphics.FillPath(redBrush, redGraphicsPath);
            e.Graphics.FillPath(greenBrush, greenGraphicsPath);
            e.Graphics.FillPath(blueBrush, blueGraphicsPath);

            Region redGreenRegion = new Region(redGraphicsPath);
            redGreenRegion.Intersect(greenGraphicsPath);
            e.Graphics.FillRegion(new System.Drawing.SolidBrush(Color.FromArgb(redValue, greenValue, 0)), redGreenRegion);

            Region redBlueRegion = new Region(redGraphicsPath);
            redBlueRegion.Intersect(blueGraphicsPath);
            e.Graphics.FillRegion(new System.Drawing.SolidBrush(Color.FromArgb(redValue, 0, blueValue)), redBlueRegion);

            Region greenBlueRegion = new Region(greenGraphicsPath);
            greenBlueRegion.Intersect(blueGraphicsPath);
            e.Graphics.FillRegion(new System.Drawing.SolidBrush(Color.FromArgb(0, greenValue, blueValue)), greenBlueRegion);

            Region redGreenBlueRegion = new Region(redGraphicsPath);
            redGreenBlueRegion.Intersect(greenGraphicsPath);
            redGreenBlueRegion.Intersect(blueGraphicsPath);
            e.Graphics.FillRegion(new System.Drawing.SolidBrush(Color.FromArgb(redValue, greenValue, blueValue)), redGreenBlueRegion);

            int threshold = 128;
            e.Graphics.DrawString("#" + txtRedHex.Text + "0000", font, Brushes.White, 370, 175);
            e.Graphics.DrawString("#00" + txtGreenHex.Text + "00", font, Brushes.White, 175, 500);
            e.Graphics.DrawString("#0000" + txtBlueHex.Text, font, Brushes.White, 565, 500);
            if (scrollBarRed.Value < threshold && scrollBarGreen.Value < threshold) brush = Brushes.White;
            else brush = Brushes.Black;
            e.Graphics.DrawString("#" + txtRedHex.Text + txtGreenHex.Text + "00", font, brush, 240, 305);
            if (scrollBarRed.Value < threshold && scrollBarBlue.Value < threshold) brush = Brushes.White;
            else brush = Brushes.Black;
            e.Graphics.DrawString("#" + txtRedHex.Text + "00" + txtBlueHex.Text, font, brush, 500, 305);
            if (scrollBarGreen.Value < threshold && scrollBarBlue.Value < threshold) brush = Brushes.White;
            else brush = Brushes.Black;
            e.Graphics.DrawString("#00" + txtGreenHex.Text + txtBlueHex.Text, font, brush, 370, 500);
            if (scrollBarRed.Value < threshold && scrollBarGreen.Value < threshold && scrollBarBlue.Value < threshold) brush = Brushes.White;
            else brush = Brushes.Black;
            e.Graphics.DrawString("#" + txtRedHex.Text + txtGreenHex.Text + txtBlueHex.Text, font, brush, 370, 370);
        }

        private void scrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            updateRedLabels();
            Invalidate();
        }

        private void scrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            updateGreenLabels();
            Invalidate();
        }

        private void scrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            updateBlueLabels();
            Invalidate();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            var random = new Random();
            scrollBarRed.Value = random.Next(256);
            scrollBarGreen.Value = random.Next(256);
            scrollBarBlue.Value = random.Next(256);
            updateRedLabels();
            updateGreenLabels();
            updateBlueLabels();
            Invalidate();
        }

        private void updateRedLabels()
        {
            txtRed.Text = scrollBarRed.Value.ToString();
            txtRedBinary.Text = Convert.ToString(scrollBarRed.Value, 2).PadLeft(8, '0');
            txtRedHex.Text = scrollBarRed.Value.ToString("X2");
        }

        private void updateGreenLabels()
        {
            txtGreen.Text = scrollBarGreen.Value.ToString();
            txtGreenBinary.Text = Convert.ToString(scrollBarGreen.Value, 2).PadLeft(8, '0');
            txtGreenHex.Text = scrollBarGreen.Value.ToString("X2");
        }

        private void updateBlueLabels()
        {
            txtBlue.Text = scrollBarBlue.Value.ToString();
            txtBlueBinary.Text = Convert.ToString(scrollBarBlue.Value, 2).PadLeft(8, '0');
            txtBlueHex.Text = scrollBarBlue.Value.ToString("X2");
        }
    }
}