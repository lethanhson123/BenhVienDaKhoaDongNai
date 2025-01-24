import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_UserWorking } from './Sys_UserWorking.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_UserWorkingService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'UserWorking_Id', 'User_Id', 'Khoa_Id', 'Phong_Id', 'PhongKham_Id', 'QuayThuVienPhi_Id', 'KhoDuoc_Id', 'LogInTime', 'LogOutTime'];

    List: Sys_UserWorking[] | undefined;
    ListFilter: Sys_UserWorking[] | undefined;
    FormData!: Sys_UserWorking;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_UserWorking";
    }
}

