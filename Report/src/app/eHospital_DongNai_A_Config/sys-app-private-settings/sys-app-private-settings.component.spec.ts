import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysAppPrivateSettingsComponent } from './sys-app-private-settings.component';

describe('SysAppPrivateSettingsComponent', () => {
  let component: SysAppPrivateSettingsComponent;
  let fixture: ComponentFixture<SysAppPrivateSettingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysAppPrivateSettingsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysAppPrivateSettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
