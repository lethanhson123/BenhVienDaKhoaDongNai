import { Base } from "./Base.model";

export class GoiSo extends Base {

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
    NgayGhiNhan?: Date;
    TongCong?: number;
    TongCongString?: string;
    SoHienTai?: number;
    SoHienTaiString?: string;
}


