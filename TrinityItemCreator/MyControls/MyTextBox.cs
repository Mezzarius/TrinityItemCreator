using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class MyTextBox : TextBox
{
    const uint RDW_INVALIDATE = 0x1;
    const uint RDW_IUPDATENOW = 0x100;
    const uint RDW_FRAME = 0x400;
    [DllImport("user32.dll")]
    static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
    Color borderColor = Color.Blue;

    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero, RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }
    }

}