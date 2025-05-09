﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_Menus } from './Sys_Menus.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_MenusService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Menu_Id', 'Menu_Code', 'Menu_Name', 'Language_Id', 'Menu_Level', 'Idx', 'Parent_Id', 'Function_Id', 'Function_Argument', 'Default_Right', 'Enabled', 'MenuBar', 'MenuLeft', 'Is_System', 'Is_Report', 'Report_Id', 'Shortcut_Key', 'Shortcut_Character', 'WindowState', 'ShowDialog', 'Creation_Date', 'Created_By', 'Last_Update_Date', 'Last_Updated_By', 'Function_Argument_Notes', 'Remark'];

    List: Sys_Menus[] | undefined;
    ListFilter: Sys_Menus[] | undefined;    
    FormData!: Sys_Menus;

    ListAll: Sys_Menus[] | undefined;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_Menus";
    }

    GetByMenu_LevelToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByMenu_LevelToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByParent_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByParent_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByParent_IdAndEmptyToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByParent_IdAndEmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetBySearchString_Menu_IdToListAsync() {
        let url = this.APIURL + this.Controller + '/GetBySearchString_Menu_IdToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

