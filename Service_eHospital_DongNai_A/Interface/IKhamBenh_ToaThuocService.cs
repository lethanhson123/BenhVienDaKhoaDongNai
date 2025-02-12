namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenh_ToaThuocService : IBaseService<KhamBenh_ToaThuoc>
    {
        Task<KhamBenh_ToaThuoc> GetByKhamBenh_ToaThuoc_IdAsync(int KhamBenh_ToaThuoc_Id);
        Task<List<KhamBenh_ToaThuoc>> GetByNgayToaThuoc_SearchStringToListAsync(DateTime NgayToaThuoc, string SearchString);
    }
    }

