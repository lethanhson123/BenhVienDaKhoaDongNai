namespace Service.Interface
{
    public interface IDuAnService : IBaseService<DuAn>
    {
        Task<List<DuAn>> GetBySearchString_BatDau_KetThucToListAsync(string SearchString, DateTime BatDau, DateTime KetThuc);
    }
}

