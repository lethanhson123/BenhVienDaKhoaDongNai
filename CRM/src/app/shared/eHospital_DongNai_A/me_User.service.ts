import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_User } from './me_User.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_UserService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'User_id', 'User_Code', 'User_Name', 'Pass', 'User_Level', 'NgayTao', 'NgayDieuChinh', 'IsLocked'];

    List: me_User[] | undefined;
    ListFilter: me_User[] | undefined;
    FormData!: me_User;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_User";
    }
}

