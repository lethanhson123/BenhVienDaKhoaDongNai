import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSoInfoComponent } from './goi-so-info.component';

describe('GoiSoInfoComponent', () => {
  let component: GoiSoInfoComponent;
  let fixture: ComponentFixture<GoiSoInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSoInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSoInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
