namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_BenhNhan_NotesService : BaseService<DM_BenhNhan_Notes, IDM_BenhNhan_NotesRepository>
    , IDM_BenhNhan_NotesService
    {
    private readonly IDM_BenhNhan_NotesRepository _DM_BenhNhan_NotesRepository;
    public DM_BenhNhan_NotesService(IDM_BenhNhan_NotesRepository DM_BenhNhan_NotesRepository) : base(DM_BenhNhan_NotesRepository)
    {
    _DM_BenhNhan_NotesRepository = DM_BenhNhan_NotesRepository;
    }
    }
    }

