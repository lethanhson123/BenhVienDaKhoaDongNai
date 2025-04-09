import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMPhongBanThongKeComponent } from './dm-phong-ban-thong-ke.component';

describe('DMPhongBanThongKeComponent', () => {
  let component: DMPhongBanThongKeComponent;
  let fixture: ComponentFixture<DMPhongBanThongKeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMPhongBanThongKeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMPhongBanThongKeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
