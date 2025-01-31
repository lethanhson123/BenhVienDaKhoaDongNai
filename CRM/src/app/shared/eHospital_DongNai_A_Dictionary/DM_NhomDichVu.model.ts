import { Base } from "./Base.model";

export class DM_NhomDichVu extends Base{
NhomDichVu_Id?: number;
MaNhomDichVu?: string;
LoaiDichVu_Id?: number;
TenNhomDichVu?: string;
TenNhomDichVu_En?: string;
TenNhomDichVu_Ru?: string;
Cap?: number;
CapTren_Id?: number;
TraLoiKetQuaRieng?: boolean;
TamNgung?: boolean;
TenKhongDau?: string;
NgayTao?: Date;
NguoiTao_Id?: number;
NgayCapNhat?: Date;
NguoiCapNhat_Id?: number;
DuocCapSTT?: boolean;
SiteCode?: string;
Mapping_Public_Id?: number;
CapSoTT?: boolean;
CreateSIDForPACS?: boolean;

}


