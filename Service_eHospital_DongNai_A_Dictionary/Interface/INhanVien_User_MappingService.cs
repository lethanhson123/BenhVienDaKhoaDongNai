namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface INhanVien_User_MappingService : IBaseService<NhanVien_User_Mapping>
    {
        Task<List<NhanVien_User_Mapping>> GetByNhanVien_IdToListAsync(int NhanVien_Id);
        Task<List<NhanVien_User_Mapping>> GetByNhanVien_IdAndEmptyToListAsync(int NhanVien_Id);
        Task<List<NhanVien_User_Mapping>> GetByUser_IdToListAsync(int User_Id);
        Task<List<NhanVien_User_Mapping>> GetByUser_IdAndEmptyToListAsync(int User_Id);
    }
}

