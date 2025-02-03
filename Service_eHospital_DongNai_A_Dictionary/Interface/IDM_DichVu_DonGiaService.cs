namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_DichVu_DonGiaService : IBaseService<DM_DichVu_DonGia>
    {        
        Task<List<DM_DichVu_DonGia>> GetByBangGia_IdToListAsync(int BangGia_Id);
        Task<List<DM_DichVu_DonGia>> GetByBangGia_IdAndEmptyToListAsync(int BangGia_Id);
    }
}

