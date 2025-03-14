import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhSuDefinitions } from './BenhSuDefinitions.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhSuDefinitionsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhSuDefinition_Id', 'BenhSuDefinition_Code', 'BenhSuDefinition_Name', 'BenhSuDefinition_Name_En', 'BenhSuDefinition_Name_Ru', 'Parent_Id', 'CallAnotherForm', 'Menu_Id', 'Report_Id', 'ReportKey_Name', 'ZoomPercents', 'Enabled', 'IsCrossTab', 'ReportTableIndex', 'ColumnNameItem', 'ColumnValueItem', 'Description'];

    List: BenhSuDefinitions[] | undefined;
    ListFilter: BenhSuDefinitions[] | undefined;
    FormData!: BenhSuDefinitions;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhSuDefinitions";
    }
}

