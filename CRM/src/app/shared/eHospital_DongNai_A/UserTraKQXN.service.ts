import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { UserTraKQXN } from './UserTraKQXN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class UserTraKQXNService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DangKi_id', 'User_id', 'User_Name', 'KhoaQuanLy_id', 'TenKhoa', 'NgayTao', 'NguoiTao', 'IsActive'];

    List: UserTraKQXN[] | undefined;
    ListFilter: UserTraKQXN[] | undefined;
    FormData!: UserTraKQXN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "UserTraKQXN";
    }
}

