namespace Service_eHospital_DongNai_A.Implement
{
    public class me_CapSoService : BaseService<me_CapSo, Ime_CapSoRepository>
    , Ime_CapSoService
    {
    private readonly Ime_CapSoRepository _me_CapSoRepository;
    public me_CapSoService(Ime_CapSoRepository me_CapSoRepository) : base(me_CapSoRepository)
    {
    _me_CapSoRepository = me_CapSoRepository;
    }
    }
    }

