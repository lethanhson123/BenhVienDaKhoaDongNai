namespace Service.Implement
{
    public class ZaloZNSService : BaseService<ZaloZNS, IZaloZNSRepository>
    , IZaloZNSService
    {
        private readonly IZaloZNSRepository _ZaloZNSRepository;
        public ZaloZNSService(IZaloZNSRepository ZaloZNSRepository) : base(ZaloZNSRepository)
        {
            _ZaloZNSRepository = ZaloZNSRepository;
        }

        public override void Initialization(ZaloZNS model)
        {
            BaseInitialization(model);

            if (string.IsNullOrEmpty(model.TypeName))
            {
                model.TypeName = GlobalHelper.ZaloZNSAPIURL;
            }
        }
    }
}

