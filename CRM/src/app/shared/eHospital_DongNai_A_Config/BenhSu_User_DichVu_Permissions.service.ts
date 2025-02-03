import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhSu_User_DichVu_Permissions } from './BenhSu_User_DichVu_Permissions.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhSu_User_DichVu_PermissionsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Group_Id', 'User_Id', 'DichVu_Id'];

    List: BenhSu_User_DichVu_Permissions[] | undefined;
    ListFilter: BenhSu_User_DichVu_Permissions[] | undefined;
    FormData!: BenhSu_User_DichVu_Permissions;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhSu_User_DichVu_Permissions";
    }
}

