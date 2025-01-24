namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamSucKhoeService : BaseService<KhamSucKhoe, IKhamSucKhoeRepository>
    , IKhamSucKhoeService
    {
    private readonly IKhamSucKhoeRepository _KhamSucKhoeRepository;
    public KhamSucKhoeService(IKhamSucKhoeRepository KhamSucKhoeRepository) : base(KhamSucKhoeRepository)
    {
    _KhamSucKhoeRepository = KhamSucKhoeRepository;
    }
    }
    }

