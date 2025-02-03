namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_DichVu_DonGia_CPHService : IBaseService<DM_DichVu_DonGia_CPH>
    {
        Task<List<DM_DichVu_DonGia_CPH>> GetByBangGia_CPH_IdToListAsync(int BangGia_CPH_Id);
        Task<List<DM_DichVu_DonGia_CPH>> GetByBangGia_CPH_IdAndEmptyToListAsync(int BangGia_CPH_Id);
    }
}

