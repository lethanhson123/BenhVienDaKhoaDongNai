namespace Service.Implement
{
    public class KhamSucKhoeKetQuaService : BaseService<KhamSucKhoeKetQua, IKhamSucKhoeKetQuaRepository>
    , IKhamSucKhoeKetQuaService
    {
    private readonly IKhamSucKhoeKetQuaRepository _KhamSucKhoeKetQuaRepository;
    public KhamSucKhoeKetQuaService(IKhamSucKhoeKetQuaRepository KhamSucKhoeKetQuaRepository) : base(KhamSucKhoeKetQuaRepository)
    {
    _KhamSucKhoeKetQuaRepository = KhamSucKhoeKetQuaRepository;
    }
    }
    }

