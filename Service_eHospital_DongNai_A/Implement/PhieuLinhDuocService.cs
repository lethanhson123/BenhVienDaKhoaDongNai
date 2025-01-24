namespace Service_eHospital_DongNai_A.Implement
{
    public class PhieuLinhDuocService : BaseService<PhieuLinhDuoc, IPhieuLinhDuocRepository>
    , IPhieuLinhDuocService
    {
    private readonly IPhieuLinhDuocRepository _PhieuLinhDuocRepository;
    public PhieuLinhDuocService(IPhieuLinhDuocRepository PhieuLinhDuocRepository) : base(PhieuLinhDuocRepository)
    {
    _PhieuLinhDuocRepository = PhieuLinhDuocRepository;
    }
    }
    }

