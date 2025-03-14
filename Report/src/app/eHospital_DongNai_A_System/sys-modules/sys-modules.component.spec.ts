import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysModulesComponent } from './sys-modules.component';

describe('SysModulesComponent', () => {
  let component: SysModulesComponent;
  let fixture: ComponentFixture<SysModulesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysModulesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysModulesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
