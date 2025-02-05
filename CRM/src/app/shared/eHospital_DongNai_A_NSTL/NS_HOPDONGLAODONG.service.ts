import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_HOPDONGLAODONG } from './NS_HOPDONGLAODONG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_HOPDONGLAODONGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaHopdong', 'Soquyetdinh', 'NhanvienkyHD', 'MaNhanVien', 'LoaiHD', 'HDTuNgay', 'HDDenNgay', 'Ngayvaolam', 'ThuviecTuNgay', 'ThuviecDenNgay', 'Diadiemlamviec', 'ChucDanh', 'Chucvu', 'Congviecduocgiao', 'Thoigianlamviec', 'Trangthietbicungcap', 'Nguoidieuhanh', 'Phuongtiendilai', 'HinhThucTraLuong', 'Luongcanban', 'Bac', 'Ngach', 'Solantraluong', 'Ngaytraluong', 'CacPhucap', 'CheDoNangLuong', 'Baoholaodong', 'Songaynghiphep', 'BHXH', 'TienThuong', 'CheDoDaoTao', 'Thoathuankhac', 'BoiThuongViPham', 'NgayhieulucHD', 'NgayhethieulucHD', 'NoilamHD'];

    List: NS_HOPDONGLAODONG[] | undefined;
    ListFilter: NS_HOPDONGLAODONG[] | undefined;
    FormData!: NS_HOPDONGLAODONG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_HOPDONGLAODONG";
    }
}

