namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_KINHNGHIEMCHUYENMON : BaseModel
    {
        [Key]
        public int? id { get; set; }
public string? MaUngVien { get; set; }
public string? Tenchuyenmon { get; set; }
public string? Trinhdo { get; set; }

        public NS_KINHNGHIEMCHUYENMON()
        {
        }
    }
}

