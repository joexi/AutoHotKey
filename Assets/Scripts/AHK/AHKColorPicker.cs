 using System;
using UnityEngine;
using System.Windows.Forms;
using System.Runtime.InteropServices;


[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct AHKPos
{
    public int x;
    public int y;

    public AHKPos(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static AHKPos Zero
    {
        get
        {
            return new AHKPos();
        }
    }

    public static AHKPos Center
    {
        get
        {
            return new AHKPos(AHKSetting.ScreenWidth / 2, AHKSetting.ScreenHeigh / 2);
        }
    }
};
public partial class AHKColorPicker : Form
{
    #region 定义快捷键

    //如果函数执行成功，返回值不为0。       
    //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。        
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool RegisterHotKey(
        IntPtr hWnd, //要定义热键的窗口的句柄            
        int id, //定义热键ID（不能与其它ID重复）                       
        KeyModifiers fsModifiers, //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效         
        Keys vk //定义热键的内容            
    );

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool UnregisterHotKey(
        IntPtr hWnd, //要取消热键的窗口的句柄            
        int id //要取消热键的ID            
    );

    //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）        
    [Flags()]
    public enum KeyModifiers
    {
        None = 0,
        Alt = 1,
        Ctrl = 2,
        Shift = 4,
        WindowsKey = 8
    }

    #endregion



    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetCursorPos(out AHKPos lpPoint);

    [DllImport("gdi32.dll")]
    static public extern uint GetPixel(IntPtr hDC, int XPos, int YPos);

    [DllImport("gdi32.dll")]
    static public extern IntPtr CreateDC(string driverName, string deviceName, string output, IntPtr lpinitData);

    [DllImport("gdi32.dll")]
    static public extern bool DeleteDC(IntPtr DC);

    static public byte GetRValue(uint color)
    {
        return (byte)color;
    }

    static public byte GetGValue(uint color)
    {
        return ((byte)(((short)(color)) >> 8));
    }

    static public byte GetBValue(uint color)
    {
        return ((byte)((color) >> 16));
    }

    static public byte GetAValue(uint color)
    {
        return ((byte)((color) >> 24));
    }

    public static AHKColor GetColor()
    {
        AHKPos cursorPos;
        GetCursorPos(out cursorPos);
        return GetColor(cursorPos);
    }

    public static AHKColor GetColor(AHKPos pos)
    {
        IntPtr displayDC = CreateDC("DISPLAY", null, null, IntPtr.Zero);
        uint colorref = GetPixel(displayDC, pos.x, pos.y);
        DeleteDC(displayDC);
        byte r = GetRValue(colorref);
        byte g = GetGValue(colorref);
        byte b = GetBValue(colorref);
        var result = new AHKColor(r, g, b);
        return result;
    }
}