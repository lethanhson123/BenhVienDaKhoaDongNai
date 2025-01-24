import { Base } from "./Base.model";

export class RIS_MESSAGES_SEND extends Base{
Messages_Id?: number;
Messages_Control_Id?: string;
Messages_Type?: string;
Messages_Type_Code?: string;
Messages_Name?: string;
BenhNhan_Id?: number;
TiepNhan_Id?: number;
BenhAn_Id?: number;
CLSYeuCau_Id?: number;
YeuCauChiTiet_Id?: number;
DichVu_Id?: number;
NguoiTao_Id?: number;
NgayTao?: Date;
NguoiCapNhat_Id?: number;
NgayCapNhat?: Date;

}


