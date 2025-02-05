namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_PhuCap : BaseModel
    {
        [Key]
        public int? NS_DM_PhuCap_Id { get; set; }
public string? MaPhongBan { get; set; }
public string? PC_DacThuNgheNghiep { get; set; }
public string? PC_DocHaiHienVat { get; set; }

        public NS_DM_PhuCap()
        {
        }
    }
}

