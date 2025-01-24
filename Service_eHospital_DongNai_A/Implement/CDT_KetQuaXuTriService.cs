namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KetQuaXuTriService : BaseService<CDT_KetQuaXuTri, ICDT_KetQuaXuTriRepository>
    , ICDT_KetQuaXuTriService
    {
    private readonly ICDT_KetQuaXuTriRepository _CDT_KetQuaXuTriRepository;
    public CDT_KetQuaXuTriService(ICDT_KetQuaXuTriRepository CDT_KetQuaXuTriRepository) : base(CDT_KetQuaXuTriRepository)
    {
    _CDT_KetQuaXuTriRepository = CDT_KetQuaXuTriRepository;
    }
    }
    }

