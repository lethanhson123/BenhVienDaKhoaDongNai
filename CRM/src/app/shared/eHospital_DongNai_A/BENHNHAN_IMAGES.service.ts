import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BENHNHAN_IMAGES } from './BENHNHAN_IMAGES.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BENHNHAN_IMAGESService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_Images_Id', 'BenhNhan_Id', 'File_Name_Origin', 'File_Name', 'NhomDichVu_Id', 'TenHinh', 'MoTa', 'NgayGhiNhanKetQua', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'TiepNhan_Id', 'LoaiHinhAnh_Id', 'Folder', 'NgayFolder'];

    List: BENHNHAN_IMAGES[] | undefined;
    ListFilter: BENHNHAN_IMAGES[] | undefined;
    FormData!: BENHNHAN_IMAGES;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BENHNHAN_IMAGES";
    }
}

