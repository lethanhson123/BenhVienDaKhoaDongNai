namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyDataService : BaseService<Lst_KeyData, ILst_KeyDataRepository>
    , ILst_KeyDataService
    {
    private readonly ILst_KeyDataRepository _Lst_KeyDataRepository;
    public Lst_KeyDataService(ILst_KeyDataRepository Lst_KeyDataRepository) : base(Lst_KeyDataRepository)
    {
    _Lst_KeyDataRepository = Lst_KeyDataRepository;
    }
    }
    }

