using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Visitor;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public class ShapeZ : IShape
    {

        List<Cell> temp = new List<Cell>();
        public Brush ShapeColor;
        public Cell lowestCell;
        public Cell highestCell;
        public int RotationPos;

        public ShapeZ()
        {
            FillShape();
            findLowestCell();
            findHighestCell();
            ShapeColor = Brushes.Purple;
            RotationPos = 12;
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
            temp.Add(new Cell(0, 0, Cell.CellType.Z));
            temp.Add(new Cell(0, 1, Cell.CellType.Z));
            temp.Add(new Cell(1, 1, Cell.CellType.Z));
            temp.Add(new Cell(1, 2, Cell.CellType.Z));
        }
        public Brush getColor()
        {
            return ShapeColor;
        }

        public void findLowestCell()
        {
            Cell tempCell = temp[0];
            foreach(Cell cell in temp)
            {
                if(cell.Y > tempCell.Y)
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

        public void accept(MoveLeft MoveLeft)
        {
            MoveLeft.visit(this);
        }

        public void accept(MoveRight MoveRight)
        {
            MoveRight.visit(this);
        }

        public void accept(RotateAt3 RotateAt3)
        {
            RotateAt3.visit(this);
        }

        public void setPos(int pos)
        {
            RotationPos = pos;
        }

        public int getPos()
        {
            return RotationPos;
        }

        public void accept(RotateAt6 RotateAt6)
        {
            RotateAt6.visit(this);
        }

        public void accept(RotateAt9 RotateAt9)
        {
            RotateAt9.visit(this);
        }

        public void accept(RotateAt12 RotateAt12)
        {
            RotateAt12.visit(this);
        }
    }
}
