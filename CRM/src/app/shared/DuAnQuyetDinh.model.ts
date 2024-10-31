import { Base } from "./Base.model";

export class DuAnQuyetDinh extends Base{
ID?: number;
ParentID?: number;
ParentName?: string;
CreatedDate?: Date;
CreatedMembershipID?: number;
LastUpdatedDate?: Date;
LastUpdatedMembershipID?: number;
RowVersion?: number;
SortOrder?: number;
Active?: boolean;
TypeName?: string;
Name?: string;
Code?: string;
Note?: string;
Display?: string;
FileName?: string;
Description?: string;
HTMLContent?: string;
DanhMucNgonNguID?: number;
DanhMucUngDungID?: number;
DanhMucNgonNguName?: string;
DanhMucUngDungName?: string;
NgayKy?: Date;
SoHoSo?: string;
SoQuyetDinh?: string;
BenDauTuID?: number;
BenDauTuName?: string;
BenDauTuMaSoThue?: string;
BenDauTuDienThoai?: string;
BenDauTuDiaChi?: string;
BenDauTuEmail?: string;
BenDauTuTaiKhoanID?: number;
BenDauTuSoTaiKhoan?: string;
BenDauTuNganHang?: string;
GhiCo?: number;
GhiNo?: number;
ConLai?: number;
MucDauTu?: number;

}


