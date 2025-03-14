import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_KhuVuc_User } from './me_KhuVuc_User.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_KhuVuc_UserService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhuVuc_User_id', 'KhuVuc_id', 'User_id', 'NgayTao', 'NgayCapNhat'];

    List: me_KhuVuc_User[] | undefined;
    ListFilter: me_KhuVuc_User[] | undefined;
    FormData!: me_KhuVuc_User;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_KhuVuc_User";
    }
}

