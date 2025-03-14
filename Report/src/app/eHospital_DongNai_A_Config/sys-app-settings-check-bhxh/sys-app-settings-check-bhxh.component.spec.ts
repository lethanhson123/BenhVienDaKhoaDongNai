import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysAppSettingsCheckBHXHComponent } from './sys-app-settings-check-bhxh.component';

describe('SysAppSettingsCheckBHXHComponent', () => {
  let component: SysAppSettingsCheckBHXHComponent;
  let fixture: ComponentFixture<SysAppSettingsCheckBHXHComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysAppSettingsCheckBHXHComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysAppSettingsCheckBHXHComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
