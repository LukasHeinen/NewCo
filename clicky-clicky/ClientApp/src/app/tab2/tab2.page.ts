import { Component } from "@angular/core";

@Component({
  selector: "app-tab2",
  templateUrl: "tab2.page.html",
  styleUrls: ["tab2.page.scss"],
})
export class Tab2Page {
  displayRing = false;
  constructor() {}

  getRelativePositionInPercent(event: MouseEvent) {
    this.displayRing = true;
    const target = event.target as HTMLTextAreaElement;
    const rect = target.getBoundingClientRect();
    const xPercent = (event.clientX - rect.left) / rect.width;
    const yPercent = (event.clientY - rect.top) / rect.height;
    console.log(xPercent, yPercent);
    const root = document.documentElement;
    root.style.setProperty("--circle-x", event.clientX - rect.left + "px");
    root.style.setProperty("--circle-y", event.clientY - rect.top + "px");
  }
}
