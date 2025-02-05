namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class zzzNhanVien_2023_05_23Service : BaseService<zzzNhanVien_2023_05_23, IzzzNhanVien_2023_05_23Repository>
    , IzzzNhanVien_2023_05_23Service
    {
    private readonly IzzzNhanVien_2023_05_23Repository _zzzNhanVien_2023_05_23Repository;
    public zzzNhanVien_2023_05_23Service(IzzzNhanVien_2023_05_23Repository zzzNhanVien_2023_05_23Repository) : base(zzzNhanVien_2023_05_23Repository)
    {
    _zzzNhanVien_2023_05_23Repository = zzzNhanVien_2023_05_23Repository;
    }
    }
    }

