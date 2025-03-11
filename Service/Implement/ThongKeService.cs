namespace Service.Implement
{
    public class ThongKeService : BaseService<ThongKe, IThongKeRepository>
    , IThongKeService
    {
        private readonly IThongKeRepository _ThongKeRepository;
        private readonly IThongKeChiTietRepository _ThongKeChiTietRepository;
        private readonly IDanhMucThongKeRepository _DanhMucThongKeRepository;
        public ThongKeService(IThongKeRepository ThongKeRepository, IThongKeChiTietRepository thongKeChiTietRepository, IDanhMucThongKeRepository danhMucThongKeRepository) : base(ThongKeRepository)
        {
            _ThongKeRepository = ThongKeRepository;
            _ThongKeChiTietRepository = thongKeChiTietRepository;
            _DanhMucThongKeRepository = danhMucThongKeRepository;
        }
        public override void Initialization(ThongKe model)
        {
            BaseInitialization(model);
            if (model.ParentID == null)
            {
                model.ParentID = 1;
            }
            if (model.ParentID > 0)
            {
                DanhMucThongKe DanhMucThongKe = _DanhMucThongKeRepository.GetByID(model.ParentID.Value);
                if (DanhMucThongKe != null)
                {
                    model.ParentName = DanhMucThongKe.Note;
                }
            }
            if (model.BatDau == null)
            {
                model.BatDau = GlobalHelper.InitializationDateTime;
            }
            if (model.KetThuc == null)
            {
                model.KetThuc = model.BatDau.Value.AddDays(6);
            }
            model.Year = model.BatDau.Value.Year;
            model.Month = model.BatDau.Value.Month;
            model.Day = model.BatDau.Value.Day;
            model.Week = System.Globalization.ISOWeek.GetWeekOfYear(model.BatDau.Value);
            if (string.IsNullOrEmpty(model.Name))
            {
                switch (model.ParentID)
                {
                    case 1:
                        model.Name = model.ParentName + " TUẦN " + model.Week + " THÁNG " + model.Month + " NĂM " + model.Year + " (" + model.BatDau.Value.ToString("dd/MM/yyyy") + " - " + model.KetThuc.Value.ToString("dd/MM/yyyy") + ")";
                        break;
                }
            }
            if (string.IsNullOrEmpty(model.Note))
            {
                model.Note = model.Name;
            }
        }
        public override async Task<ThongKe> SaveAsync(ThongKe model)
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
                model = await Sync(model);
            }
            return model;
        }
        public virtual async Task<ThongKe> Sync(ThongKe model)
        {
            if (model.ID > 0)
            {
                if (model.Active == false)
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@ParentID", model.ID),
                        new SqlParameter("@BatDau", model.BatDau.Value),
                        new SqlParameter("@KetThuc", model.KetThuc.Value),
                    };
                    List<ThongKeChiTiet> ListThongKeChiTiet = await _ThongKeChiTietRepository.GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A, "sp_ReportA0002", parameters);
                    if (ListThongKeChiTiet.Count > 0)
                    {
                        List<ThongKeChiTiet> ListThongKeChiTietExisted = await _ThongKeChiTietRepository.GetByParentIDToListAsync(model.ID);
                        if (ListThongKeChiTietExisted.Count > 0)
                        {
                            int ResultRemove = await _ThongKeChiTietRepository.RemoveRangeAsync(ListThongKeChiTietExisted);
                        }
                        int ResultAdd = await _ThongKeChiTietRepository.AddRangeAsync(ListThongKeChiTiet);
                    }
                    model.Active = true;
                    await UpdateAsync(model);
                }
            }
            return model;
        }
        public virtual async Task<ThongKe> GetByParentID_Year_Month_DayAsync(long ParentID, int Year, int Month, int Day)
        {
            ThongKe result = new ThongKe();
            DateTime BatDau = new DateTime(Year, Month, Day);
            int diff = (7 + (BatDau.DayOfWeek - DayOfWeek.Monday)) % 7;
            BatDau = BatDau.AddDays(-1 * diff).Date;
            result = await GetByCondition(item => item.ParentID == ParentID && item.Year == BatDau.Year && item.Month == BatDau.Month && item.Day == BatDau.Day).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new ThongKe();
                result.ParentID = ParentID;
                result.BatDau = BatDau;
                await SaveAsync(result);
            }
            return result;
        }

    }
}

