namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoSucKhoe_DinhKy_Chitiet : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? HoSoSucKhoe_DinhKy_ID { get; set; }
public int? KhamBenh_Id { get; set; }
public int? NoiDungKham_ID { get; set; }
public string? KetQua { get; set; }
public string? Benh { get; set; }
public int? ICD_ID { get; set; }
public int? BacSiKetLuan_ID { get; set; }
public int? XepLoai_ID { get; set; }
public int? PhongBan_ID { get; set; }
public string? GhiChu { get; set; }

        public HoSoSucKhoe_DinhKy_Chitiet()
        {
        }
    }
}

