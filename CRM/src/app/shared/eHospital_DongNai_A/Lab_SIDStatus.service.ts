import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Lab_SIDStatus } from './Lab_SIDStatus.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Lab_SIDStatusService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'LabBarCodeID', 'CLSYeuCau_Id', 'CLSYeuCauChiTiet_Id', 'ServiceID', 'SIDIssueDate', 'SamplePlaceID', 'SamplePlace', 'Status'];

    List: Lab_SIDStatus[] | undefined;
    ListFilter: Lab_SIDStatus[] | undefined;
    FormData!: Lab_SIDStatus;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Lab_SIDStatus";
    }
}

