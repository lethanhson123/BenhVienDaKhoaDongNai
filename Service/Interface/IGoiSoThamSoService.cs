namespace Service.Interface
{
    public interface IGoiSoThamSoService : IBaseService<GoiSoThamSo>
    {
        Task<List<GoiSoThamSo>> KhoiPhucAsync();
    }
}

