namespace Service.Implement
{
    public class ThanhVienTokenService : BaseService<ThanhVienToken, IThanhVienTokenRepository>
    , IThanhVienTokenService
    {
        private readonly IThanhVienTokenRepository _ThanhVienTokenRepository;
        public ThanhVienTokenService(IThanhVienTokenRepository ThanhVienTokenRepository) : base(ThanhVienTokenRepository)
        {
            _ThanhVienTokenRepository = ThanhVienTokenRepository;
        }
        public async Task<ThanhVienToken> AuthenticationByTokenAsync(string Token)
        {
            ThanhVienToken result = new ThanhVienToken();
            if (!string.IsNullOrEmpty(Token))
            {
                result = await _ThanhVienTokenRepository.GetByCondition(item => item.Token == Token && item.Active == true).FirstOrDefaultAsync();               
            }
            return result;
        }
    }
}

