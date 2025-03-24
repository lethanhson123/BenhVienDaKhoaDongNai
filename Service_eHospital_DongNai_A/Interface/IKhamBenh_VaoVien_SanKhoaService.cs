namespace Service_eHospital_DongNai_A.Interface
{
    public interface IKhamBenh_VaoVien_SanKhoaService : IBaseService<KhamBenh_VaoVien_SanKhoa>
    {
        Task<List<KhamBenh_VaoVien_SanKhoa>> GetByListIDToListAsync(List<int?> ListID);
    }
}

