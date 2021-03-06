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
namespace Lpnt.QuanLyKyThi.DuLieu
{

    public partial class NguoiDung : BaseObject
    {
        string fTenDangNhap;
        [DevExpress.Xpo.DisplayName(@"Tên đăng nhập")]
        public string TenDangNhap
        {
            get { return fTenDangNhap; }
            set { SetPropertyValue<string>("TenDangNhap", ref fTenDangNhap, value); }
        }
        string fMatKhau;
        [DevExpress.Xpo.DisplayName(@"Mật khẩu")]
        public string MatKhau
        {
            get { return fMatKhau; }
            set { SetPropertyValue<string>("MatKhau", ref fMatKhau, value); }
        }
        string fHoVaTen;
        [DevExpress.Xpo.DisplayName(@"Họ và tên")]
        public string HoVaTen
        {
            get { return fHoVaTen; }
            set { SetPropertyValue<string>("HoVaTen", ref fHoVaTen, value); }
        }
        string fDienThoai;
        [DevExpress.Xpo.DisplayName(@"Điện thoại")]
        public string DienThoai
        {
            get { return fDienThoai; }
            set { SetPropertyValue<string>("DienThoai", ref fDienThoai, value); }
        }
        string fEmailLienHe;
        [DevExpress.Xpo.DisplayName(@"Email liên hệ")]
        public string EmailLienHe
        {
            get { return fEmailLienHe; }
            set { SetPropertyValue<string>("EmailLienHe", ref fEmailLienHe, value); }
        }
        bool fHoatDong;
        [DevExpress.Xpo.DisplayName(@"Hoạt động")]
        public bool HoatDong
        {
            get { return fHoatDong; }
            set { SetPropertyValue<bool>("HoatDong", ref fHoatDong, value); }
        }
        NhomNguoiDung fNhomNguoiDung;
        [Association(@"NguoiDungReferencesNhomNguoiDung")]
        [DevExpress.Xpo.DisplayName(@"Nhóm người dùng")]
        public NhomNguoiDung NhomNguoiDung
        {
            get { return fNhomNguoiDung; }
            set { SetPropertyValue<NhomNguoiDung>("NhomNguoiDung", ref fNhomNguoiDung, value); }
        }
        bool fQuanTri;
        [DevExpress.Xpo.DisplayName(@"Quản trị")]
        public bool QuanTri
        {
            get { return fQuanTri; }
            set { SetPropertyValue<bool>("QuanTri", ref fQuanTri, value); }
        }
    }

}
