namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_DonViHanhChinhService : IBaseService<DM_DonViHanhChinh>
    {
        Task<List<DM_DonViHanhChinh>> GetByCapDonViToListAsync(int CapDonVi);
        Task<List<DM_DonViHanhChinh>> GetByCapDonViAndEmptyToListAsync(int CapDonVi);
        Task<List<DM_DonViHanhChinh>> GetByCapDonVi_CapTren_IdToListAsync(int CapDonVi, int CapTren_Id);
        Task<List<DM_DonViHanhChinh>> GetByCapDonVi_CapTren_IdAndEmptyToListAsync(int CapDonVi, int CapTren_Id);
    }
}

