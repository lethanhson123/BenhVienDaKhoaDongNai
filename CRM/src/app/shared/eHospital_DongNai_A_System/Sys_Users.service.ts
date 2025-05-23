﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_Users } from './Sys_Users.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_UsersService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'User_Id', 'User_Code', 'User_Name', 'Language_Id', 'Domain_Id', 'User_Password', 'Suspend', 'User_Position', 'Allow_Change_Password', 'Expiration_Days', 'Expiration_Date', 'Encryption_Password', 'EmailAddress', 'PhoneNumber', 'FaxNumber', 'Creation_Date', 'Created_By', 'Last_Update_Date', 'Last_Updated_By', 'Login_Time', 'Login_Hostname', 'IsLogin', 'Last_Login_Time', 'Last_Login_Hostname', 'MinPasswordLen', 'StrongPassword', 'Latin_Name', 'UserOption1', 'UserOption2', 'UserOption3', 'UserOption4', 'UserOption5', 'UserOption6', 'UserOption7', 'UserOption8', 'UserOption9', 'TrangThaiSuspend'];
    DisplayColumns002: string[] = ['STT', 'User_Id', 'User_Code', 'User_Name', 'Suspend', 'TrangThaiSuspend', 'User_Position', 'EmailAddress', 'PhoneNumber', 'UserOption3', 'Creation_Date', 'Created_By', 'Last_Update_Date', 'Last_Updated_By'];
    DisplayColumns003: string[] = ['STT', 'Latin_Name', 'User_Id', 'User_Code', 'User_Name', 'Suspend', 'TrangThaiSuspend', 'User_Position', 'EmailAddress', 'PhoneNumber', 'UserOption3', 'Creation_Date', 'Created_By', 'Last_Update_Date', 'Last_Updated_By'];
    List: Sys_Users[] | undefined;
    ListFilter: Sys_Users[] | undefined;
    ListFilter001: Sys_Users[] | undefined;
    FormData!: Sys_Users;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_Users";
    }

    GetByUser_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByUser_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    ComponentGetAllToListAsync(Service: BaseService) {       
        if (this.List) {
            if (this.List.length == 0) {
                this.GetAllToListAsync().subscribe(
                    res => {
                        this.List = (res as any[]);
                        this.ListFilter = this.List;
                        this.ListFilter001 = this.List;
                    },
                    err => {
                    },
                    () => {                        
                    }
                );
            }
            else{            
            }
        }
        else{           
        }
    }
}

