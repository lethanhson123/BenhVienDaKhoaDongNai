﻿namespace Data.Model
{
    public partial class DuAnQuyetDinh : BaseModel
    {
        public DateTime? NgayKy { get; set; }
        public string? SoHoSo { get; set; }
        public string? SoQuyetDinh { get; set; }
        public long? BenDauTuID { get; set; }
        public string? BenDauTuName { get; set; }
        public string? BenDauTuMaSoThue { get; set; }
        public string? BenDauTuDienThoai { get; set; }
        public string? BenDauTuDiaChi { get; set; }
        public string? BenDauTuEmail { get; set; }
        public long? BenDauTuTaiKhoanID { get; set; }
        public string? BenDauTuSoTaiKhoan { get; set; }
        public string? BenDauTuNganHang { get; set; }
        public decimal? GhiCo { get; set; }
        public decimal? GhiNo { get; set; }
        public decimal? ConLai { get; set; }
        public decimal? MucDauTu { get; set; }

        public DuAnQuyetDinh()
        {
        }
    }
}
