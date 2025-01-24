namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_SoKhamBenhService : BaseService<ztmp_SoKhamBenh, Iztmp_SoKhamBenhRepository>
    , Iztmp_SoKhamBenhService
    {
    private readonly Iztmp_SoKhamBenhRepository _ztmp_SoKhamBenhRepository;
    public ztmp_SoKhamBenhService(Iztmp_SoKhamBenhRepository ztmp_SoKhamBenhRepository) : base(ztmp_SoKhamBenhRepository)
    {
    _ztmp_SoKhamBenhRepository = ztmp_SoKhamBenhRepository;
    }
    }
    }

