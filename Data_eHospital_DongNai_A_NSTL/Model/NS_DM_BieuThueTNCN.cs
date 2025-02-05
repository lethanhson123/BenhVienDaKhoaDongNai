namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_BieuThueTNCN : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public int? BacThue { get; set; }
public decimal? ThuNhapTinhThue { get; set; }
public decimal? TyLeThue { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public NS_DM_BieuThueTNCN()
        {
        }
    }
}

