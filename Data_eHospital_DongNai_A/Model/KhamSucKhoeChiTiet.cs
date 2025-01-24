namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamSucKhoeChiTiet : BaseModel
    {
        [Key]
        public int? KhamSucKhoeChiTiet_Id { get; set; }
public int? KhamSucKhoe_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? NoiDung_Id { get; set; }
public int? ICD_Id { get; set; }
public string? Benh { get; set; }
public string? KetQua { get; set; }
public string? GhiChu { get; set; }
public int? PhongBan_Id { get; set; }
public int? BacSi_Id { get; set; }

        public KhamSucKhoeChiTiet()
        {
        }
    }
}

