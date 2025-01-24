namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_MaBenhNhanService : BaseService<Lst_KeyData_MaBenhNhan, ILst_KeyData_MaBenhNhanRepository>
    , ILst_KeyData_MaBenhNhanService
    {
    private readonly ILst_KeyData_MaBenhNhanRepository _Lst_KeyData_MaBenhNhanRepository;
    public Lst_KeyData_MaBenhNhanService(ILst_KeyData_MaBenhNhanRepository Lst_KeyData_MaBenhNhanRepository) : base(Lst_KeyData_MaBenhNhanRepository)
    {
    _Lst_KeyData_MaBenhNhanRepository = Lst_KeyData_MaBenhNhanRepository;
    }
    }
    }

