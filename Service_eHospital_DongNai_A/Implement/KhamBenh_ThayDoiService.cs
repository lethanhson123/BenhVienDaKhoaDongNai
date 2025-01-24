namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ThayDoiService : BaseService<KhamBenh_ThayDoi, IKhamBenh_ThayDoiRepository>
    , IKhamBenh_ThayDoiService
    {
    private readonly IKhamBenh_ThayDoiRepository _KhamBenh_ThayDoiRepository;
    public KhamBenh_ThayDoiService(IKhamBenh_ThayDoiRepository KhamBenh_ThayDoiRepository) : base(KhamBenh_ThayDoiRepository)
    {
    _KhamBenh_ThayDoiRepository = KhamBenh_ThayDoiRepository;
    }
    }
    }

