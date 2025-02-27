namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_BenhNhanService : IBaseService<DM_BenhNhan>
    {
        Task<DM_BenhNhan> GetByBenhNhan_IdAsync(int BenhNhan_Id);
        Task<DM_BenhNhan> GetBySearchStringAsync(string SearchString);
        Task<List<DM_BenhNhan>> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync(int TinhThanh_Id, int QuanHuyen_Id, int XaPhuong_Id, string searchString);
        Task<List<DM_BenhNhan>> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToListAsync(int TinhThanh_Id, int QuanHuyen_Id, int XaPhuong_Id, string searchString, int Page);
        Task<int> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToCountAsync(int TinhThanh_Id, int QuanHuyen_Id, int XaPhuong_Id, string searchString);
        Task<List<DM_BenhNhan>> GetByListIDToListAsync(List<int> ListID);
    }
}

