namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_TyLeApTranService : BaseService<zzz_TyLeApTran, Izzz_TyLeApTranRepository>
    , Izzz_TyLeApTranService
    {
    private readonly Izzz_TyLeApTranRepository _zzz_TyLeApTranRepository;
    public zzz_TyLeApTranService(Izzz_TyLeApTranRepository zzz_TyLeApTranRepository) : base(zzz_TyLeApTranRepository)
    {
    _zzz_TyLeApTranRepository = zzz_TyLeApTranRepository;
    }
    }
    }

