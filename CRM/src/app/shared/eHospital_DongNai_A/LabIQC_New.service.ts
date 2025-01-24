import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LabIQC_New } from './LabIQC_New.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LabIQC_NewService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'IQC_New_ID', 'IQCName', 'IQC_Level', 'SD2_New_m', 'SD2_New', 'SD_New', 'Mean_New', 'CV_REF', 'FromDate', 'ToDate', 'IsActive', 'CreatedDate', 'CreatedBy', 'ModifiedDate', 'ModifiedBy', 'ServiceID', 'Lot_Id'];

    List: LabIQC_New[] | undefined;
    ListFilter: LabIQC_New[] | undefined;
    FormData!: LabIQC_New;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LabIQC_New";
    }
}

