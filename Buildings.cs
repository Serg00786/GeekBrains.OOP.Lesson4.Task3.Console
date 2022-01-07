using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.Lesson4.Task1
{

    class Buildings
    {
        private int BuildingNumber;
        private double Height;
        private int Floor;
        private int FlatsNumber;
        private int EntranceNumber;
        const int FlatsInFloors = 5;
        private static int LastBuildingNumber;

        public Buildings(string n)
        {
            Console.WriteLine(n);
        }

        public int GetBuildingNumber()
        {
            BuildingNumber = LastBuildingNumber + 1;
            return BuildingNumber;
        }

        public double GetHeight()
        {
            return Height;
        }

        public int GetFloor()
        {
            return Floor;
        }

        public int GetFlatsNumber()
        {
            return FlatsNumber;
        }
        public int GetEntranceNumber()
        {
            return EntranceNumber;
        }
        public int SetBuildingNumber(int value)
        {
            return BuildingNumber = value;
        }

        public double SetHeight(double value)
        {
            return Height = value;
        }

        public int SetFloor(int value)
        {
            return Floor = value;
        }
        public int SetFlatsNumber(int value)
        {
            return FlatsNumber = value;
        }

        public int SetEntranceNumber(int value)
        {
            return EntranceNumber = value;
        }
        public double CalculateFloorHeight(double Height, int Floor)
        {
            return Height * Floor;
        }

        public int CalculateFlatsInEntrance(int Floors)
        {
            return Floors * FlatsInFloors;
        }
        public int GetFlatsinFloor()
        {
            return FlatsInFloors;
        }

        //public override Buildings Create()
        //{
        //    return new Buildings("House Created");
        //}
    }
}
