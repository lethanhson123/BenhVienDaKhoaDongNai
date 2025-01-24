namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoiChan_BenhLy : BaseModel
    {
        [Key]
        public int? HoiChan_BenhLy_Id { get; set; }
public int? LoaiBenhLy { get; set; }
public int? HoiChan_Id { get; set; }
public int? BenhLy_Id { get; set; }
public string? GhiChu { get; set; }

        public HoiChan_BenhLy()
        {
        }
    }
}

