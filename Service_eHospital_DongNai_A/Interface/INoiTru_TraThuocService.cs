namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_TraThuocService : IBaseService<NoiTru_TraThuoc>
    {
        Task<List<NoiTru_TraThuoc>> GetByListIDToListAsync(List<int?> ListID);
    }
}

