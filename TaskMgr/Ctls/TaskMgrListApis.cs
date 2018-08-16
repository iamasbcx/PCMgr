﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PCMgr.Ctls
{
    static class TaskMgrListApis
    {
        public static int M_DRAW_HEADER_HOT = 1;
        public static int M_DRAW_HEADER_PRESSED = 2;
        public static int M_DRAW_HEADER_SORTDOWN = 3;
        public static int M_DRAW_HEADER_SORTUP = 4;

        [DllImport(FormMain.COREDLLNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MHeaderDrawItem(IntPtr hTheme, IntPtr hdc, int x, int y, int w, int h, int state);
        [DllImport(FormMain.COREDLLNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MOpenThemeData(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string className);
        [DllImport(FormMain.COREDLLNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MCloseThemeData(IntPtr hTheme);
        [DllImport(FormMain.COREDLLNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MSetAsExplorerTheme(IntPtr hWnd);

        [DllImport(FormMain.COREDLLNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MDrawIcon(IntPtr hIcon, IntPtr hdc, int x, int y);

        public static int M_DRAW_LISTVIEW_HOT = 1;
        public static int M_DRAW_LISTVIEW_SELECT_NOFOCUS = 2;
        public static int M_DRAW_LISTVIEW_HOT_SELECT = 3;
        public static int M_DRAW_LISTVIEW_SELECT = 4;

        public static int M_DRAW_TREEVIEW_GY_OPEN = 5;
        public static int M_DRAW_TREEVIEW_GY_CLOSED = 6;
        public static int M_DRAW_TREEVIEW_GY_OPEN_HOT = 7;
        public static int M_DRAW_TREEVIEW_GY_CLOSED_HOT = 8;

        [DllImport(FormMain.COREDLLNAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MListDrawItem(IntPtr hTheme, IntPtr hdc, int x, int y, int w, int h, int state);
    }
}