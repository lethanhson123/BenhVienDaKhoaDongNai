namespace Service_eHospital_DongNai_A.Implement
{
    public class me_GoiSoService : BaseService<me_GoiSo, Ime_GoiSoRepository>
    , Ime_GoiSoService
    {
    private readonly Ime_GoiSoRepository _me_GoiSoRepository;
    public me_GoiSoService(Ime_GoiSoRepository me_GoiSoRepository) : base(me_GoiSoRepository)
    {
    _me_GoiSoRepository = me_GoiSoRepository;
    }
    }
    }

