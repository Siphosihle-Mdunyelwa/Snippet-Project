import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { Profile4Component } from './profile4.component';

describe('Profile4Component', () => {
  let component: Profile4Component;
  let fixture: ComponentFixture<Profile4Component>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ Profile4Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Profile4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
