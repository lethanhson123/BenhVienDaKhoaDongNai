﻿namespace Service_eHospital_DongNai_A_Dictionary.Model
{
    public partial class BaseParameter : BaseModel
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string? SearchString { get; set; }
        public DateTime? BatDau { get; set; }
        public DateTime? KetThuc { get; set; }
        public int? Dictionary_Type_Id { get; set; }
        public int? CapDonVi { get; set; }
        public int? CapTren_Id { get; set; }
        public int? TinhThanh_Id { get; set; }
        public int? QuanHuyen_Id { get; set; }
        public int? XaPhuong_Id { get; set; }
        public int? BenhNhan_Id { get; set; }
        public int? LoaiDichVu_Id { get; set; }
        public int? NhomDichVu_Id { get; set; }
        public int? PhongBan_Id { get; set; }
        public int? DichVu_Id { get; set; }
        public int? ICD_Nhom_Id { get; set; }
        public int? BangGia_Id { get; set; }
        public int? BangGia_CPH_Id { get; set; }
        public int? NhanVien_Id { get; set; }
        public int? User_Id { get; set; }
        public string? MaYTe { get; set; }
        public List<int> ListID { get; set; }
        public BaseParameter()
        {
        }
    }
}
