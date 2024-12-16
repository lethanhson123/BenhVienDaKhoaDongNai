namespace Service.Implement
{
    public class GoiSoThamSoService : BaseService<GoiSoThamSo, IGoiSoThamSoRepository>
    , IGoiSoThamSoService
    {
        private readonly IGoiSoThamSoRepository _GoiSoThamSoRepository;
        public GoiSoThamSoService(IGoiSoThamSoRepository GoiSoThamSoRepository) : base(GoiSoThamSoRepository)
        {
            _GoiSoThamSoRepository = GoiSoThamSoRepository;
        }
    }
}

