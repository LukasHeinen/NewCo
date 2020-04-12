import { Component, OnInit, Input } from "@angular/core";
import { Clicky } from "../models/clicky";

@Component({
  selector: "app-explore-container",
  templateUrl: "./explore-container.component.html",
  styleUrls: ["./explore-container.component.scss"],
})
export class ExploreContainerComponent implements OnInit {
  @Input() name: string;

  clickys: Clicky[] = [
    {
      headline: "Where is Paul?",
      image: "../../assets/images/Minions.png",
      user: {
        name: "Christina",
        avatar:
          "https://avatars2.githubusercontent.com/u/46488920?s=460&u=374bc781bf217bdda5f3764512fb643c55ce518d&v=4",
      },
    },
    {
      headline: "Where is Lukas?",
      image: "../../assets/images/Minions.png",
      user: {
        name: "Simon",
        avatar:
          "https://avatars3.githubusercontent.com/u/46029307?s=460&u=17325a4cfaf159c31128a56889b0b40db5b93500&v=4",
      },
    },
  ];

  constructor() {}

  ngOnInit() {}
}
