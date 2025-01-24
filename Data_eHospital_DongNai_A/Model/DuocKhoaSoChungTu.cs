namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocKhoaSoChungTu : BaseModel
    {
        [Key]
        public int? DuocKhoaSoChungTu_Id { get; set; }
public int? DuocKyTonKho_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public bool? KhoaSo { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DuocKhoaSoChungTu()
        {
        }
    }
}

