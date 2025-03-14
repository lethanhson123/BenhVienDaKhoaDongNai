import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Import_Lst_Dictionary_NgheNghiep } from './Import_Lst_Dictionary_NgheNghiep.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Import_Lst_Dictionary_NgheNghiepService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Dictionary_Type_Id', 'Dictionary_Type_Code', 'Dictionary_Code', 'Dictionary_Name', 'Dictionary_Name_En', 'Dictionary_Name_Ru', 'Enabled', 'Latin_Name'];

    List: Import_Lst_Dictionary_NgheNghiep[] | undefined;
    ListFilter: Import_Lst_Dictionary_NgheNghiep[] | undefined;
    FormData!: Import_Lst_Dictionary_NgheNghiep;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Import_Lst_Dictionary_NgheNghiep";
    }
}

