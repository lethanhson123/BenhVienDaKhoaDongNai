namespace Service_eHospital_DongNai_A.Implement
{
    public class NhanVien_TTDT_1Service : BaseService<NhanVien_TTDT_1, INhanVien_TTDT_1Repository>
    , INhanVien_TTDT_1Service
    {
    private readonly INhanVien_TTDT_1Repository _NhanVien_TTDT_1Repository;
    public NhanVien_TTDT_1Service(INhanVien_TTDT_1Repository NhanVien_TTDT_1Repository) : base(NhanVien_TTDT_1Repository)
    {
    _NhanVien_TTDT_1Repository = NhanVien_TTDT_1Repository;
    }
    }
    }

