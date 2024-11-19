import { Base } from "./Base.model";

export class GoiSoChiTiet extends Base{
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
DanhMucKhuVucID?: number;
DanhMucKhuVucName?: string;
DanhMucKhuVucCode?: string;
DanhMucDichVuID?: number;
DanhMucDichVuName?: string;
DanhMucDichVuCode?: string;
DanhMucQuayDichVuID?: number;
DanhMucQuayDichVuName?: string;
DanhMucQuayDichVuCode?: string;
DanhMucPhongKhamID?: number;
DanhMucPhongKhamName?: string;
DanhMucPhongKhamCode?: string;
SoThuTu?: string;
NgayCapSo?: Date;
NgayDangKy?: Date;
NgayThanhToan?: Date;
NgayKham?: Date;
NguoiKhamHoTen?: string;
NguoiKhamNamSinh?: string;
NguoiKhamDienThoai?: string;
NguoiKhamCCCD?: string;
NguoiKhamBHYT?: string;
NguoiKhamDiaChi?: string;

}


