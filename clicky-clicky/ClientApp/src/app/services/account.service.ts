import { Injectable, Inject } from "@angular/core";
import { BehaviorSubject, Observable } from "rxjs";
import { DOCUMENT } from "@angular/common";
import { HttpClient } from "@angular/common/http";
import { tap } from "rxjs/operators";

@Injectable({
  providedIn: "root",
})
export class AccountService {
  private _isUserAuthenticatedSubject = new BehaviorSubject<boolean>(false);
  isUserAuthenticated: Observable<
    boolean
  > = this._isUserAuthenticatedSubject.asObservable();
  private baseUrl: string;

  constructor(
    @Inject(DOCUMENT) private document: Document,
    @Inject("BASE_URL") baseUrl: string,

    private httpClient: HttpClient
  ) {
    this.baseUrl = baseUrl;
  }

  updateUserAuthenticationStatus() {
    return this.httpClient
      .get<boolean>(this.baseUrl + "home/isAuthenticated", {
        withCredentials: true,
      })
      .pipe(
        tap((isAuthenticated) => {
          this._isUserAuthenticatedSubject.next(isAuthenticated);
        })
      );
  }

  setUserAsNotAuthenticated() {
    this._isUserAuthenticatedSubject.next(false);
  }

  login() {
    this.document.location.href = this.baseUrl + "account/SignInWithGoogle";
  }

  logout() {
    this.document.location.href = this.baseUrl + "account/logout";
  }
}
