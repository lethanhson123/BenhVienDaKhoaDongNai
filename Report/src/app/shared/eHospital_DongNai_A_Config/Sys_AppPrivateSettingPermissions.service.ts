import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_AppPrivateSettingPermissions } from './Sys_AppPrivateSettingPermissions.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_AppPrivateSettingPermissionsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SettingPermission_Id', 'Setting_Id', 'User_Id', 'Group_Id', 'EditRight', 'DeleteRight'];

    List: Sys_AppPrivateSettingPermissions[] | undefined;
    ListFilter: Sys_AppPrivateSettingPermissions[] | undefined;
    FormData!: Sys_AppPrivateSettingPermissions;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_AppPrivateSettingPermissions";
    }
}

