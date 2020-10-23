using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TourApp.UI
{
    public abstract class Theme
    {
        public abstract Color MenuStripBG { get; }
        public abstract Color MenuStripFG { get; }
        public abstract Color PanelBG { get; }
        public abstract Color PanelFG { get; }
        public abstract Color TabControlBG { get; }
        public abstract Color TabControlFG { get; }
        public abstract Color TabPageBG { get; }
        public abstract Color TabPageFG { get; }
        public abstract Color DataGridviewBG { get; }
        public abstract Color DataGridviewFG { get; }
        public abstract Color DataGridviewGridColor { get; }
        public abstract Color ButtonBG { get; }
        public abstract Color ButtonFG { get; }
        public abstract Color TextBoxBG { get; }
        public abstract Color TextBoxFG { get; }
    }
    public class DarkTheme : Theme
    {
        public override Color PanelBG { get { return Color.DarkGray; } }
        public override Color PanelFG { get { return Color.Green; } }
        public override Color TabControlBG { get { return Color.Red; } }
        public override Color TabControlFG { get { return Color.Purple; } }
        public override Color TabPageBG { get { return Color.FromArgb(255,37,37,38); } }
        public override Color TabPageFG { get { return Color.DarkGreen; } }
        public override Color DataGridviewBG { get { return Color.FromArgb(255, 30, 30, 30); } }
        public override Color DataGridviewFG { get { return Color.DarkGreen; } }
        public override Color DataGridviewGridColor { get { return Color.Red; } }
        public override Color ButtonBG { get { return Color.DarkGray; } }
        public override Color ButtonFG { get { return Color.White; } }
        public override Color TextBoxBG { get { return Color.DarkGray; } }
        public override Color TextBoxFG { get { return Color.White; } }
        public override Color MenuStripBG { get { return Color.DarkGray; } }
        public override Color MenuStripFG { get { return Color.White; } }

    }
    public class LightTheme : Theme
    {
        public override Color PanelBG { get { return Color.White; } }
        public override Color PanelFG { get { return Color.Black; } }
        public override Color TabControlBG { get { return Color.WhiteSmoke; } }
        public override Color TabControlFG { get { return Color.Black; } }
        public override Color TabPageBG { get { return Color.White; } }
        public override Color TabPageFG { get { return Color.Black; } }
        public override Color DataGridviewBG { get { return Color.White; } }
        public override Color DataGridviewFG { get { return Color.Black; } }
        public override Color DataGridviewGridColor { get { return Color.Gray; } }
        public override Color ButtonBG { get { return Color.White; } }
        public override Color ButtonFG { get { return Color.White; } }
        public override Color TextBoxBG { get { return Color.White; } }
        public override Color TextBoxFG { get { return Color.Black; } }
        public override Color MenuStripBG { get { return Color.White; } }
        public override Color MenuStripFG { get { return Color.Black; } }
    }
    public class DefaultTheme : Theme
    {
        public override Color PanelBG { get { return Color.White; } }
        public override Color PanelFG { get { return Color.Black; } }
        public override Color TabControlBG { get { return Color.WhiteSmoke; } }
        public override Color TabControlFG { get { return Color.Black; } }
        public override Color TabPageBG { get { return Color.White; } }
        public override Color TabPageFG { get { return Color.Black; } }
        public override Color DataGridviewBG { get { return SystemColors.ControlDark; } }
        public override Color DataGridviewFG { get { return Color.Black; } }
        public override Color DataGridviewGridColor { get { return SystemColors.ControlDark; } }
        public override Color ButtonBG { get { return Color.FromArgb(255, 240, 240, 240); } }
        public override Color ButtonFG { get { return SystemColors.ControlText; } }
        public override Color TextBoxBG { get { return Color.White; } }
        public override Color TextBoxFG { get { return Color.Black; } }
        public override Color MenuStripBG { get { return Color.White; } }
        public override Color MenuStripFG { get { return Color.Black; } }
    }
}
