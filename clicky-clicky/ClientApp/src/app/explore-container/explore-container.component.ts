import { Component, OnInit, Input } from "@angular/core";
import { Survey } from "../models/clicky";

@Component({
  selector: "app-explore-container",
  templateUrl: "./explore-container.component.html",
  styleUrls: ["./explore-container.component.scss"],
})
export class ExploreContainerComponent implements OnInit {
  @Input() name: string;

  surveys: Survey[] = [
    {
      question: "Where is Paul?",
      imageUrl: "../../assets/images/Minions.png",
      id: "2",
      creatorName: "Admin",
    },
    {
      question: "Where is Lukas?",
      imageUrl: "../../assets/images/Minions.png",
      id: "1",
      creatorName: "Admin",
    },
  ];

  constructor() {}

  ngOnInit() {}
}
