namespace Service_eHospital_DongNai_A.Implement
{
    public class BCTH_018_DieuTri_NoiTru_DataService : BaseService<BCTH_018_DieuTri_NoiTru_Data, IBCTH_018_DieuTri_NoiTru_DataRepository>
    , IBCTH_018_DieuTri_NoiTru_DataService
    {
    private readonly IBCTH_018_DieuTri_NoiTru_DataRepository _BCTH_018_DieuTri_NoiTru_DataRepository;
    public BCTH_018_DieuTri_NoiTru_DataService(IBCTH_018_DieuTri_NoiTru_DataRepository BCTH_018_DieuTri_NoiTru_DataRepository) : base(BCTH_018_DieuTri_NoiTru_DataRepository)
    {
    _BCTH_018_DieuTri_NoiTru_DataRepository = BCTH_018_DieuTri_NoiTru_DataRepository;
    }
    }
    }

