import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "app-tab3",
  templateUrl: "tab3.page.html",
  styleUrls: ["tab3.page.scss"],
})
export class Tab3Page implements OnInit {
  public forecasts: WeatherForecast[];
  private baseUrl: string;
  private httpClient: HttpClient;

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.httpClient = http;
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    this.httpClient
      .get<WeatherForecast[]>(this.baseUrl + "weatherforecast")
      .subscribe(
        (result) => {
          this.forecasts = result;
        },
        (error) => console.error(error)
      );
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
