namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_KhamBenhService : IBaseService<NoiTru_KhamBenh>
    {
        Task<List<NoiTru_KhamBenh>> GetByListIDToListAsync(List<int?> ListID);
    }
}

