import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BENHANNGOAITRU_KHAMBENH } from './BENHANNGOAITRU_KHAMBENH.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BENHANNGOAITRU_KHAMBENHService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KHAMBENH_ID', 'BENHANNGOAITRU_ID', 'LANKHAM', 'NGAYKHAM', 'THOIGIANKHAM', 'BASSIKHAM_ID', 'DIEUDUONG_ID', 'DINHBENH', 'DIENBIEN', 'LOIDAN', 'KHODUOC_ID', 'NGAYTAO', 'NGUOITAO_ID', 'NGAYCAPNHAT', 'NGUOICAPNHAT_ID', 'DOITUONG_ID', 'CAPHOLY_ID', 'RAVIEN', 'NGAYTAIKHAM', 'SONGAYHENTAIKHAM', 'CHUNGTUPHATTHUOC_ID', 'ATTRIBUTE_1', 'ATTRIBUTE_2', 'ATTRIBUTE_3', 'ATTRIBUTE_4', 'ATTRIBUTE_5', 'ATTRIBUTE_6', 'LoaiToaThuoc', 'NoiNhanThuoc_ID', 'ThuocDacTri', 'KhamNgoaiTru'];

    List: BENHANNGOAITRU_KHAMBENH[] | undefined;
    ListFilter: BENHANNGOAITRU_KHAMBENH[] | undefined;
    FormData!: BENHANNGOAITRU_KHAMBENH;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BENHANNGOAITRU_KHAMBENH";
    }
}

