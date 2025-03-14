import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BCDP_014_TheoLo } from './BCDP_014_TheoLo.model';
import { BaseService } from './Base.service';

import { XML1_CV130 } from './XML1_CV130.model';
import { XML2_CV130 } from './XML2_CV130.model';
import { XML3_CV130 } from './XML3_CV130.model';
import { XML4_CV130 } from './XML4_CV130.model';
import { XML5_CV130 } from './XML5_CV130.model';
import { XML6_CV130 } from './XML6_CV130.model';
import { XML7_CV130 } from './XML7_CV130.model';
import { XML8_CV130 } from './XML8_CV130.model';
import { XML9_CV130 } from './XML9_CV130.model';
import { XML10_CV130 } from './XML10_CV130.model';
import { XML11_CV130 } from './XML11_CV130.model';
import { XML12_CV130 } from './XML12_CV130.model';
import { XML13_CV130 } from './XML13_CV130.model';
import { XML14_CV130 } from './XML14_CV130.model';
import { XML15_CV130 } from './XML15_CV130.model';


@Injectable({
    providedIn: 'root'
})
export class DownloadService extends BaseService{   
    
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Download";
    }

    CreateXMLCV130Async(ListXML1_CV130: XML1_CV130[],         
        ListXML2_CV130: XML2_CV130[], 
        ListXML3_CV130: XML3_CV130[],
        ListXML4_CV130: XML4_CV130[],
        ListXML5_CV130: XML5_CV130[],
        ListXML6_CV130: XML6_CV130[],
        ListXML7_CV130: XML7_CV130[],
        ListXML8_CV130: XML8_CV130[],
        ListXML9_CV130: XML9_CV130[],
        ListXML10_CV130: XML10_CV130[],
        ListXML11_CV130: XML11_CV130[],
        ListXML12_CV130: XML12_CV130[],
        ListXML13_CV130: XML13_CV130[],
        ListXML14_CV130: XML14_CV130[],
        ListXML15_CV130: XML15_CV130[],
    
    ) {
        let url = this.APIURL + this.Controller + '/CreateXMLCV130Async';
        const formUpload: FormData = new FormData();
        formUpload.append('ListXML1_CV130', JSON.stringify(ListXML1_CV130));
        formUpload.append('ListXML2_CV130', JSON.stringify(ListXML2_CV130));
        formUpload.append('ListXML3_CV130', JSON.stringify(ListXML3_CV130));
        formUpload.append('ListXML4_CV130', JSON.stringify(ListXML4_CV130));
        formUpload.append('ListXML5_CV130', JSON.stringify(ListXML5_CV130));
        formUpload.append('ListXML6_CV130', JSON.stringify(ListXML6_CV130));
        formUpload.append('ListXML7_CV130', JSON.stringify(ListXML7_CV130));
        formUpload.append('ListXML8_CV130', JSON.stringify(ListXML8_CV130));
        formUpload.append('ListXML9_CV130', JSON.stringify(ListXML9_CV130));
        formUpload.append('ListXML10_CV130', JSON.stringify(ListXML10_CV130));
        formUpload.append('ListXML11_CV130', JSON.stringify(ListXML11_CV130));
        formUpload.append('ListXML12_CV130', JSON.stringify(ListXML12_CV130));
        formUpload.append('ListXML13_CV130', JSON.stringify(ListXML13_CV130));
        formUpload.append('ListXML14_CV130', JSON.stringify(ListXML14_CV130));
        formUpload.append('ListXML15_CV130', JSON.stringify(ListXML15_CV130));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

