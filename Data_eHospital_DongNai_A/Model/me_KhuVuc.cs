namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_KhuVuc : BaseModel
    {
        [Key]
        public int? KhuVuc_id { get; set; }
public string? TenKhuVuc { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public me_KhuVuc()
        {
        }
    }
}

