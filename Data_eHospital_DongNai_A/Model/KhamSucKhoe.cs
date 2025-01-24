namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamSucKhoe : BaseModel
    {
        [Key]
        public int? KhamSucKhoe_ID { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_ID { get; set; }
public string? CongTy { get; set; }
public string? KetLuan { get; set; }
public int? XepLoai_ID { get; set; }
public bool? DuSucKhoeLamViec { get; set; }
public bool? DuSucKhoeLamViecCTBien { get; set; }
public bool? DuSucKhoeLamViecGioiHan { get; set; }
public int? BacSi_ID { get; set; }
public DateTime? NgayKham { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiTao_Id { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Loai { get; set; }

        public KhamSucKhoe()
        {
        }
    }
}

