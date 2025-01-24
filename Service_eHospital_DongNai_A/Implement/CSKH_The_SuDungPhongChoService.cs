namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_SuDungPhongChoService : BaseService<CSKH_The_SuDungPhongCho, ICSKH_The_SuDungPhongChoRepository>
    , ICSKH_The_SuDungPhongChoService
    {
    private readonly ICSKH_The_SuDungPhongChoRepository _CSKH_The_SuDungPhongChoRepository;
    public CSKH_The_SuDungPhongChoService(ICSKH_The_SuDungPhongChoRepository CSKH_The_SuDungPhongChoRepository) : base(CSKH_The_SuDungPhongChoRepository)
    {
    _CSKH_The_SuDungPhongChoRepository = CSKH_The_SuDungPhongChoRepository;
    }
    }
    }

