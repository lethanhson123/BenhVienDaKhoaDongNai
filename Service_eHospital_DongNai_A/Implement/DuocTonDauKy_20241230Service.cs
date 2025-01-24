namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonDauKy_20241230Service : BaseService<DuocTonDauKy_20241230, IDuocTonDauKy_20241230Repository>
    , IDuocTonDauKy_20241230Service
    {
    private readonly IDuocTonDauKy_20241230Repository _DuocTonDauKy_20241230Repository;
    public DuocTonDauKy_20241230Service(IDuocTonDauKy_20241230Repository DuocTonDauKy_20241230Repository) : base(DuocTonDauKy_20241230Repository)
    {
    _DuocTonDauKy_20241230Repository = DuocTonDauKy_20241230Repository;
    }
    }
    }

