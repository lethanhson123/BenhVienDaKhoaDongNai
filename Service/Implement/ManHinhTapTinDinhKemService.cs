
namespace Service.Implement
{
    public class ManHinhTapTinDinhKemService : BaseService<ManHinhTapTinDinhKem, IManHinhTapTinDinhKemRepository>
    , IManHinhTapTinDinhKemService
    {
        private readonly IManHinhTapTinDinhKemRepository _ManHinhTapTinDinhKemRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ManHinhTapTinDinhKemService(IManHinhTapTinDinhKemRepository ManHinhTapTinDinhKemRepository

            , IWebHostEnvironment WebHostEnvironment

            ) : base(ManHinhTapTinDinhKemRepository)
        {
            _ManHinhTapTinDinhKemRepository = ManHinhTapTinDinhKemRepository;

            _WebHostEnvironment = WebHostEnvironment;
        }
        public override void Initialization(ManHinhTapTinDinhKem model)
        {
            BaseInitialization(model);
            if (model.IsHinhAnh == null)
            {
                model.IsHinhAnh = false;
            }
            switch (model.TypeName)
            {
                case "png":
                case "jpg":
                case "jpeg":
                    model.IsHinhAnh = true;
                    break;
            }
        }
        public override async Task<ManHinhTapTinDinhKem> SaveAsync(ManHinhTapTinDinhKem model)
        {
            int result = GlobalHelper.InitializationNumber;
            if (model.ID > 0)
            {
                result = await UpdateAsync(model);
            }
            else
            {
                result = await AddAsync(model);
            }
            if (result > 0)
            {
                await Sync(model);
            }
            return model;
        }
        public virtual async Task<ManHinhTapTinDinhKem> Sync(ManHinhTapTinDinhKem model)
        {
            if (model.ID > 0)
            {
                List<ManHinhTapTinDinhKem> ListManHinhTapTinDinhKem = await GetByActiveToListAsync(true);
                List<ManHinhTapTinDinhKemTranfer> ListManHinhTapTinDinhKemTranfer = new List<ManHinhTapTinDinhKemTranfer>();
                foreach (ManHinhTapTinDinhKem ManHinhTapTinDinhKem in ListManHinhTapTinDinhKem)
                {
                    ManHinhTapTinDinhKemTranfer ManHinhTapTinDinhKemTranfer = new ManHinhTapTinDinhKemTranfer();
                    ManHinhTapTinDinhKemTranfer.LastUpdatedDate = ManHinhTapTinDinhKem.LastUpdatedDate;
                    ManHinhTapTinDinhKemTranfer.SortOrder = ManHinhTapTinDinhKem.SortOrder;
                    ManHinhTapTinDinhKemTranfer.FileName = ManHinhTapTinDinhKem.FileName;
                    ManHinhTapTinDinhKemTranfer.TongSoGiay = ManHinhTapTinDinhKem.TongSoGiay;
                    ManHinhTapTinDinhKemTranfer.Note = GlobalHelper.InitializationDateTimeCode;
                    ManHinhTapTinDinhKemTranfer.IsChanged = false;
                    if (ManHinhTapTinDinhKem.ID == model.ID)
                    {
                        ManHinhTapTinDinhKemTranfer.IsChanged = true;
                    }
                    ListManHinhTapTinDinhKemTranfer.Add(ManHinhTapTinDinhKemTranfer);
                }
                string contentHTML = JsonConvert.SerializeObject(ListManHinhTapTinDinhKemTranfer);
                string physicalPathCreate = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                bool isFolderExists = System.IO.Directory.Exists(physicalPathCreate);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(physicalPathCreate);
                }
                string fileName = model.GetType().Name + ".json";
                physicalPathCreate = Path.Combine(physicalPathCreate, fileName);
                using (FileStream fs = new FileStream(physicalPathCreate, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(contentHTML);
                    }
                }
            }
            return model;
        }
    }
}

