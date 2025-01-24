import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnPhauThuat_Images } from './BenhAnPhauThuat_Images.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnPhauThuat_ImagesService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Images_Id', 'BenhAnPhauThuat_Id', 'File_Name_Origin', 'File_Name', 'Idx', 'TenHinh', 'MoTaHinh', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'ChonInMacDinh'];

    List: BenhAnPhauThuat_Images[] | undefined;
    ListFilter: BenhAnPhauThuat_Images[] | undefined;
    FormData!: BenhAnPhauThuat_Images;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnPhauThuat_Images";
    }
}

