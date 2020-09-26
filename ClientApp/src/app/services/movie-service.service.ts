import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { IMovie } from '../interfaces/imovie';

@Injectable({
  providedIn: 'root'
})
export class MovieServiceService {

  constructor(private httpClient: HttpClient, @Inject('BASE_URL')private baseUrl: string) { }

  public async getMovies(): Promise<IMovie[]> {
    // why does this have to be the name of the controller? movie works but nothing else
    return this.httpClient.get<IMovie[]>(`${this.baseUrl}movie`).toPromise();
  }

  public async addMovie(movie: IMovie): Promise<IMovie> {
    return this.httpClient.post<IMovie>(`${this.baseUrl}movie`, movie).toPromise();
  }
}
