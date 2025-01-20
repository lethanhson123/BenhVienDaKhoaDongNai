import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysParametersComponent } from './sys-parameters.component';

describe('SysParametersComponent', () => {
  let component: SysParametersComponent;
  let fixture: ComponentFixture<SysParametersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysParametersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SysParametersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
