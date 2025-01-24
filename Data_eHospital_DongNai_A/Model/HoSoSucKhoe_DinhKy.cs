namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoSucKhoe_DinhKy : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public int? HoSoSucKhoe_Id { get; set; }
public int? TiepNhan_ID { get; set; }
public DateTime? NgayKham { get; set; }
public string? ThiLuc { get; set; }
public string? HuyetAp { get; set; }
public string? ChieuCao { get; set; }
public string? CanNang { get; set; }
public string? VongNguc { get; set; }
public string? Pignet { get; set; }
public int? PhanLoaiTheLuc_Id { get; set; }
public string? NhanXet { get; set; }
public string? KetLuan { get; set; }
public int? XepLoai_ID { get; set; }
public int? BacSiKetLuan_ID { get; set; }
public string? Loai { get; set; }

        public HoSoSucKhoe_DinhKy()
        {
        }
    }
}

