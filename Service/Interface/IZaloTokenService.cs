namespace Service.Interface
{
    public interface IZaloTokenService : IBaseService<ZaloToken>
    {
        Task<ZaloToken> GetLatestAsync();
    }
}

