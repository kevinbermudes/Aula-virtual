import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Tareas} from "../models/tareas";


@Injectable({
  providedIn:'root'
})


export class TareasService {
  private api= 'http://localhost:5151/api/tarea1';
  constructor(private httpClient: HttpClient) {
  }
  getTareas():Observable<Tareas[]>{
    return this.httpClient.get<Tareas[]>(this.api)
  }
}
