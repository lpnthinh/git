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

    public partial class NhomNguoiDung : BaseObject
    {
        string fTenNhom;
        [DevExpress.Xpo.DisplayName(@"Tên nhóm")]
        public string TenNhom
        {
            get { return fTenNhom; }
            set { SetPropertyValue<string>("TenNhom", ref fTenNhom, value); }
        }
        bool fQuanTri;
        [DevExpress.Xpo.DisplayName(@"Quản trị")]
        public bool QuanTri
        {
            get { return fQuanTri; }
            set { SetPropertyValue<bool>("QuanTri", ref fQuanTri, value); }
        }
        [Association(@"PhanQuyenReferencesNhomNguoiDung"), Aggregated]
        public XPCollection<PhanQuyen> PhanQuyens { get { return GetCollection<PhanQuyen>("PhanQuyens"); } }
        [Association(@"NguoiDungReferencesNhomNguoiDung"), Aggregated]
        public XPCollection<NguoiDung> NguoiDungs { get { return GetCollection<NguoiDung>("NguoiDungs"); } }
    }

}
