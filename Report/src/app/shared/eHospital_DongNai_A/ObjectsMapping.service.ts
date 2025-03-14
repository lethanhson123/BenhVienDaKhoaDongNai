import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ObjectsMapping } from './ObjectsMapping.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ObjectsMappingService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ObjectsMapping_Id', 'CreatedBy', 'CreatedDate', 'Object1_Id', 'Object2_Id', 'TableName', 'SiteCode', 'Mapping_Public_Id'];

    List: ObjectsMapping[] | undefined;
    ListFilter: ObjectsMapping[] | undefined;
    FormData!: ObjectsMapping;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ObjectsMapping";
    }
}

