﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;



namespace QLHS.FormChinh
{
    public partial class ThayDoiQuyDinh : Form
    {
        ThayDoiQuyDinhBLL quydinh;
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
            quydinh = new ThayDoiQuyDinhBLL();
        }

        // load cac tham so va gia tri
        void LoadThamSo_DanhSachThamSo()
        {

            lvDSthamso.Items.Clear();
            List<ThamSo> listThamSo = quydinh.GetListThamSo();

            int soThuTu = 1;

            foreach (ThamSo thamso in listThamSo)
            {
                ListViewItem lvi = new ListViewItem(soThuTu + "");
                lvi.SubItems.Add(thamso.TenThamSo);
                lvi.SubItems.Add(thamso.GiaTri.ToString());
                soThuTu++;

                lvDSthamso.Items.Add(lvi);
            }

            nricTuoitoithieu.Value =Int32.Parse( lvDSthamso.Items[0].SubItems[2].Text);
            nrictoitoida.Value = Int32.Parse(lvDSthamso.Items[1].SubItems[2].Text);
            nricsiso.Value = Int32.Parse(lvDSthamso.Items[2].SubItems[2].Text);
            nricdiemtoithieu.Value = Int32.Parse(lvDSthamso.Items[3].SubItems[2].Text);
            nricdiemtoida.Value = Int32.Parse(lvDSthamso.Items[4].SubItems[2].Text);
            nricdiemdatmon.Value = Int32.Parse(lvDSthamso.Items[5].SubItems[2].Text);
            nricdiemdathk.Value = Int32.Parse(lvDSthamso.Items[6].SubItems[2].Text);
        }

        

        private void btApDung_Click(object sender, System.EventArgs e)
        {
            if (nricTuoitoithieu.Value != 0)
                quydinh.SuaThamSo("thamso1", nricTuoitoithieu.Value);
            if (nrictoitoida.Value != 0)
                quydinh.SuaThamSo("thamso2", nrictoitoida.Value);
            if (nricsiso.Value != 0)
                quydinh.SuaThamSo("thamso3", nricsiso.Value);
            if (nricdiemtoithieu.Value != 0)
                quydinh.SuaThamSo("thamso4", nricdiemtoithieu.Value);
            if (nricdiemtoida.Value != 0)
                quydinh.SuaThamSo("thamso5", nricdiemtoida.Value);
            if (nricdiemdatmon.Value != 0)
                quydinh.SuaThamSo("thamso6", nricdiemdatmon.Value);
            if (nricdiemdathk.Value != 0)
                quydinh.SuaThamSo("thamso7", nricdiemdathk.Value);
            MessageBox.Show(" Thay đổi quy định thành công");
        }



        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            LoadThamSo_DanhSachThamSo();
        }
    }
}
