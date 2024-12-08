﻿namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucDichVuController : BaseController<DanhMucDichVu, IDanhMucDichVuService>
    {
    private readonly IDanhMucDichVuService _DanhMucDichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucDichVuController(IDanhMucDichVuService DanhMucDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucDichVuService, WebHostEnvironment)
    {
    _DanhMucDichVuService = DanhMucDichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

