import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http'; 

//My components
import { BookComponent } from './components/book/book.component';
import { AuthorComponent } from './components/author/author.component';
import { HomeComponent } from './components/home/home.component';
import { HeaderComponent } from './components/header/header.component';

//My services
import { AuthorService } from './services/author.service';
import { BookService } from './services/book.service';

@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    AuthorComponent,
    HomeComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [BookService, AuthorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
