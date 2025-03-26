import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysAppSettingsCheckKeToanComponent } from './sys-app-settings-check-ke-toan.component';

describe('SysAppSettingsCheckKeToanComponent', () => {
  let component: SysAppSettingsCheckKeToanComponent;
  let fixture: ComponentFixture<SysAppSettingsCheckKeToanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysAppSettingsCheckKeToanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysAppSettingsCheckKeToanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
