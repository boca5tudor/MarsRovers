# MarsRovers

MarsRovers is a simple app that maps a 2D surface 

The app was developed with Visual Studio 2019 using the .NET libraries and an Angular template for the front end.
Due to the changes to Office 365 the movements.csv file has turned into Movements.txt, the logic behind reading from the file is the same.
MarsRovers took about 3-4 hours to complete

The app displays a 2D space and divides it into coordinates and the four cardinal compass points,
each division of the canvas will be mapped based on a set of instructions that are added to the Movements.txt file found in the Data directory

Each line in the Movements.txt file represents an independent rover, these lines are then split by a pipe, 
on the left of the pipe is the rover starting position and on the right of the pipe is the rover's movements.
Eg: 12N|LMLMLMLMM

The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 
'M' means move forward one grid point and maintain the same heading


![MarsRovers1](https://user-images.githubusercontent.com/14928563/200193616-18f2e9dc-5a2a-4788-a1e8-708356a80e47.PNG)
