namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_DichVuService : BaseService<Lst_KeyData_DichVu, ILst_KeyData_DichVuRepository>
    , ILst_KeyData_DichVuService
    {
    private readonly ILst_KeyData_DichVuRepository _Lst_KeyData_DichVuRepository;
    public Lst_KeyData_DichVuService(ILst_KeyData_DichVuRepository Lst_KeyData_DichVuRepository) : base(Lst_KeyData_DichVuRepository)
    {
    _Lst_KeyData_DichVuRepository = Lst_KeyData_DichVuRepository;
    }
    }
    }

