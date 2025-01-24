namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzNhanVien_1Service : BaseService<zzzNhanVien_1, IzzzNhanVien_1Repository>
    , IzzzNhanVien_1Service
    {
    private readonly IzzzNhanVien_1Repository _zzzNhanVien_1Repository;
    public zzzNhanVien_1Service(IzzzNhanVien_1Repository zzzNhanVien_1Repository) : base(zzzNhanVien_1Repository)
    {
    _zzzNhanVien_1Repository = zzzNhanVien_1Repository;
    }
    }
    }

