﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nucleus.Coop.App.Controls
{
    public partial class HorizontalLineControl : UserControl
    {
        private Panel line;
        public Color LineColor { get { return line.BackColor; } set { line.BackColor = value; } }
        public int LineHeight
        {
            get { return line.Height; }
            set
            {
                line.Height = value;
                this.Height = value;
            }
        }
        public double LineHorizontalPc { get; set; }

        public HorizontalLineControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None; // SERIOUSLY FUCK THIS

            line = new Panel();
            this.Controls.Add(line);

            LineColor = Color.CornflowerBlue;
            LineHeight = 1;
            LineHorizontalPc = 80;

            this.Size = new Size(100, 1);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            int scaledWidth = (int)(this.Width * (LineHorizontalPc / 100.0));
            line.Width = scaledWidth;
            line.Left = (this.Width / 2) - (scaledWidth / 2);

            base.OnSizeChanged(e);
        }
    }
}