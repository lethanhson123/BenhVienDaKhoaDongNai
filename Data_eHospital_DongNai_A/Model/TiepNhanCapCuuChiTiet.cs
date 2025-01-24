namespace Data_eHospital_DongNai_A.Model
{
    public partial class TiepNhanCapCuuChiTiet : BaseModel
    {
        [Key]
        public int? TiepNhanCapCuuChiTiet_ID { get; set; }
public int? TiepNhanCapCuu_ID { get; set; }
public int? Loai_ID { get; set; }
public string? KetQua { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public TiepNhanCapCuuChiTiet()
        {
        }
    }
}

