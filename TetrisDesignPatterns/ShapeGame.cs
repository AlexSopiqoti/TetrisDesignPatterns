using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisDesignPatterns.Abstract_Factory;
using TetrisDesignPatterns.State;

namespace TetrisDesignPatterns
{
    public partial class ShapeGame : Form
    {
        Context context = new Context();
        GameStarted gameStarted = new GameStarted();
        GameStopped gameStopped = new GameStopped();
        GameReset gameReset = new GameReset();
        GameOver gameOver = new GameOver();
        AbstractFactory shapeFactory;
        Shape shape;

        int score = 0;

        Board board;        
        List<Shape> shapesInTheBottom;

        Random rnd = new Random();

        public ShapeGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initGame();
        }

        private void initGame()
        {            
            board = new Board();
            shapeFactory = FactoryProducer.getFactory();
            shape = shapeFactory.getShape(3);
            shapesInTheBottom = new List<Shape>();
            timerAni.Enabled = false;
            if (context.getState() == gameReset)
            {
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < board.width; i++)
            {
                for (int j = 0; j < board.height; j++)
                {
                    g.DrawRectangle(new Pen(System.Drawing.Color.Silver), this.board.board[i, j].X * 30, this.board.board[i, j].Y * 30, 30, 30);

                    if (context.getState() != gameOver)
                    {
                        if (shape != null)
                        {
                            g.FillRectangle(shape.getColor(), shape.draw()[0].X * 30, shape.draw()[0].Y * 30, 30, 30);
                            g.FillRectangle(shape.getColor(), shape.draw()[1].X * 30, shape.draw()[1].Y * 30, 30, 30);
                            g.FillRectangle(shape.getColor(), shape.draw()[2].X * 30, shape.draw()[2].Y * 30, 30, 30);
                            g.FillRectangle(shape.getColor(), shape.draw()[3].X * 30, shape.draw()[3].Y * 30, 30, 30);
                        }
                        foreach (Shape shape in shapesInTheBottom)
                        {
                            foreach (Cell cell in shape.draw())
                            {
                                board.board[cell.X, cell.Y].type = Cell.CellType.Busy;
                                g.FillRectangle(shape.getColor(), cell.X * 30, cell.Y * 30, 30, 30);
                            }
                        }
                    }
                    
                }
            }
        }

        private void timerAni_Tick(object sender, EventArgs e)
        {
            shape.update();
            if (shape.getLowestCell().Y > 18) 
            {
                shapesInTheBottom.Add(shape);
                shape = shapeFactory.getShape(3);
            }
            else if(board.board[shape.getLowestCell().X, shape.getLowestCell().Y + 1].type == Cell.CellType.Busy)
            {                
                shapesInTheBottom.Add(shape);
                shape = shapeFactory.getShape(rnd.Next(1, 6));
            }
            
            foreach (Cell cell in shape.draw())
            {
                if (board.board[cell.X, cell.Y + 1].type == Cell.CellType.Busy)
                {
                    shapesInTheBottom.Add(shape);
                    shape = shapeFactory.getShape(3);
                    break;
                }
            }
            foreach(Shape tempShape in shapesInTheBottom)
            {
                foreach(Cell cell in tempShape.draw())
                {
                    if(cell.Y < 1)
                    {
                        gameOver.doAction(context, timerAni, labelState);
                    }
                }

            }
            int row = 9;   //check fourth row
            bool isFilled = true;
            for (var col = 0; col < 20; col++)
            {
                if (board.board[row, col].type != Cell.CellType.Busy)
                {
                    isFilled = false;
                }
            }
            if (isFilled)
            {
                Console.WriteLine("WORKS");
            }


            pictureBox1.Invalidate();
        }

        public void checkForLines()
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (context.getState() == null || context.getState() == gameReset || context.getState() == gameStopped)
            {
                gameStarted.doAction(context, timerAni, labelState);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(context.getState() == gameStarted)
            {
                gameStopped.doAction(context, timerAni, labelState);
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            gameReset.doAction(context, timerAni, labelState);
            initGame();
        }

        private void buttonStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'd' && canMoveRight(shape))
            {
                shape.accept(new Visitor.MoveRight());
            }
            else if(e.KeyChar == 'a' && canMoveLeft(shape))
            {
                shape.accept(new Visitor.MoveLeft());
            } 
            else if(e.KeyChar == 'r' && canRotate(shape))
            {
                if(shape.getPos() == 12)
                {
                    shape.accept(new Visitor.RotateAt3());
                }
                else if(shape.getPos() == 3)
                {
                    shape.accept(new Visitor.RotateAt6());
                }
                else if (shape.getPos() == 6)
                {
                    shape.accept(new Visitor.RotateAt9());
                }
                else if (shape.getPos() == 9)
                {
                    shape.accept(new Visitor.RotateAt12());
                }

            }
        }

        private bool canRotate(Shape shape)
        {
            foreach (Cell cell in shape.draw())
            {
                if (cell.X + 1 > 9 || cell.X - 1 < 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool canMoveRight(Shape shape)
        {
            foreach(Cell cell in shape.draw())
            {
                if (cell.X + 1 > 9)
                {
                    return false;
                }
            }
            return true;
        }

        private bool canMoveLeft(Shape shape)
        {
            foreach (Cell cell in shape.draw())
            {
                if (cell.X - 1 < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
