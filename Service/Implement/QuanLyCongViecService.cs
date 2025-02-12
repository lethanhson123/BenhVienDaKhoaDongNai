namespace Service.Implement
{
    public class QuanLyCongViecService : BaseService<QuanLyCongViec, IQuanLyCongViecRepository>
    , IQuanLyCongViecService
    {
        private readonly IQuanLyCongViecRepository _QuanLyCongViecRepository;

        public QuanLyCongViecService(IQuanLyCongViecRepository QuanLyCongViecRepository



            ) : base(QuanLyCongViecRepository)
        {
            _QuanLyCongViecRepository = QuanLyCongViecRepository;

        }
        public override void Initialization(QuanLyCongViec model)
        {
            BaseInitialization(model);            
            if (string.IsNullOrEmpty(model.Code))
            {
                DateTime Now = GlobalHelper.InitializationDateTime;
                List<QuanLyCongViec> List = _QuanLyCongViecRepository.GetByCondition(item=> item.NgayGhiNhan.Value.Year== Now.Year && item.NgayGhiNhan.Value.Month == Now.Month).ToList();
                string Year = Now.Year.ToString().Substring(2, 2);
                string Month = Now.Month.ToString();
                if (Now.Month < 10)
                {
                    Month = "0" + Month;
                }

                string Count = (List.Count + 1).ToString();
                if (Now.Month < 100)
                {
                    Count = "0" + Count;
                    if (Now.Month < 10)
                    {
                        Count = "0" + Count;
                    }
                }
                model.Code = Year + Month + "X" + Count;
            }
        }
    }
}

