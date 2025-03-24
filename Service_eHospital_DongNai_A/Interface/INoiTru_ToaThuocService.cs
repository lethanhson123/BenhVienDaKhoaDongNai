namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_ToaThuocService : IBaseService<NoiTru_ToaThuoc>
    {
        Task<List<NoiTru_ToaThuoc>> GetByListIDToListAsync(List<int?> ListID);
    }
}

