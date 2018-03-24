import { UserInfo } from './../../models/userInfo';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {

  userInfo: UserInfo = {
    employed: false,
    workAddress: '',
    ableToWork: false,
    numberOfChildren: 0,
    transportation: false,
    liveWithSpouse: false,
    spouseCar: false,
    race: '',
    annualIncome: 0,
    medicalConitions: false
  };

  constructor() { }

  ngOnInit() {
  }

  submit() {

  }
}
