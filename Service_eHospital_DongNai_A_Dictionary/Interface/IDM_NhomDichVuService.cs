namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_NhomDichVuService : IBaseService<DM_NhomDichVu>
    {
        Task<List<DM_NhomDichVu>> GetByLoaiDichVu_IdAndEmptyToListAsync(int LoaiDichVu_Id);
    }
}

