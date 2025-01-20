import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysGroupsComponent } from './sys-groups.component';

describe('SysGroupsComponent', () => {
  let component: SysGroupsComponent;
  let fixture: ComponentFixture<SysGroupsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysGroupsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysGroupsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
