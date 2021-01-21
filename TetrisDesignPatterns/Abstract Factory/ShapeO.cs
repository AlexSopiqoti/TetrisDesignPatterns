﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public class ShapeO : Shape
    {
        List<Cell> temp = new List<Cell>();
        public Brush ShapeColor;
        public Cell lowestCell;
        public Cell highestCell;

        public ShapeO()
        {
            FillShape();
            findLowestCell();
            findHighestCell();
            ShapeColor = Brushes.Red;
        }

        public List<Cell> draw()
        {
            return temp;
        }

        public void update()
        {
            temp[0].Y++;
            temp[1].Y++;
            temp[2].Y++;
            temp[3].Y++;
        }

        public void FillShape()
        {
            temp.Add(new Cell(0, 0, Cell.CellType.O));
            temp.Add(new Cell(1, 0, Cell.CellType.O));
            temp.Add(new Cell(0, 1, Cell.CellType.O));
            temp.Add(new Cell(1, 1, Cell.CellType.O));
        }
        public Brush getColor()
        {
            return ShapeColor;
        }

        public void findLowestCell()
        {
            Cell tempCell = temp[0];
            foreach (Cell cell in temp)
            {
                if (cell.Y > tempCell.Y)
                {
                    tempCell = cell;
                }
            }
            lowestCell = tempCell;

        }

        
        public Cell getLowestCell()
        {
            return lowestCell;
        }

        public void findHighestCell()
        {
            Cell tempCell = temp[0];
            foreach (Cell cell in temp)
            {
                if (cell.Y < tempCell.Y)
                {
                    tempCell = cell;
                }
            }
            highestCell = tempCell;

        }
        public Cell getHighestCell()
        {
            return highestCell;
        }
    }
}