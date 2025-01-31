namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_KhoDuocService : IBaseService<DM_KhoDuoc>
    {
        Task<List<DM_KhoDuoc>> GetByPhongBan_IdAndEmptyToListAsync(int PhongBan_Id);
    }
}

