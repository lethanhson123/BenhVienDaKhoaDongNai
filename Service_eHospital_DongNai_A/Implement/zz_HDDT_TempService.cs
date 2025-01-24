namespace Service_eHospital_DongNai_A.Implement
{
    public class zz_HDDT_TempService : BaseService<zz_HDDT_Temp, Izz_HDDT_TempRepository>
    , Izz_HDDT_TempService
    {
    private readonly Izz_HDDT_TempRepository _zz_HDDT_TempRepository;
    public zz_HDDT_TempService(Izz_HDDT_TempRepository zz_HDDT_TempRepository) : base(zz_HDDT_TempRepository)
    {
    _zz_HDDT_TempRepository = zz_HDDT_TempRepository;
    }
    }
    }

