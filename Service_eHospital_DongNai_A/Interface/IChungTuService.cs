namespace Service_eHospital_DongNai_A.Interface
{
    public interface IChungTuService : IBaseService<ChungTu>
    {
        Task<ChungTu> GetByChungTu_IdAsync(int ChungTu_Id);
        Task<List<ChungTu>> GetByNgayChungTu_SearchStringToListAsync(DateTime NgayChungTu, string SearchString);
    }
}

