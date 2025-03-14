import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ShiftDetail } from './ShiftDetail.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ShiftDetailService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ShiftDetail_Id', 'Shift_Id', 'Schedule_Value', 'StartTime', 'EndTime', 'BreakStart', 'BreakEnd', 'TotalHours', 'CPI', 'Constant', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Idx', 'NumOfGroup', 'Department_Id', 'Block', 'PercentOfBlock', 'Schedule_Type_Id', 'QuaNgay'];

    List: ShiftDetail[] | undefined;
    ListFilter: ShiftDetail[] | undefined;
    FormData!: ShiftDetail;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ShiftDetail";
    }
}

