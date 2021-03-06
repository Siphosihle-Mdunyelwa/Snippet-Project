import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { StatchartComponent } from './statchart.component';

describe('StatchartComponent', () => {
  let component: StatchartComponent;
  let fixture: ComponentFixture<StatchartComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ StatchartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StatchartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
