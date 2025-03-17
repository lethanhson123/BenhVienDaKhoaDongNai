namespace Service.Implement
{
    public class DanhMucQRCodeService : BaseService<DanhMucQRCode, IDanhMucQRCodeRepository>
    , IDanhMucQRCodeService
    {
        private readonly IDanhMucQRCodeRepository _DanhMucQRCodeRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucQRCodeService(IDanhMucQRCodeRepository DanhMucQRCodeRepository

        , IWebHostEnvironment webHostEnvironment

        ) : base(DanhMucQRCodeRepository)
        {
            _DanhMucQRCodeRepository = DanhMucQRCodeRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override void Initialization(DanhMucQRCode model)
        {
            BaseInitialization(model);
            if (model.Code == null)
            {
                model.Code = GlobalHelper.InitializationGUICode;
            }
            if (model.Display == null)
            {
                model.Display = GlobalHelper.APISite + "/api/v1/" + model.GetType().Name + "/GetAllowAnonymousByCodeAsync?Code=" + model.Code;
            }
            string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
            bool isFolderExists = System.IO.Directory.Exists(folderPath);
            if (!isFolderExists)
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }          

            QRCodeModel QRCodeModel = QRCodeHelper.CreateQRCodeURL(model.Code, model.Display, folderPath);

            model.FileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + QRCodeModel.FileName;
        }
        public virtual async Task<List<DanhMucQRCode>> GetByNumberToListAsync(int Number)
        {
            List<DanhMucQRCode> result = new List<DanhMucQRCode>();
            for (int i = 0; i < Number; i++)
            {
                DanhMucQRCode DanhMucQRCode = new DanhMucQRCode();
                result.Add(await SaveAsync(DanhMucQRCode));
            }
            return result;
        }
    }
}

