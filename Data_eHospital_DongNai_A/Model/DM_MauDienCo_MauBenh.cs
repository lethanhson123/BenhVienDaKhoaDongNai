namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_MauDienCo_MauBenh : BaseModel
    {
        [Key]
        public int? MauDienCo_MauBenh_Id { get; set; }
public int? MauDienCo_Id { get; set; }
public int? MauBenh_Id { get; set; }

        public DM_MauDienCo_MauBenh()
        {
        }
    }
}

