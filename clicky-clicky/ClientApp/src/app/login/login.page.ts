import { Component, OnInit, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { AccountService } from "../services/account.service";
import { Subscription } from "rxjs";

@Component({
  selector: "app-login",
  templateUrl: "./login.page.html",
  styleUrls: ["./login.page.scss"],
})
export class LoginPage implements OnInit {
  isUserAuthenticated = false;
  subscription: Subscription;
  userName: string;
  private baseUrl: string;

  constructor(
    @Inject("BASE_URL") baseUrl: string,
    private httpClient: HttpClient,
    private accountService: AccountService
  ) {
    this.baseUrl = baseUrl + "home/";
  }

  ngOnInit() {
    this.subscription = this.accountService.isUserAuthenticated.subscribe(
      (isAuthenticated) => {
        this.isUserAuthenticated = isAuthenticated;
        if (this.isUserAuthenticated) {
          this.httpClient
            .get(this.baseUrl + "name", {
              responseType: "text",
              withCredentials: true,
            })
            .subscribe((theName) => {
              this.userName = theName;
            });
        }
      }
    );
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  logout() {
    this.accountService.logout();
  }

  simulateFailedCall() {
    this.httpClient.get(this.baseUrl + "fail").subscribe();
  }

  login() {
    this.accountService.login();
  }
}
