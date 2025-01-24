import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_UserMenus } from './Sys_UserMenus.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_UserMenusService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'User_Id', 'Menu_Id'];
    DisplayColumns002: string[] = ['Save', 'STT', 'Menu_Id'];

    List: Sys_UserMenus[] | undefined;
    ListFilter: Sys_UserMenus[] | undefined;
    FormData!: Sys_UserMenus;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_UserMenus";
    }
    GetByUser_Id_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_Id_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByUser_Id_SearchStringAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_Id_SearchStringAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByUser_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByUser_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

