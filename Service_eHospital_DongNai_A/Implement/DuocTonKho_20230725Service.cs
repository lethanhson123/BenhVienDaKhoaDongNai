namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_20230725Service : BaseService<DuocTonKho_20230725, IDuocTonKho_20230725Repository>
    , IDuocTonKho_20230725Service
    {
    private readonly IDuocTonKho_20230725Repository _DuocTonKho_20230725Repository;
    public DuocTonKho_20230725Service(IDuocTonKho_20230725Repository DuocTonKho_20230725Repository) : base(DuocTonKho_20230725Repository)
    {
    _DuocTonKho_20230725Repository = DuocTonKho_20230725Repository;
    }
    }
    }

