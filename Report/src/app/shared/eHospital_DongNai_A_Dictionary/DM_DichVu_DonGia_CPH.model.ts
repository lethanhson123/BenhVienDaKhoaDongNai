import { Base } from "./Base.model";

export class DM_DichVu_DonGia_CPH extends Base{
DichVu_DonGia_Id?: number;
BangGia_CPH_Id?: number;
DichVu_Id?: number;
LoaiGia_Id?: number;
TienTe_Id?: string;
DonGia?: string;
DonGiaThapNhat?: string;
DonGiaCaoNhat?: string;
TyLeVAT?: string;
GiaTriVAT?: string;
TrangThai?: string;
TamNgung?: boolean;
NgayTao?: Date;
NguoiTao_Id?: number;
NgayCapNhat?: Date;
NguoiCapNhat_Id?: number;
DichVuName?: string;
LoaiGiaName?: string;

}


