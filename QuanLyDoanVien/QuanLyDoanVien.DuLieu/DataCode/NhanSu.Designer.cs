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

    public partial class NhanSu : BaseObject
    {
        DonVi fDonVi;
        [DevExpress.Xpo.DisplayName(@"Đơn vị")]
        public DonVi DonVi
        {
            get { return fDonVi; }
            set { SetPropertyValue<DonVi>("DonVi", ref fDonVi, value); }
        }
        NienKhoa fNienKhoa;
        [DevExpress.Xpo.DisplayName(@"Niên khóa")]
        public NienKhoa NienKhoa
        {
            get { return fNienKhoa; }
            set { SetPropertyValue<NienKhoa>("NienKhoa", ref fNienKhoa, value); }
        }
        bool fHoatDong;
        [DevExpress.Xpo.DisplayName(@"Hoạt động")]
        public bool HoatDong
        {
            get { return fHoatDong; }
            set { SetPropertyValue<bool>("HoatDong", ref fHoatDong, value); }
        }
        int fThuTu;
        [DevExpress.Xpo.DisplayName(@"Thứ tự")]
        public int ThuTu
        {
            get { return fThuTu; }
            set { SetPropertyValue<int>("ThuTu", ref fThuTu, value); }
        }
        string fSoHoSo;
        [DevExpress.Xpo.DisplayName(@"Số hồ sơ")]
        public string SoHoSo
        {
            get { return fSoHoSo; }
            set { SetPropertyValue<string>("SoHoSo", ref fSoHoSo, value); }
        }
        string fHoDem;
        [DevExpress.Xpo.DisplayName(@"Họ đệm")]
        public string HoDem
        {
            get { return fHoDem; }
            set { SetPropertyValue<string>("HoDem", ref fHoDem, value); }
        }
        string fTen;
        [DevExpress.Xpo.DisplayName(@"Tên")]
        public string Ten
        {
            get { return fTen; }
            set { SetPropertyValue<string>("Ten", ref fTen, value); }
        }
        int fGioiTinh;
        [DevExpress.Xpo.DisplayName(@"Giới tính")]
        public int GioiTinh
        {
            get { return fGioiTinh; }
            set { SetPropertyValue<int>("GioiTinh", ref fGioiTinh, value); }
        }
        DateTime fNgaySinh;
        [DevExpress.Xpo.DisplayName(@"Ngày sinh")]
        public DateTime NgaySinh
        {
            get { return fNgaySinh; }
            set { SetPropertyValue<DateTime>("NgaySinh", ref fNgaySinh, value); }
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
        DanToc fDanToc;
        [DevExpress.Xpo.DisplayName(@"Dân tộc")]
        public DanToc DanToc
        {
            get { return fDanToc; }
            set { SetPropertyValue<DanToc>("DanToc", ref fDanToc, value); }
        }
        TonGiao fTonGiao;
        [DevExpress.Xpo.DisplayName(@"Tôn giáo")]
        public TonGiao TonGiao
        {
            get { return fTonGiao; }
            set { SetPropertyValue<TonGiao>("TonGiao", ref fTonGiao, value); }
        }
        HanhChinh fHoKhauThuongTru;
        [DevExpress.Xpo.DisplayName(@"Hộ khẩu thường trú")]
        public HanhChinh HoKhauThuongTru
        {
            get { return fHoKhauThuongTru; }
            set { SetPropertyValue<HanhChinh>("HoKhauThuongTru", ref fHoKhauThuongTru, value); }
        }
        string fNoiOHienNay;
        [DevExpress.Xpo.DisplayName(@"Nơi ở hiện nay")]
        public string NoiOHienNay
        {
            get { return fNoiOHienNay; }
            set { SetPropertyValue<string>("NoiOHienNay", ref fNoiOHienNay, value); }
        }
        string fNgheNghiepBanThan;
        [DevExpress.Xpo.DisplayName(@"Nghề nghiệp bản thân")]
        public string NgheNghiepBanThan
        {
            get { return fNgheNghiepBanThan; }
            set { SetPropertyValue<string>("NgheNghiepBanThan", ref fNgheNghiepBanThan, value); }
        }
        string fNoiHocTapLamViec;
        [DevExpress.Xpo.DisplayName(@"Nơi học tập, làm việc")]
        public string NoiHocTapLamViec
        {
            get { return fNoiHocTapLamViec; }
            set { SetPropertyValue<string>("NoiHocTapLamViec", ref fNoiHocTapLamViec, value); }
        }
        TrinhDoHocVan fTrinhDoHocVan;
        [DevExpress.Xpo.DisplayName(@"Trình độ học vấn")]
        public TrinhDoHocVan TrinhDoHocVan
        {
            get { return fTrinhDoHocVan; }
            set { SetPropertyValue<TrinhDoHocVan>("TrinhDoHocVan", ref fTrinhDoHocVan, value); }
        }
        TrinhDoChuyenMon fTrinhDoChuyenMon;
        [DevExpress.Xpo.DisplayName(@"Trình độ chuyên môn")]
        public TrinhDoChuyenMon TrinhDoChuyenMon
        {
            get { return fTrinhDoChuyenMon; }
            set { SetPropertyValue<TrinhDoChuyenMon>("TrinhDoChuyenMon", ref fTrinhDoChuyenMon, value); }
        }
        TrinhDoLyLuanChinhTri fTrinhDoLyLuanChinhTri;
        [DevExpress.Xpo.DisplayName(@"Trình độ lý luận chính trị")]
        public TrinhDoLyLuanChinhTri TrinhDoLyLuanChinhTri
        {
            get { return fTrinhDoLyLuanChinhTri; }
            set { SetPropertyValue<TrinhDoLyLuanChinhTri>("TrinhDoLyLuanChinhTri", ref fTrinhDoLyLuanChinhTri, value); }
        }
        NgoaiNgu fNgoaiNgu;
        [DevExpress.Xpo.DisplayName(@"Ngoại ngữ")]
        public NgoaiNgu NgoaiNgu
        {
            get { return fNgoaiNgu; }
            set { SetPropertyValue<NgoaiNgu>("NgoaiNgu", ref fNgoaiNgu, value); }
        }
        TrinhDoNgoaiNgu fTrinhDoNgoaiNgu;
        [DevExpress.Xpo.DisplayName(@"Trình độ ngoại ngữ")]
        public TrinhDoNgoaiNgu TrinhDoNgoaiNgu
        {
            get { return fTrinhDoNgoaiNgu; }
            set { SetPropertyValue<TrinhDoNgoaiNgu>("TrinhDoNgoaiNgu", ref fTrinhDoNgoaiNgu, value); }
        }
        TrinhDoTinHoc fTrinhDoTinHoc;
        [DevExpress.Xpo.DisplayName(@"Trình độ tin học")]
        public TrinhDoTinHoc TrinhDoTinHoc
        {
            get { return fTrinhDoTinHoc; }
            set { SetPropertyValue<TrinhDoTinHoc>("TrinhDoTinHoc", ref fTrinhDoTinHoc, value); }
        }
        int fTrangThaiDoan;
        [DevExpress.Xpo.DisplayName(@"Trạng thái đoàn")]
        public int TrangThaiDoan
        {
            get { return fTrangThaiDoan; }
            set { SetPropertyValue<int>("TrangThaiDoan", ref fTrangThaiDoan, value); }
        }
        DateTime fNgayVaoDoan;
        [DevExpress.Xpo.DisplayName(@"Ngày vào đoàn")]
        public DateTime NgayVaoDoan
        {
            get { return fNgayVaoDoan; }
            set { SetPropertyValue<DateTime>("NgayVaoDoan", ref fNgayVaoDoan, value); }
        }
        ChucVuDoan fChucVuDoan;
        [DevExpress.Xpo.DisplayName(@"Chức vụ đoàn")]
        public ChucVuDoan ChucVuDoan
        {
            get { return fChucVuDoan; }
            set { SetPropertyValue<ChucVuDoan>("ChucVuDoan", ref fChucVuDoan, value); }
        }
        int fDangVien;
        [DevExpress.Xpo.DisplayName(@"Đảng viên")]
        public int DangVien
        {
            get { return fDangVien; }
            set { SetPropertyValue<int>("DangVien", ref fDangVien, value); }
        }
        DateTime fNgayVaoDang;
        [DevExpress.Xpo.DisplayName(@"Ngày vào đảng")]
        public DateTime NgayVaoDang
        {
            get { return fNgayVaoDang; }
            set { SetPropertyValue<DateTime>("NgayVaoDang", ref fNgayVaoDang, value); }
        }
        ChucVuDang fChucVuDang;
        [DevExpress.Xpo.DisplayName(@"Chức vụ đảng")]
        public ChucVuDang ChucVuDang
        {
            get { return fChucVuDang; }
            set { SetPropertyValue<ChucVuDang>("ChucVuDang", ref fChucVuDang, value); }
        }
        string fGhiChu;
        [DevExpress.Xpo.DisplayName(@"Ghi chú")]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>("GhiChu", ref fGhiChu, value); }
        }
        byte[] fHinhAnh;
        [MemberDesignTimeVisibility(true)]
        [DevExpress.Xpo.DisplayName(@"Hình ảnh")]
        public byte[] HinhAnh
        {
            get { return fHinhAnh; }
            set { SetPropertyValue<byte[]>("HinhAnh", ref fHinhAnh, value); }
        }
    }

}