namespace Service.Interface
{
    public interface IDuAnService : IBaseService<DuAn>
    {
        Task<DuAn> CreateHTMLByIDAsync(long ID, long ThanhVienID);
        Task<List<DuAn>> GetBySearchString_BatDau_KetThucToListAsync(string SearchString, DateTime BatDau, DateTime KetThuc);
        Task<List<DuAn>> GetSQLByThanhVienIDAndBatDau_KetThuc_SearchStringToListAsync(long ThanhVienID, DateTime BatDau, DateTime KetThuc, string SearchString);
    }
}

