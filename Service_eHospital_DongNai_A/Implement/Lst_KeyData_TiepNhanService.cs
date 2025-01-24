namespace Service_eHospital_DongNai_A.Implement
{
    public class Lst_KeyData_TiepNhanService : BaseService<Lst_KeyData_TiepNhan, ILst_KeyData_TiepNhanRepository>
    , ILst_KeyData_TiepNhanService
    {
    private readonly ILst_KeyData_TiepNhanRepository _Lst_KeyData_TiepNhanRepository;
    public Lst_KeyData_TiepNhanService(ILst_KeyData_TiepNhanRepository Lst_KeyData_TiepNhanRepository) : base(Lst_KeyData_TiepNhanRepository)
    {
    _Lst_KeyData_TiepNhanRepository = Lst_KeyData_TiepNhanRepository;
    }
    }
    }

