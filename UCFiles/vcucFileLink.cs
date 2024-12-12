using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCV_LIB.UCFiles
{
    public partial class vcucFileLink : UserControl
    {
        private bool _isHovered = false;

        private string _fileFormat = "pdf";
        private double _certainty = 0.0;
        private string _filename = "somefile.pdf";
        private string _filepath = @"C:\somepath\somefile.pdf";

        public event EventHandler<string> FileClicked;

        public string FileFormat
        {
            get => _fileFormat;
            set { _fileFormat = value; this.Invalidate(); }
        }

        public double Certainty
        {
            get => _certainty;
            set { _certainty = value; this.Invalidate(); }
        }

        public string FileName
        {
            get => _filename;
            set { _filename = value; this.Invalidate(); }
        }

        public string FilePath
        {
            get => _filepath;
            set { _filepath = value; this.Invalidate(); }
        }

        public vcucFileLink()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(360, 40);

            this.MouseEnter += vcucFileLink_MouseEnter;
            this.MouseLeave += vcucFileLink_MouseLeave;
            this.Click += vcucFileLink_Click;
            this.DoubleClick += vcucFileLink_Click; // If you want double-click also
            this.ResizeRedraw = true; // Redraw on resize
        }

        private void vcucFileLink_MouseEnter(object sender, EventArgs e)
        {
            _isHovered = true;
            this.Invalidate();
        }

        private void vcucFileLink_MouseLeave(object sender, EventArgs e)
        {
            _isHovered = false;
            this.Invalidate();
        }

        private void vcucFileLink_Click(object sender, EventArgs e)
        {
            FileClicked?.Invoke(this, _filepath);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var textColor = this.Enabled ? Color.Black : SystemColors.GrayText;
            using (var textBrush = new SolidBrush(textColor))
            {
                // Layout:
                // Line 1: File Format: {format}, Certainty: {certainty:F2}%
                // Line 2: FileName: {filename}
                // Line 3: FilePath: {filepath}

                int padding = 4;
                int lineSpacing = 12; // vertical spacing between lines
                int x = padding;
                int y = padding;

                string line1 = $"File Format: {_fileFormat}, Certainty: {_certainty:F2}%";
                string line2 = $"FileName: {_filename}";
                string line3 = $"FilePath: {_filepath}";

                e.Graphics.DrawString(line1, this.Font, textBrush, x, y);
                y += lineSpacing;
                e.Graphics.DrawString(line2, this.Font, textBrush, x, y);
                y += lineSpacing;
                e.Graphics.DrawString(line3, this.Font, textBrush, x, y);
            }

            if (_isHovered)
            {
                using (Pen pen = new Pen(Color.Green, 2))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
}
