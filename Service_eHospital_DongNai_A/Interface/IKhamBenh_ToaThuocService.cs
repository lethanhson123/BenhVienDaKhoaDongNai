namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenh_ToaThuocService : IBaseService<KhamBenh_ToaThuoc>
    {
        Task<KhamBenh_ToaThuoc> GetByKhamBenh_ToaThuoc_IdAsync(int KhamBenh_ToaThuoc_Id);
        Task<List<KhamBenh_ToaThuoc>> GetByNgayToaThuoc_SearchStringToListAsync(DateTime NgayToaThuoc, string SearchString);
        Task<List<KhamBenh_ToaThuoc>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
        Task<List<KhamBenh_ToaThuoc>> GetByListIDToListAsync(List<int?> ListID);
    }
}

