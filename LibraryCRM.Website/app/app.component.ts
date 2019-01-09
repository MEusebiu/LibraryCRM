import { Component } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router'

@Component({
  selector: 'my-app',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent  {
    currentUrl: string;

    //Routing adress
    constructor(private router: Router) {
        this.router.events.subscribe((event) => {
            if (event instanceof NavigationEnd) {
                this.currentUrl = event.url;
            }
        })
    }
}
