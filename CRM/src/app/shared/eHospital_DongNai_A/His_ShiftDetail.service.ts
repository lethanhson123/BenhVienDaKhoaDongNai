import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { His_ShiftDetail } from './His_ShiftDetail.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class His_ShiftDetailService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ShiftDetail_His_Id', 'Shift_His_Id', 'ShiftDetail_Id', 'Shift_Id', 'Schedule_Value', 'StartTime', 'EndTime', 'BreakStart', 'BreakEnd', 'TotalHours', 'CPI', 'Constant', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Idx', 'NumOfGroup', 'Department_Id', 'Block', 'PercentOfBlock', 'LyDoDoi', 'Schedule_Type_Id'];

    List: His_ShiftDetail[] | undefined;
    ListFilter: His_ShiftDetail[] | undefined;
    FormData!: His_ShiftDetail;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "His_ShiftDetail";
    }
}

