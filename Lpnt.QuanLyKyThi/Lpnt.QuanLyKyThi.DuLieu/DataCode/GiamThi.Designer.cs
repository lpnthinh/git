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

    public partial class GiamThi : BaseObject
    {
        KhoaThi fId_KhoaThi;
        [Association(@"GiamThiReferencesKhoaThi")]
        public KhoaThi Id_KhoaThi
        {
            get { return fId_KhoaThi; }
            set { SetPropertyValue<KhoaThi>("Id_KhoaThi", ref fId_KhoaThi, value); }
        }
        GiaoVien fId_GiaoVien;
        public GiaoVien Id_GiaoVien
        {
            get { return fId_GiaoVien; }
            set { SetPropertyValue<GiaoVien>("Id_GiaoVien", ref fId_GiaoVien, value); }
        }
    }

}