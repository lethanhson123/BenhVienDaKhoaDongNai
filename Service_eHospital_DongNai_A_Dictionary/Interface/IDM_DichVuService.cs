namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_DichVuService : IBaseService<DM_DichVu>
    {
        Task<List<DM_DichVu>> GetByNhomDichVu_IdAndEmptyToListAsync(int NhomDichVu_Id);
    }
}

