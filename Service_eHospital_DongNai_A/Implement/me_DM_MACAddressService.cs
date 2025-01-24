namespace Service_eHospital_DongNai_A.Implement
{
    public class me_DM_MACAddressService : BaseService<me_DM_MACAddress, Ime_DM_MACAddressRepository>
    , Ime_DM_MACAddressService
    {
    private readonly Ime_DM_MACAddressRepository _me_DM_MACAddressRepository;
    public me_DM_MACAddressService(Ime_DM_MACAddressRepository me_DM_MACAddressRepository) : base(me_DM_MACAddressRepository)
    {
    _me_DM_MACAddressRepository = me_DM_MACAddressRepository;
    }
    }
    }

