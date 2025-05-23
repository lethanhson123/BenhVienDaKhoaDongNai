﻿namespace Data_eHospital_DongNai_A.Model
{
    public partial class TiepNhan_DoiTuongThayDoi : BaseModel
    {
        [Key]
        public int? TiepNhan_DoiTuongThayDoi_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? DoiTuong_Id { get; set; }
public int? DoiTuong_ChiTiet_Id { get; set; }
public string? SoBHYT { get; set; }
public DateTime? BHYTTuNgay { get; set; }
public DateTime? BHYTDenNgay { get; set; }
public int? BenhVien_KCB_Id { get; set; }
public int? TuyenKhamBenh_Id { get; set; }
public DateTime? NgayThayDoi { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public bool? H_KhongCungChiTra { get; set; }
public bool? IsSuDung { get; set; }
public DateTime? HieuLucTuNgay { get; set; }
public DateTime? HieuLucDenNgay { get; set; }
public DateTime? NgayHuong5Nam { get; set; }

        public TiepNhan_DoiTuongThayDoi()
        {
        }
    }
}

