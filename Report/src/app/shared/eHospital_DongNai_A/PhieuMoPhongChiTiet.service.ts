import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuMoPhongChiTiet } from './PhieuMoPhongChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuMoPhongChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuMoPhongChiTiet_ID', 'PhieuMoPhong_ID', 'TenTruongChieu', 'MayDieuTri', 'TuTheBenhNhan', 'SSD', 'SFD', 'GocGantry', 'GocCollimator', 'X', 'Y', 'Y1', 'Y2', 'DiemLaser', 'TruongChieu_ID', 'MayDieuTri_ID', 'TuThe_ID', 'SoPhim', 'PhimThang', 'PhimNghieng', 'PhimKhac'];

    List: PhieuMoPhongChiTiet[] | undefined;
    ListFilter: PhieuMoPhongChiTiet[] | undefined;
    FormData!: PhieuMoPhongChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuMoPhongChiTiet";
    }
}

