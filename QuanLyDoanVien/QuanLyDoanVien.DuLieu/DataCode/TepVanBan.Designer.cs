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

    public partial class TepVanBan : BaseObject
    {
        VanBan fVanBan;
        [Association(@"TepVanBanReferencesVanBan")]
        [DevExpress.Xpo.DisplayName(@"Văn bản")]
        public VanBan VanBan
        {
            get { return fVanBan; }
            set { SetPropertyValue<VanBan>("VanBan", ref fVanBan, value); }
        }
        string fDuongDanTep;
        [DevExpress.Xpo.DisplayName(@"Đường dẫn tệp")]
        public string DuongDanTep
        {
            get { return fDuongDanTep; }
            set { SetPropertyValue<string>("DuongDanTep", ref fDuongDanTep, value); }
        }
    }

}
