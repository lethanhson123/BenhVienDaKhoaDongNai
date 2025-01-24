namespace Service_eHospital_DongNai_A.Implement
{
    public class cus_HDDTService : BaseService<cus_HDDT, Icus_HDDTRepository>
    , Icus_HDDTService
    {
    private readonly Icus_HDDTRepository _cus_HDDTRepository;
    public cus_HDDTService(Icus_HDDTRepository cus_HDDTRepository) : base(cus_HDDTRepository)
    {
    _cus_HDDTRepository = cus_HDDTRepository;
    }
    }
    }

