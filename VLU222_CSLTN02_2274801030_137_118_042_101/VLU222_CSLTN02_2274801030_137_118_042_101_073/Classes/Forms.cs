﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLU222_CSLTN02_2274801030_137_118_042_101_073.UI;

namespace VLU222_CSLTN02_2274801030_137_118_042_101_073.Classes
{
    internal static class Forms
    {
        private static QLDETAINCKHSINHVIEN mainMenu;
        private static FDeTai deTai;
        private static FThamGiaDT thamGiaDT;
        private static FGiangVien giangVien;
        private static FSinhVien sinhVien;
        private static FKhoa khoa;
        private static FThanhVien thanhVien;

        public static QLDETAINCKHSINHVIEN MainMenu { get => mainMenu; set => mainMenu = value; }
        public static FDeTai DeTai { get => deTai; set => deTai = value; }
        public static FThamGiaDT ThamGiaDT { get => thamGiaDT; set => thamGiaDT = value; }
        public static FGiangVien GiangVien { get => giangVien; set => giangVien = value; }
        public static FSinhVien SinhVien { get => sinhVien; set => sinhVien = value; }
        public static FKhoa Khoa { get => khoa; set => khoa = value; }
        public static FThanhVien ThanhVien { get => thanhVien; set => thanhVien = value; }

        public static void TxtNumberInputHandler(bool allowNegative, bool isDecimal, TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (allowNegative)
                if (e.KeyChar == '-' && textBox.Text.Length == 0) return;
            if (isDecimal)
                if (e.KeyChar == '.' && textBox.Text.Length > 0 && !textBox.Text.Contains(".")) return;
            e.Handled = true;
        }

        public static void TxtInputConstraint(TextBox textBox, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                if (textBox.Text.EndsWith(" ") || textBox.Text.Length == 0)
                    e.Handled = true;
        }

        public static void TxtClearInput(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
                textBox.Clear();
            textBoxes[0].Focus();
        }

        public static void LsbRightClickDeselected(ListBox listBox, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) listBox.SelectedIndex = -1;
        }

        public static bool LsbHasItemSelected(int selectedIndex, string message)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        public static void LsbUpdateItem(ListBox listBox, int index, object item)
        {
            listBox.Items.RemoveAt(index);
            listBox.Items.Insert(index, item);
            listBox.SelectedIndex = index;
        }
    }
}