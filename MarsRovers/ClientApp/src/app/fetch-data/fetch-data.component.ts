import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
    public rovers: Rover[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<Rover[]>(baseUrl + 'rover').subscribe(result => {
      this.rovers = result;
    }, error => console.error(error));
  }
    MapMars() {
        for (var rover of this.rovers) {
            console.log("Rover " + rover.instructions);

            for (var i = 0; i < rover.coordinates.length; i++) {

                var stringCoord = JSON.stringify(rover.coordinates[i]);
                var strcoord = stringCoord[5] + stringCoord[11];
                const canvasCoord = document.querySelector('#C' + strcoord) as HTMLElement;

                canvasCoord.textContent = "Rover " + rover.roverNumber
                setTimeout(() => {
                    canvasCoord.style.backgroundColor = '#b5f5c6'
                    setTimeout(() => {
                        canvasCoord.style.backgroundColor = '#50ad69'
                    }, 2000);
                }, 2000);
            }
        }
    }
}

interface Rover {
    roverNumber: number;
    instructions: string;
    coordinates: Coordinates[];
}

interface Coordinates {
    x: number;
    y: number;
    Direction: string;
}
