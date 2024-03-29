import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable } from 'rxjs/internal/Observable';
import { User } from '../_models/User';
import { of } from 'rxjs';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit{

  model: any = {}

  constructor(public accountService: AccountService) { }

  ngOnInit(): void {

  }

  login() {
    this.accountService.login(this.model).subscribe({
      next: (response: any) => {
        console.log(response);
      },
      error: error => console.log(error)
    })
  }

  logout() {
    this.accountService.logout();
  }

}
