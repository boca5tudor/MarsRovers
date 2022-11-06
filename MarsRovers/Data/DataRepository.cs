using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRovers.Data
{
    public class DataRepository: IDataRepository
    {
        public DataRepository()
        {

        }

        public IEnumerable<Rover> GetInstructions()
        {
            int rovernumber = 0;
            List<Rover> rovers = new List<Rover>();

            string path = Directory.GetCurrentDirectory() + "\\Data\\Movements.txt";
            var fileInstructions = File.ReadLines(path.Replace(@"\\", @"\"));
            foreach (var row in fileInstructions)
            {
                int x = int.Parse(row[0].ToString());
                int y = int.Parse(row[1].ToString());
                string direction = row[2].ToString();
                List<Coordinates> positions = new List<Coordinates>();
                Coordinates coordinates = new Coordinates { X = x, Y = y, Direction = direction };
                positions.Add(coordinates);            

                for (int i = 4; i < row.Length; i++)
                {
                    string newdirection = "";

                    if (row[i].ToString() == "M")
                    {
                        if (direction == "N")
                        {
                            y++;
                            positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                            newdirection = direction;
                        }
                        if (direction == "E")
                        {
                            x++;
                            positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                            newdirection = direction;
                        }
                        if (direction == "S")
                        {
                            y--;
                            positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                            newdirection = direction;
                        }
                        if (direction == "W")
                        {
                            x--;
                            positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                            newdirection = direction;
                        }
                    }

                    if (row[i].ToString() == "L" && direction == "N")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "W";
                    }
                    if (row[i].ToString() == "L" && direction == "E")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "N";
                    }
                    if (row[i].ToString() == "L" && direction == "S")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "E";
                    }
                    if (row[i].ToString() == "L" && direction == "W")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "S";
                    }

                    if (row[i].ToString() == "R" && direction == "N")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "E";
                    }
                    if (row[i].ToString() == "R" && direction == "E")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "S";
                    }
                    if (row[i].ToString() == "R" && direction == "S")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "W";
                    }
                    if (row[i].ToString() == "R" && direction == "W")
                    {
                        positions.Add(new Coordinates { X = x, Y = y, Direction = direction });
                        newdirection = "N";
                    }

                    direction = newdirection;
                }
                rovernumber++;
                Rover rover = new Rover
                {
                    RoverNumber = rovernumber,
                    Instructions = row,
                    coordinates = positions
                };
                rovers.Add(rover);
            }

            return rovers;
        }
    }
}
