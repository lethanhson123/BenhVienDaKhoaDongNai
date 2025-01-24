import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { His_XepLichChiTiet } from './His_XepLichChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class His_XepLichChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ScheduleDetail_His_Id', 'Schedule_His_Id', 'ScheduleDetail_Id', 'Schedule_Id', 'Schedule_Value', 'StartTime', 'EndTime', 'BreakStart', 'BreakEnd', 'TotalHours', 'CPI', 'Constant', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Idx', 'NumOfGroup', 'Department_Id', 'Block', 'PercentOfBlock', 'LyDoDoi'];

    List: His_XepLichChiTiet[] | undefined;
    ListFilter: His_XepLichChiTiet[] | undefined;
    FormData!: His_XepLichChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "His_XepLichChiTiet";
    }
}

