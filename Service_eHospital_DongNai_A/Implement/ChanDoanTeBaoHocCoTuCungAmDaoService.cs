namespace Service_eHospital_DongNai_A.Implement
{
    public class ChanDoanTeBaoHocCoTuCungAmDaoService : BaseService<ChanDoanTeBaoHocCoTuCungAmDao, IChanDoanTeBaoHocCoTuCungAmDaoRepository>
    , IChanDoanTeBaoHocCoTuCungAmDaoService
    {
    private readonly IChanDoanTeBaoHocCoTuCungAmDaoRepository _ChanDoanTeBaoHocCoTuCungAmDaoRepository;
    public ChanDoanTeBaoHocCoTuCungAmDaoService(IChanDoanTeBaoHocCoTuCungAmDaoRepository ChanDoanTeBaoHocCoTuCungAmDaoRepository) : base(ChanDoanTeBaoHocCoTuCungAmDaoRepository)
    {
    _ChanDoanTeBaoHocCoTuCungAmDaoRepository = ChanDoanTeBaoHocCoTuCungAmDaoRepository;
    }
    }
    }

