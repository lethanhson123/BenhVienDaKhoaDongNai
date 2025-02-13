namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_PhongBanService : IBaseService<DM_PhongBan>
    {
        Task<DM_PhongBan> GetByPhongBan_IdAsync(int PhongBan_Id);
    }
}

