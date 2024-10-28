using Service.Interface;

namespace Service.Implement
{
    public class ThanhVienService : BaseService<ThanhVien, IThanhVienRepository>
    , IThanhVienService
    {
        private readonly IThanhVienRepository _ThanhVienRepository;

        private readonly IThanhVienTokenService _ThanhVienTokenService;

        private readonly IDanhMucThanhVienService _DanhMucThanhVienService;
        public ThanhVienService(IThanhVienRepository ThanhVienRepository

            , IThanhVienTokenService ThanhVienTokenService

            , IDanhMucThanhVienService DanhMucThanhVienService
            
            ) : base(ThanhVienRepository)
        {
            _ThanhVienRepository = ThanhVienRepository;

            _ThanhVienTokenService = ThanhVienTokenService;

            _DanhMucThanhVienService = DanhMucThanhVienService;
        }
        public override void Initialization(ThanhVien model)
        {
            BaseInitialization(model);                       
            if (string.IsNullOrEmpty(model.GUIDCode))
            {
                model.GUIDCode = GlobalHelper.InitializationGUICode;
            }
            if (string.IsNullOrEmpty(model.MatKhau))
            {
                model.MatKhau = GlobalHelper.MatKhauMacDinh;
            }                       
            if (model.ParentID == null)
            {
                model.ParentID = GlobalHelper.DanhMucThanhVienID;
            }            

            if (model.ParentID > 0)
            {
                if (string.IsNullOrEmpty(model.ParentName))
                {
                    model.ParentName = _DanhMucThanhVienService.GetByID(model.ParentID.Value).Name;
                }
            }
        }
        public override async Task<ThanhVien> SaveAsync(ThanhVien model)
        {
            int result = await SaveSubAsync(model);
            if (result > 0)
            {              
            }
            return model;
        }
        private async Task<int> SaveSubAsync(ThanhVien model)
        {
            int result = GlobalHelper.InitializationNumber;
            bool isSave = true;
            Initialization(model);
            if (string.IsNullOrEmpty(model.TaiKhoan))
            {
                isSave = false;
            }
            ThanhVien modelExist = await GetByCondition(item => item.TaiKhoan == model.TaiKhoan).FirstOrDefaultAsync();
            if (modelExist != null)
            {
                if (modelExist.ID != model.ID)
                {
                    isSave = false;
                }
            }
            if (isSave == true)
            {
                if (model.ID > 0)
                {
                    if (model.MatKhau != modelExist.MatKhau)
                    {
                        model.MatKhau = SecurityHelper.Encrypt(model.GUIDCode, model.MatKhau);
                    }
                    if (string.IsNullOrEmpty(model.Note))
                    {
                        model.Note = modelExist.Note;
                    }
                    if (model.Active == null)
                    {
                        model.Active = modelExist.Active;
                    }
                    result = await UpdateAsync(model);
                }
                else
                {
                    model.MatKhau = SecurityHelper.Encrypt(model.GUIDCode, model.MatKhau);
                    result = await AddAsync(model);
                }
                if (result > 0)
                {
                }
            }
            return result;
        }
        public virtual async Task<ThanhVien> AuthenticationAsync(ThanhVien model)
        {
            ThanhVien result = new ThanhVien();
            if (!string.IsNullOrEmpty(model.TaiKhoan) && !string.IsNullOrEmpty(model.MatKhau))
            {
                result = await GetByCondition(item => item.Active == true && item.TaiKhoan == model.TaiKhoan).FirstOrDefaultAsync();
                bool check = false;
                if (result != null)
                {
                    string passwordDecrypt = SecurityHelper.Decrypt(result.GUIDCode, result.MatKhau);
                    if (passwordDecrypt.Equals(model.MatKhau))
                    {
                        check = true;
                    }
                }
                if (check == true)
                {

                    var claims = new[] {
                            new Claim(JwtRegisteredClaimNames.Sub, GlobalHelper.Subject),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                            new Claim("ID", result.ID.ToString())
                        };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(GlobalHelper.Key));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        GlobalHelper.Issuer,
                        GlobalHelper.Audience,
                        claims,
                        expires: DateTime.UtcNow.AddDays(GlobalHelper.TokenThoiGianHieuLuc),
                        signingCredentials: signIn
                    );

                    ThanhVienToken thanhVienToken = new ThanhVienToken();
                    thanhVienToken.Note = model.Note;
                    thanhVienToken.ParentID = result.ID;
                    thanhVienToken.Token = new JwtSecurityTokenHandler().WriteToken(token);
                    thanhVienToken.NgayBatDau = GlobalHelper.InitializationDateTime;
                    thanhVienToken.NgayKetThuc = thanhVienToken.NgayBatDau.Value.AddDays(GlobalHelper.TokenThoiGianHieuLuc);
                    thanhVienToken.Active = true;
                    await _ThanhVienTokenService.SaveAsync(thanhVienToken);
                    if (thanhVienToken.ID > 0)
                    {
                        result.Note = result.TypeName + "Homepage?" + GlobalHelper.Token + "=" + thanhVienToken.Token;
                        result.HTMLContent = thanhVienToken.Token;
                    }
                }
                else
                {
                    result = new ThanhVien();
                }
            }
            return result;
        }
    }
}

