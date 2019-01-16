import { Component, OnInit } from '@angular/core';
import { AuthorService } from '../../services/author.service';

@Component({
  selector: 'app-author',
  templateUrl: './author.component.html',
  styleUrls: ['./author.component.scss']
})
export class AuthorComponent implements OnInit {

  constructor(private authorService: AuthorService) { }

  authors: any;

  ngOnInit() {
    console.log("Authors Log");

    this.authorService.getAuthors().subscribe(val => console.log(val));
    this.authorService.getAuthors().subscribe(val => this.authors = val);
  }
}
