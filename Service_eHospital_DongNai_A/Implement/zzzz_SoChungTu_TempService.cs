namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzz_SoChungTu_TempService : BaseService<zzzz_SoChungTu_Temp, Izzzz_SoChungTu_TempRepository>
    , Izzzz_SoChungTu_TempService
    {
    private readonly Izzzz_SoChungTu_TempRepository _zzzz_SoChungTu_TempRepository;
    public zzzz_SoChungTu_TempService(Izzzz_SoChungTu_TempRepository zzzz_SoChungTu_TempRepository) : base(zzzz_SoChungTu_TempRepository)
    {
    _zzzz_SoChungTu_TempRepository = zzzz_SoChungTu_TempRepository;
    }
    }
    }

