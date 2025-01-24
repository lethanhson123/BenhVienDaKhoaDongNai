namespace Service_eHospital_DongNai_A.Implement
{
    public class me_KhuVucService : BaseService<me_KhuVuc, Ime_KhuVucRepository>
    , Ime_KhuVucService
    {
    private readonly Ime_KhuVucRepository _me_KhuVucRepository;
    public me_KhuVucService(Ime_KhuVucRepository me_KhuVucRepository) : base(me_KhuVucRepository)
    {
    _me_KhuVucRepository = me_KhuVucRepository;
    }
    }
    }

