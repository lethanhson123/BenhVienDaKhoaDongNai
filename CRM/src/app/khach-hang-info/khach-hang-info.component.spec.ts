import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhachHangInfoComponent } from './khach-hang-info.component';

describe('KhachHangInfoComponent', () => {
  let component: KhachHangInfoComponent;
  let fixture: ComponentFixture<KhachHangInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhachHangInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhachHangInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
