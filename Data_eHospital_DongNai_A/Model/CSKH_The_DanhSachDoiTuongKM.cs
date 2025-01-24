namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_DanhSachDoiTuongKM : BaseModel
    {
        [Key]
        public int? The_DSDoiTuongKM_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public int? DacTinh_Id { get; set; }
public int? QuiDinh_Id { get; set; }
public int? DoiTuong_Id { get; set; }

        public CSKH_The_DanhSachDoiTuongKM()
        {
        }
    }
}

