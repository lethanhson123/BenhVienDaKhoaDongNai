namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQuaMau_ChiTiet : BaseModel
    {
        [Key]
        public int? KetQuaMau_ChiTiet_Id { get; set; }
public int? CLSKetQua_Id { get; set; }
public int? PTMau_ChiTiet_Id { get; set; }
public string? KetQua1 { get; set; }
public string? KetQua2 { get; set; }
public string? KetQua3 { get; set; }
public string? KetQua4 { get; set; }
public string? KetQua5 { get; set; }
public string? KetQua6 { get; set; }
public int? DichVu_Id { get; set; }

        public CLSKetQuaMau_ChiTiet()
        {
        }
    }
}

