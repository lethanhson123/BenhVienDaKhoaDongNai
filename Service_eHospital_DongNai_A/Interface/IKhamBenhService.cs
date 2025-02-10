namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenhService : IBaseService<KhamBenh>
    {
        Task<KhamBenh> GetByKhamBenh_IdAsync(int KhamBenh_Id);
        Task<List<KhamBenh>> GetByNgayKham_SearchStringToListAsync(DateTime NgayKham, string SearchString);
    }
}

