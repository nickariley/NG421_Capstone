import { Component, OnInit } from '@angular/core';
import { IMovie } from '../interfaces/imovie';
import { MovieServiceService } from '../services/movie-service.service';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  public movieList: IMovie[];
  public newMovie: IMovie = {
    id: undefined,
    movieTitle: '',
    genre: '',
    releaseDate: null,
    watched: true
  };
  constructor(private movieService: MovieServiceService) { }

  async ngOnInit() {
    this.movieList = await this.movieService.getMovies();
  }

}
