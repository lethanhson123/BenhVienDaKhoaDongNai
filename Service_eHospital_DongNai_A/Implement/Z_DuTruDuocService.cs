namespace Service_eHospital_DongNai_A.Implement
{
    public class Z_DuTruDuocService : BaseService<Z_DuTruDuoc, IZ_DuTruDuocRepository>
    , IZ_DuTruDuocService
    {
    private readonly IZ_DuTruDuocRepository _Z_DuTruDuocRepository;
    public Z_DuTruDuocService(IZ_DuTruDuocRepository Z_DuTruDuocRepository) : base(Z_DuTruDuocRepository)
    {
    _Z_DuTruDuocRepository = Z_DuTruDuocRepository;
    }
    }
    }

