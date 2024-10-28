namespace Data.Model
{
    public partial class CongViec : BaseModel
    {
        public long? DanhMucPhongBanYeuCauID { get; set; }
        public string? DanhMucPhongBanYeuCauName { get; set; }
        public long? DanhMucPhongBanGiaiQuyetID { get; set; }
        public string? DanhMucPhongBanGiaiQuyetName { get; set; }
        public long? ThanhVienYeuCauID { get; set; }
        public string? ThanhVienYeuCauName { get; set; }
        public string? ThanhVienYeuCauDienThoai { get; set; }
        public string? ThanhVienYeuCauEmail { get; set; }
        public long? ThanhVienGiaiQuyetID { get; set; }
        public string? ThanhVienGiaiQuyetName { get; set; }
        public string? ThanhVienGiaiQuyetDienThoai { get; set; }
        public string? ThanhVienGiaiQuyetEmail { get; set; }
        public long? DanhMucTinhTrangID { get; set; }
        public string? DanhMucTinhTrangName { get; set; }
        public DateTime? NgayYeuCau { get; set; }
        public DateTime? NgayGiaiQuyet { get; set; }
        public DateTime? NgayHoanThanh { get; set; }

        public CongViec()
        {
            NgayYeuCau = GlobalHelper.InitializationDateTime;
        }
    }
}

