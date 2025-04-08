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
                    model.ParentName = DanhMucThongKe.Name;
                    model.Note = DanhMucThongKe.Note;
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
                        model.Name = model.Note + " TUẦN " + model.Week + " THÁNG " + model.Month + " NĂM " + model.Year + " (" + model.BatDau.Value.ToString("dd/MM/yyyy") + " - " + model.KetThuc.Value.ToString("dd/MM/yyyy") + ")";
                        break;
                    case 2:
                        model.Name = model.Note + " TUẦN " + model.Week + " THÁNG " + model.Month + " NĂM " + model.Year + " (" + model.BatDau.Value.ToString("dd/MM/yyyy") + " - " + model.KetThuc.Value.ToString("dd/MM/yyyy") + ")";
                        break;
                    case 3:
                        model.Quarter = 1;
                        switch (model.Month)
                        {
                            case 4:
                            case 5:
                            case 6:
                                model.Quarter = 2;
                                break;
                            case 7:
                            case 8:
                            case 9:
                                model.Quarter = 3;
                                break;
                            case 10:
                            case 11:
                            case 12:
                                model.Quarter = 4;
                                break;
                        }
                        model.Display = "Quý " + model.Quarter + " năm " + model.Year;
                        model.Name = model.Note + " " + model.Display;
                        break;
                    case 4:
                        model.Name = model.Note + " THÁNG " + model.Month + " NĂM " + model.Year;
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
                    switch (model.ParentID)
                    {
                        case 1:
                            await Sync1(model);
                            break;
                        case 2:
                            await Sync2(model);
                            break;
                        case 3:
                            await Sync3(model);
                            break;
                    }

                }
            }
            return model;
        }
        private async Task<int> Sync1(ThongKe model)
        {
            int Result = 0;
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
            return Result;
        }
        private async Task<int> Sync2(ThongKe model)
        {
            int Result = 0;
            SqlParameter[] parameters =
                            {
                            new SqlParameter("@ParentID", model.ID),
                            new SqlParameter("@BatDau", model.BatDau.Value),
                            new SqlParameter("@KetThuc", model.KetThuc.Value),
                             };
            List<ThongKeChiTiet> ListThongKeChiTiet = await _ThongKeChiTietRepository.GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A, "sp_ReportA0003", parameters);
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
            return Result;
        }
        private async Task<int> Sync3(ThongKe model)
        {
            int Result = 0;
            try
            {
                switch (model.Month)
                {
                    case 1:
                    case 2:
                    case 3:
                        model.Month = 3;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        model.Month = 6;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        model.Month = 9;
                        break;
                    case 10:
                    case 11:
                    case 12:
                        model.Month = 12;
                        break;
                }
                SqlParameter[] parameters =
                          {
                            new SqlParameter("@ParentID", model.ID),
                            new SqlParameter("@Year", model.Year.Value),
                            new SqlParameter("@Month", model.Month.Value),
                            new SqlParameter("@SortOrder", 1),
                             };
                int Year = model.Year.Value;
                int Month = model.Month.Value - 3;
                if (Month < 1)
                {
                    Month = 12;
                    Year = Year - 1;
                }
                SqlParameter[] parameters001 =
                         {
                            new SqlParameter("@ParentID", model.ID),
                            new SqlParameter("@Year", Year),
                            new SqlParameter("@Month", Month),
                            new SqlParameter("@SortOrder", 4),
                             };
                List<ThongKeChiTiet> ListThongKeChiTiet = new List<ThongKeChiTiet>();
                ListThongKeChiTiet.AddRange(await _ThongKeChiTietRepository.GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A, "sp_ReportA0005", parameters));
                ListThongKeChiTiet.AddRange(await _ThongKeChiTietRepository.GetByStoredProcedureToListAsync(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A, "sp_ReportA0005", parameters001));
                if (ListThongKeChiTiet.Count > 0)
                {
                    List<ThongKeChiTiet> ListThongKeChiTietExisted = await _ThongKeChiTietRepository.GetByParentIDToListAsync(model.ID);
                    if (ListThongKeChiTietExisted.Count > 0)
                    {
                        int ResultRemove = await _ThongKeChiTietRepository.RemoveRangeAsync(ListThongKeChiTietExisted);
                    }
                    ThongKeChiTiet ThongKeChiTiet100 = ListThongKeChiTiet.Where(item => item.SortOrder == 100).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet200 = ListThongKeChiTiet.Where(item => item.SortOrder == 200).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet300 = ListThongKeChiTiet.Where(item => item.SortOrder == 300).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet400 = ListThongKeChiTiet.Where(item => item.SortOrder == 400).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet500 = ListThongKeChiTiet.Where(item => item.SortOrder == 500).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet600 = ListThongKeChiTiet.Where(item => item.SortOrder == 600).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet900 = ListThongKeChiTiet.Where(item => item.SortOrder == 900).FirstOrDefault();
                    ThongKeChiTiet ThongKeChiTiet90 = ListThongKeChiTiet.Where(item => item.SortOrder == 90).FirstOrDefault();

                    ThongKeChiTiet ThongKeChiTiet123 = new ThongKeChiTiet();
                    ThongKeChiTiet123.ParentID = model.ID;
                    ThongKeChiTiet123.SortOrder = 123;
                    ThongKeChiTiet123.ThongKe000 = (ThongKeChiTiet100.ThongKe000 + ThongKeChiTiet200.ThongKe000 + ThongKeChiTiet300.ThongKe000) / 3;
                    ThongKeChiTiet123.ThongKe001 = (ThongKeChiTiet100.ThongKe001 + ThongKeChiTiet200.ThongKe001 + ThongKeChiTiet300.ThongKe001) / 3;
                    ThongKeChiTiet123.ThongKe002 = (ThongKeChiTiet100.ThongKe002 + ThongKeChiTiet200.ThongKe002 + ThongKeChiTiet300.ThongKe002) / 3;
                    ThongKeChiTiet123.ThongKe003 = (ThongKeChiTiet100.ThongKe003 + ThongKeChiTiet200.ThongKe003 + ThongKeChiTiet300.ThongKe003) / 3;
                    ThongKeChiTiet123.ThongKe004 = (ThongKeChiTiet100.ThongKe004 + ThongKeChiTiet200.ThongKe004 + ThongKeChiTiet300.ThongKe004) / 3;
                    ThongKeChiTiet123.ThongKe005 = (ThongKeChiTiet100.ThongKe005 + ThongKeChiTiet200.ThongKe005 + ThongKeChiTiet300.ThongKe005) / 3;
                    ThongKeChiTiet123.ThongKe006 = (ThongKeChiTiet100.ThongKe006 + ThongKeChiTiet200.ThongKe006 + ThongKeChiTiet300.ThongKe006) / 3;
                    ThongKeChiTiet123.ThongKe007 = (ThongKeChiTiet100.ThongKe007 + ThongKeChiTiet200.ThongKe007 + ThongKeChiTiet300.ThongKe007) / 3;
                    ThongKeChiTiet123.ThongKe008 = (ThongKeChiTiet100.ThongKe008 + ThongKeChiTiet200.ThongKe008 + ThongKeChiTiet300.ThongKe008) / 3;
                    ThongKeChiTiet123.ThongKe009 = (ThongKeChiTiet100.ThongKe009 + ThongKeChiTiet200.ThongKe009 + ThongKeChiTiet300.ThongKe009) / 3;
                    ThongKeChiTiet123.ThongKe010 = (ThongKeChiTiet100.ThongKe010 + ThongKeChiTiet200.ThongKe010 + ThongKeChiTiet300.ThongKe010) / 3;
                    ThongKeChiTiet123.ThongKe011 = (ThongKeChiTiet100.ThongKe011 + ThongKeChiTiet200.ThongKe011 + ThongKeChiTiet300.ThongKe011) / 3;

                    ThongKeChiTiet ThongKeChiTiet456 = new ThongKeChiTiet();
                    ThongKeChiTiet456.ParentID = model.ID;
                    ThongKeChiTiet456.SortOrder = 456;
                    ThongKeChiTiet456.ThongKe000 = (ThongKeChiTiet400.ThongKe000 + ThongKeChiTiet500.ThongKe000 + ThongKeChiTiet600.ThongKe000) / 3;
                    ThongKeChiTiet456.ThongKe001 = (ThongKeChiTiet400.ThongKe001 + ThongKeChiTiet500.ThongKe001 + ThongKeChiTiet600.ThongKe001) / 3;
                    ThongKeChiTiet456.ThongKe002 = (ThongKeChiTiet400.ThongKe002 + ThongKeChiTiet500.ThongKe002 + ThongKeChiTiet600.ThongKe002) / 3;
                    ThongKeChiTiet456.ThongKe003 = (ThongKeChiTiet400.ThongKe003 + ThongKeChiTiet500.ThongKe003 + ThongKeChiTiet600.ThongKe003) / 3;
                    ThongKeChiTiet456.ThongKe004 = (ThongKeChiTiet400.ThongKe004 + ThongKeChiTiet500.ThongKe004 + ThongKeChiTiet600.ThongKe004) / 3;
                    ThongKeChiTiet456.ThongKe005 = (ThongKeChiTiet400.ThongKe005 + ThongKeChiTiet500.ThongKe005 + ThongKeChiTiet600.ThongKe005) / 3;
                    ThongKeChiTiet456.ThongKe006 = (ThongKeChiTiet400.ThongKe006 + ThongKeChiTiet500.ThongKe006 + ThongKeChiTiet600.ThongKe006) / 3;
                    ThongKeChiTiet456.ThongKe007 = (ThongKeChiTiet400.ThongKe007 + ThongKeChiTiet500.ThongKe007 + ThongKeChiTiet600.ThongKe007) / 3;
                    ThongKeChiTiet456.ThongKe008 = (ThongKeChiTiet400.ThongKe008 + ThongKeChiTiet500.ThongKe008 + ThongKeChiTiet600.ThongKe008) / 3;
                    ThongKeChiTiet456.ThongKe009 = (ThongKeChiTiet400.ThongKe009 + ThongKeChiTiet500.ThongKe009 + ThongKeChiTiet600.ThongKe009) / 3;
                    ThongKeChiTiet456.ThongKe010 = (ThongKeChiTiet400.ThongKe010 + ThongKeChiTiet500.ThongKe010 + ThongKeChiTiet600.ThongKe010) / 3;
                    ThongKeChiTiet456.ThongKe011 = (ThongKeChiTiet400.ThongKe011 + ThongKeChiTiet500.ThongKe011 + ThongKeChiTiet600.ThongKe011) / 3;

                    ThongKeChiTiet ThongKeChiTiet123456 = new ThongKeChiTiet();
                    ThongKeChiTiet123456.ParentID = model.ID;
                    ThongKeChiTiet123456.SortOrder = 123456;
                    ThongKeChiTiet123456.ThongKe000 = ThongKeChiTiet123.ThongKe000 - ThongKeChiTiet456.ThongKe000;
                    ThongKeChiTiet123456.ThongKe001 = ThongKeChiTiet123.ThongKe001 - ThongKeChiTiet456.ThongKe001;
                    ThongKeChiTiet123456.ThongKe002 = ThongKeChiTiet123.ThongKe002 - ThongKeChiTiet456.ThongKe002;
                    ThongKeChiTiet123456.ThongKe003 = ThongKeChiTiet123.ThongKe003 - ThongKeChiTiet456.ThongKe003;
                    ThongKeChiTiet123456.ThongKe004 = ThongKeChiTiet123.ThongKe004 - ThongKeChiTiet456.ThongKe004;
                    ThongKeChiTiet123456.ThongKe005 = ThongKeChiTiet123.ThongKe005 - ThongKeChiTiet456.ThongKe005;
                    ThongKeChiTiet123456.ThongKe007 = ThongKeChiTiet123.ThongKe007 - ThongKeChiTiet456.ThongKe007;
                    ThongKeChiTiet123456.ThongKe008 = ThongKeChiTiet123.ThongKe008 - ThongKeChiTiet456.ThongKe008;
                    ThongKeChiTiet123456.ThongKe009 = ThongKeChiTiet123.ThongKe009 - ThongKeChiTiet456.ThongKe009;
                    ThongKeChiTiet123456.ThongKe010 = ThongKeChiTiet123.ThongKe010 - ThongKeChiTiet456.ThongKe010;
                    ThongKeChiTiet123456.ThongKe011 = ThongKeChiTiet123.ThongKe011 - ThongKeChiTiet456.ThongKe011;

                    ThongKeChiTiet ThongKeChiTiet123900 = new ThongKeChiTiet();
                    ThongKeChiTiet123900.ParentID = model.ID;
                    ThongKeChiTiet123900.SortOrder = 123900;
                    ThongKeChiTiet123900.ThongKe000 = ThongKeChiTiet123.ThongKe000 - ThongKeChiTiet900.ThongKe000;
                    ThongKeChiTiet123900.ThongKe001 = ThongKeChiTiet123.ThongKe001 - ThongKeChiTiet900.ThongKe001;
                    ThongKeChiTiet123900.ThongKe002 = ThongKeChiTiet123.ThongKe002 - ThongKeChiTiet900.ThongKe002;
                    ThongKeChiTiet123900.ThongKe003 = ThongKeChiTiet123.ThongKe003 - ThongKeChiTiet900.ThongKe003;
                    ThongKeChiTiet123900.ThongKe004 = ThongKeChiTiet123.ThongKe004 - ThongKeChiTiet900.ThongKe004;
                    ThongKeChiTiet123900.ThongKe005 = ThongKeChiTiet123.ThongKe005 - ThongKeChiTiet900.ThongKe005;
                    ThongKeChiTiet123900.ThongKe007 = ThongKeChiTiet123.ThongKe007 - ThongKeChiTiet900.ThongKe007;
                    ThongKeChiTiet123900.ThongKe008 = ThongKeChiTiet123.ThongKe008 - ThongKeChiTiet900.ThongKe008;
                    ThongKeChiTiet123900.ThongKe009 = ThongKeChiTiet123.ThongKe009 - ThongKeChiTiet900.ThongKe009;
                    ThongKeChiTiet123900.ThongKe010 = ThongKeChiTiet123.ThongKe010 - ThongKeChiTiet900.ThongKe010;
                    ThongKeChiTiet123900.ThongKe011 = ThongKeChiTiet123.ThongKe011 - ThongKeChiTiet900.ThongKe011;

                    ThongKeChiTiet ThongKeChiTiet12390 = new ThongKeChiTiet();
                    ThongKeChiTiet12390.ParentID = model.ID;
                    ThongKeChiTiet12390.SortOrder = 12390;
                    ThongKeChiTiet12390.ThongKe000 = ThongKeChiTiet123.ThongKe000 - ThongKeChiTiet90.ThongKe000;
                    ThongKeChiTiet12390.ThongKe001 = ThongKeChiTiet123.ThongKe001 - ThongKeChiTiet90.ThongKe001;
                    ThongKeChiTiet12390.ThongKe002 = ThongKeChiTiet123.ThongKe002 - ThongKeChiTiet90.ThongKe002;
                    ThongKeChiTiet12390.ThongKe003 = ThongKeChiTiet123.ThongKe003 - ThongKeChiTiet90.ThongKe003;
                    ThongKeChiTiet12390.ThongKe004 = ThongKeChiTiet123.ThongKe004 - ThongKeChiTiet90.ThongKe004;
                    ThongKeChiTiet12390.ThongKe005 = ThongKeChiTiet123.ThongKe005 - ThongKeChiTiet90.ThongKe005;
                    ThongKeChiTiet12390.ThongKe007 = ThongKeChiTiet123.ThongKe007 - ThongKeChiTiet90.ThongKe007;
                    ThongKeChiTiet12390.ThongKe008 = ThongKeChiTiet123.ThongKe008 - ThongKeChiTiet90.ThongKe008;
                    ThongKeChiTiet12390.ThongKe009 = ThongKeChiTiet123.ThongKe009 - ThongKeChiTiet90.ThongKe009;
                    ThongKeChiTiet12390.ThongKe010 = ThongKeChiTiet123.ThongKe010 - ThongKeChiTiet90.ThongKe010;
                    ThongKeChiTiet12390.ThongKe011 = ThongKeChiTiet123.ThongKe011 - ThongKeChiTiet90.ThongKe011;

                    ThongKeChiTiet ThongKeChiTiet34 = new ThongKeChiTiet();
                    ThongKeChiTiet34.ParentID = model.ID;
                    ThongKeChiTiet34.SortOrder = 34;
                    ThongKeChiTiet34.ThongKe000 = ThongKeChiTiet300.ThongKe000 - ThongKeChiTiet400.ThongKe000;
                    ThongKeChiTiet34.ThongKe001 = ThongKeChiTiet300.ThongKe001 - ThongKeChiTiet400.ThongKe001;
                    ThongKeChiTiet34.ThongKe002 = ThongKeChiTiet300.ThongKe002 - ThongKeChiTiet400.ThongKe002;
                    ThongKeChiTiet34.ThongKe003 = ThongKeChiTiet300.ThongKe003 - ThongKeChiTiet400.ThongKe003;
                    ThongKeChiTiet34.ThongKe004 = ThongKeChiTiet300.ThongKe004 - ThongKeChiTiet400.ThongKe004;
                    ThongKeChiTiet34.ThongKe005 = ThongKeChiTiet300.ThongKe005 - ThongKeChiTiet400.ThongKe005;
                    ThongKeChiTiet34.ThongKe006 = ThongKeChiTiet300.ThongKe006 - ThongKeChiTiet400.ThongKe006;
                    ThongKeChiTiet34.ThongKe007 = ThongKeChiTiet300.ThongKe007 - ThongKeChiTiet400.ThongKe007;
                    ThongKeChiTiet34.ThongKe008 = ThongKeChiTiet300.ThongKe008 - ThongKeChiTiet400.ThongKe008;
                    ThongKeChiTiet34.ThongKe009 = ThongKeChiTiet300.ThongKe009 - ThongKeChiTiet400.ThongKe009;
                    ThongKeChiTiet34.ThongKe010 = ThongKeChiTiet300.ThongKe010 - ThongKeChiTiet400.ThongKe010;
                    ThongKeChiTiet34.ThongKe011 = ThongKeChiTiet300.ThongKe011 - ThongKeChiTiet400.ThongKe011;

                    ThongKeChiTiet ThongKeChiTiet23 = new ThongKeChiTiet();
                    ThongKeChiTiet23.ParentID = model.ID;
                    ThongKeChiTiet23.SortOrder = 23;
                    ThongKeChiTiet23.ThongKe000 = ThongKeChiTiet200.ThongKe000 - ThongKeChiTiet300.ThongKe000;
                    ThongKeChiTiet23.ThongKe001 = ThongKeChiTiet200.ThongKe001 - ThongKeChiTiet300.ThongKe001;
                    ThongKeChiTiet23.ThongKe002 = ThongKeChiTiet200.ThongKe002 - ThongKeChiTiet300.ThongKe002;
                    ThongKeChiTiet23.ThongKe003 = ThongKeChiTiet200.ThongKe003 - ThongKeChiTiet300.ThongKe003;
                    ThongKeChiTiet23.ThongKe004 = ThongKeChiTiet200.ThongKe004 - ThongKeChiTiet300.ThongKe004;
                    ThongKeChiTiet23.ThongKe005 = ThongKeChiTiet200.ThongKe005 - ThongKeChiTiet300.ThongKe005;
                    ThongKeChiTiet23.ThongKe006 = ThongKeChiTiet200.ThongKe006 - ThongKeChiTiet300.ThongKe006;
                    ThongKeChiTiet23.ThongKe007 = ThongKeChiTiet200.ThongKe007 - ThongKeChiTiet300.ThongKe007;
                    ThongKeChiTiet23.ThongKe008 = ThongKeChiTiet200.ThongKe008 - ThongKeChiTiet300.ThongKe008;
                    ThongKeChiTiet23.ThongKe009 = ThongKeChiTiet200.ThongKe009 - ThongKeChiTiet300.ThongKe009;
                    ThongKeChiTiet23.ThongKe010 = ThongKeChiTiet200.ThongKe010 - ThongKeChiTiet300.ThongKe010;
                    ThongKeChiTiet23.ThongKe011 = ThongKeChiTiet200.ThongKe011 - ThongKeChiTiet300.ThongKe011;

                    ThongKeChiTiet ThongKeChiTiet12 = new ThongKeChiTiet ();
                    ThongKeChiTiet12.ParentID = model.ID;
                    ThongKeChiTiet12.SortOrder = 12;
                    ThongKeChiTiet12.ThongKe000 = ThongKeChiTiet100.ThongKe000 - ThongKeChiTiet200.ThongKe000;
                    ThongKeChiTiet12.ThongKe001 = ThongKeChiTiet100.ThongKe001 - ThongKeChiTiet200.ThongKe001;
                    ThongKeChiTiet12.ThongKe002 = ThongKeChiTiet100.ThongKe002 - ThongKeChiTiet200.ThongKe002;
                    ThongKeChiTiet12.ThongKe003 = ThongKeChiTiet100.ThongKe003 - ThongKeChiTiet200.ThongKe003;
                    ThongKeChiTiet12.ThongKe004 = ThongKeChiTiet100.ThongKe004 - ThongKeChiTiet200.ThongKe004;
                    ThongKeChiTiet12.ThongKe005 = ThongKeChiTiet100.ThongKe005 - ThongKeChiTiet200.ThongKe005;
                    ThongKeChiTiet12.ThongKe006 = ThongKeChiTiet100.ThongKe006 - ThongKeChiTiet200.ThongKe006;
                    ThongKeChiTiet12.ThongKe007 = ThongKeChiTiet100.ThongKe007 - ThongKeChiTiet200.ThongKe007;
                    ThongKeChiTiet12.ThongKe008 = ThongKeChiTiet100.ThongKe008 - ThongKeChiTiet200.ThongKe008;
                    ThongKeChiTiet12.ThongKe009 = ThongKeChiTiet100.ThongKe009 - ThongKeChiTiet200.ThongKe009;
                    ThongKeChiTiet12.ThongKe010 = ThongKeChiTiet100.ThongKe010 - ThongKeChiTiet200.ThongKe010;
                    ThongKeChiTiet12.ThongKe011 = ThongKeChiTiet100.ThongKe011 - ThongKeChiTiet200.ThongKe011;

                    ListThongKeChiTiet.Add(ThongKeChiTiet123);
                    ListThongKeChiTiet.Add(ThongKeChiTiet456);
                    ListThongKeChiTiet.Add(ThongKeChiTiet123456);
                    ListThongKeChiTiet.Add(ThongKeChiTiet123900);
                    ListThongKeChiTiet.Add(ThongKeChiTiet12390);
                    ListThongKeChiTiet.Add(ThongKeChiTiet34);
                    ListThongKeChiTiet.Add(ThongKeChiTiet23);
                    ListThongKeChiTiet.Add(ThongKeChiTiet12);
                    int ResultAdd = await _ThongKeChiTietRepository.AddRangeAsync(ListThongKeChiTiet);
                }

                model.Active = true;
                await UpdateAsync(model);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }


            return Result;
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
        public virtual async Task<ThongKe> GetByParentID_Year_MonthAsync(long ParentID, int Year, int Month)
        {
            ThongKe result = new ThongKe();
            DateTime BatDau = new DateTime(Year, Month, 1);
            result = await GetByCondition(item => item.ParentID == ParentID && item.Year == BatDau.Year && item.Month == BatDau.Month).FirstOrDefaultAsync();
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

