import { Component, OnInit } from '@angular/core';
import {  HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltrados: any = [];
  widthImg: number = 150;
  marginImg: number = 2;
  mostrarImagem: boolean = true;
  private _filtrolista: string = '';

  public get filtrolista(): string {
   return this._filtrolista;
  }

  public set filtrolista(value: string) {
        this._filtrolista = value;
        this.eventosFiltrados = this.filtrolista ? this.filtrarEventos(this.filtrolista) : this.eventos;
  }

  filtrarEventos (filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.eventos.filter(
          (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
           evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
        )
  }



  alterarImagem() {
    this.mostrarImagem = !this.mostrarImagem
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => {
      this.eventos = response;
      this.eventosFiltrados = this.eventos;
      },
      error => console.log(error)

    );
  }
}

