namespace Service_eHospital_DongNai_A.Interface
{
    public interface INoiTru_TraThuocChiTietService : IBaseService<NoiTru_TraThuocChiTiet>
    {
        Task<List<NoiTru_TraThuocChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

