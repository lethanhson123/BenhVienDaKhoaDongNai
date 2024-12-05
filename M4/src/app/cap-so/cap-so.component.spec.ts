import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CapSoComponent } from './cap-so.component';

describe('CapSoComponent', () => {
  let component: CapSoComponent;
  let fixture: ComponentFixture<CapSoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CapSoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CapSoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
