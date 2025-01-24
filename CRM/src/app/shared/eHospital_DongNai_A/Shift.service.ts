import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Shift } from './Shift.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ShiftService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Shift_Id', 'Shift_Name', 'Shift_Code', 'Schedule_Type', 'StartDay', 'EndDay', 'Resource_Id', 'Type_Id', 'Department_Id', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Repeat', 'StartOfWeek', 'QuaNgay'];

    List: Shift[] | undefined;
    ListFilter: Shift[] | undefined;
    FormData!: Shift;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Shift";
    }
}

