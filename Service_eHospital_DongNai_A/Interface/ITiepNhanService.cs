namespace Service_eHospital_DongNai_A.Interface
{
    public interface ITiepNhanService : IBaseService<TiepNhan>
    {
        Task<TiepNhan> GetByTiepNhan_IdAsync(int TiepNhan_Id);
        Task<List<TiepNhan>> GetByNgayTiepNhan_SearchStringToListAsync(DateTime NgayTiepNhan, string SearchString);
    }
}

