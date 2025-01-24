namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_ImagesService : BaseService<BenhAnPhauThuat_Images, IBenhAnPhauThuat_ImagesRepository>
    , IBenhAnPhauThuat_ImagesService
    {
    private readonly IBenhAnPhauThuat_ImagesRepository _BenhAnPhauThuat_ImagesRepository;
    public BenhAnPhauThuat_ImagesService(IBenhAnPhauThuat_ImagesRepository BenhAnPhauThuat_ImagesRepository) : base(BenhAnPhauThuat_ImagesRepository)
    {
    _BenhAnPhauThuat_ImagesRepository = BenhAnPhauThuat_ImagesRepository;
    }
    }
    }

