import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSoComponent } from './goi-so.component';

describe('GoiSoComponent', () => {
  let component: GoiSoComponent;
  let fixture: ComponentFixture<GoiSoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
