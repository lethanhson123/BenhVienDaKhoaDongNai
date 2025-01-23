import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysUserCommandsComponent } from './sys-user-commands.component';

describe('SysUserCommandsComponent', () => {
  let component: SysUserCommandsComponent;
  let fixture: ComponentFixture<SysUserCommandsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysUserCommandsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysUserCommandsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
