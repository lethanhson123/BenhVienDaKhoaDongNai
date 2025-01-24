import { Base } from "./Base.model";

export class Schedule extends Base{
Schedule_Id?: number;
NhanVien_Id?: number;
StartDay?: Date;
EndDay?: Date;
Schedule_Type?: number;
Repeat?: number;
Resource_Id?: number;
Type_Id?: number;
Department_Id?: number;
NguoiTao_Id?: number;
NgayTao?: Date;
NguoiCapNhat_Id?: number;
NgayCapNhat?: Date;
StartOfWeek?: Date;

}


