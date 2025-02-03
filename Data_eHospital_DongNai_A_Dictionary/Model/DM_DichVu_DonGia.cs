namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_DichVu_DonGia : BaseModel
    {
        [Key]
        public int? DichVu_DonGia_Id { get; set; }
        public int? BangGia_Id { get; set; }
        public int? DichVu_Id { get; set; }
        public int? LoaiGia_Id { get; set; }
        public string? TienTe_Id { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? DonGiaThapNhat { get; set; }
        public decimal? DonGiaCaoNhat { get; set; }
        public decimal? TyLeVAT { get; set; }
        public decimal? GiaTriVAT { get; set; }
        public string? TrangThai { get; set; }
        public bool? TamNgung { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiTao_Id { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int? NguoiCapNhat_Id { get; set; }

        public DM_DichVu_DonGia()
        {
            DichVu_DonGia_Id = GlobalHelper.InitializationNumber;
        }
    }
}

