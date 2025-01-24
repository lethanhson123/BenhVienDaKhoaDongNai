namespace Service_eHospital_DongNai_A.Implement
{
    public class zz_HDDTService : BaseService<zz_HDDT, Izz_HDDTRepository>
    , Izz_HDDTService
    {
    private readonly Izz_HDDTRepository _zz_HDDTRepository;
    public zz_HDDTService(Izz_HDDTRepository zz_HDDTRepository) : base(zz_HDDTRepository)
    {
    _zz_HDDTRepository = zz_HDDTRepository;
    }
    }
    }

