﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace QuanLyDoanVien.DuLieu
{

    public partial class KhenThuong : BaseObject
    {
        NhanSu fNhanSu;
        [DevExpress.Xpo.DisplayName(@"Nhân sự")]
        public NhanSu NhanSu
        {
            get { return fNhanSu; }
            set { SetPropertyValue<NhanSu>("NhanSu", ref fNhanSu, value); }
        }
        HinhThucKhenThuong fHinhThucKhenThuong;
        [DevExpress.Xpo.DisplayName(@"Hình thức KT")]
        public HinhThucKhenThuong HinhThucKhenThuong
        {
            get { return fHinhThucKhenThuong; }
            set { SetPropertyValue<HinhThucKhenThuong>("HinhThucKhenThuong", ref fHinhThucKhenThuong, value); }
        }
        string fNoiDungKhenThuong;
        [DevExpress.Xpo.DisplayName(@"Nội dung KT")]
        public string NoiDungKhenThuong
        {
            get { return fNoiDungKhenThuong; }
            set { SetPropertyValue<string>("NoiDungKhenThuong", ref fNoiDungKhenThuong, value); }
        }
        DateTime fNgayKhenThuong;
        [DevExpress.Xpo.DisplayName(@"Ngày KT")]
        public DateTime NgayKhenThuong
        {
            get { return fNgayKhenThuong; }
            set { SetPropertyValue<DateTime>("NgayKhenThuong", ref fNgayKhenThuong, value); }
        }
    }

}
