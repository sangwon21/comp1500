using System;

namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            char[,] ans = new char[height + 4, width + 4];

            if (width == 0 || height == 0)
            {
                return new char[0, 0];
            }
            if (shape == EShape.Rectangle)
            {
                // 맨 위 아래 -
                for (uint j = 0; j < width + 4; j++)
                {
                    ans[0, j] = '-';
                    ans[height + 3, j] = '-';
                }

                for (uint j = 0; j < width + 4; j++)
                {
                    if (j == 0 || j == width + 3)
                    {
                        ans[1, j] = '|';
                        ans[height + 2, j] = '|';
                    }
                    else
                    {
                        ans[1, j] = ' ';
                        ans[height + 2, j] = ' ';
                    }
                }

                for (uint i = 2; i < height + 2; i++)
                {
                    for (uint j = 0; j < width + 4; j++)
                    {
                        if ((j == 0 || j == width + 3))
                        {
                            ans[i, j] = '|';
                        }
                        else if (j == 1 || j == width + 2)
                        {
                            ans[i, j] = ' ';
                        }
                        else
                        {
                            ans[i, j] = '*';
                        }

                    }
                }
            }
            else if (shape == EShape.IsoscelesRightTriangle)
            {
                if (width != height)
                {
                    return new char[0, 0];
                }
                // 맨 위 아래 -
                for (uint j = 0; j < width + 4; j++)
                {
                    ans[0, j] = '-';
                    ans[height + 3, j] = '-';
                }

                for (uint j = 0; j < width + 4; j++)
                {
                    if (j == 0 || j == width + 3)
                    {
                        ans[1, j] = '|';
                        ans[height + 2, j] = '|';
                    }
                    else
                    {
                        ans[1, j] = ' ';
                        ans[height + 2, j] = ' ';
                    }
                }

                for (uint i = 2; i < height + 2; i++)
                {
                    for (uint j = 0; j < width + 4; j++)
                    {
                        if ((j == 0 || j == width + 3))
                        {
                            ans[i, j] = '|';
                        }
                        else if (j == 1 || j == width + 2)
                        {
                            ans[i, j] = ' ';
                        }
                        else
                        {
                            if (j - 2 < i - 1)
                            {
                                ans[i, j] = '*';
                            }
                            else
                            {
                                ans[i, j] = ' ';
                            }
                        }

                    }
                }
            }
            else if (shape == EShape.IsoscelesTriangle)
            {
                if (width != height * 2 - 1)
                {
                    return new char[0, 0];
                }

                // 맨 위 아래 -
                for (uint j = 0; j < width + 4; j++)
                {
                    ans[0, j] = '-';
                    ans[height + 3, j] = '-';
                }

                for (uint j = 0; j < width + 4; j++)
                {
                    if (j == 0 || j == width + 3)
                    {
                        ans[1, j] = '|';
                        ans[height + 2, j] = '|';
                    }
                    else
                    {
                        ans[1, j] = ' ';
                        ans[height + 2, j] = ' ';
                    }
                }

                for (uint i = 2; i < height + 2; i++)
                {
                    for (uint j = 0; j < width + 4; j++)
                    {
                        if ((j == 0 || j == width + 3))
                        {
                            ans[i, j] = '|';
                        }
                        else if (j == 1 || j == width + 2)
                        {
                            ans[i, j] = ' ';
                        }
                        else
                        {
                            if (j - 2 < height - i + 1 || j - 2 >= width - (height - i + 1))
                            {
                                ans[i, j] = ' ';
                            }
                            else
                            {
                                ans[i, j] = '*';
                            }
                        }

                    }
                }
            }
            else if (shape == EShape.Circle)
            {
                if (width % 2 == 0 || width != height)
                {
                    return new char[0, 0];
                }

                // 맨 위 아래 -
                for (uint j = 0; j < width + 4; j++)
                {
                    ans[0, j] = '-';
                    ans[height + 3, j] = '-';
                }

                for (uint j = 0; j < width + 4; j++)
                {
                    if (j == 0 || j == width + 3)
                    {
                        ans[1, j] = '|';
                        ans[height + 2, j] = '|';
                    }
                    else
                    {
                        ans[1, j] = ' ';
                        ans[height + 2, j] = ' ';
                    }
                }

                for (uint i = 2; i < height + 2; i++)
                {
                    for (uint j = 0; j < width + 4; j++)
                    {
                        if ((j == 0 || j == width + 3))
                        {
                            ans[i, j] = '|';
                        }
                        else if (j == 1 || j == width + 2)
                        {
                            ans[i, j] = ' ';
                        }
                        else
                        {
                            uint radius = (uint)(height / 2);
                            if (radius * radius >= (radius - i + 2) * (radius - i + 2) + (radius - j + 2) * (radius - j + 2))
                            {
                                ans[i, j] = '*';
                            }
                            else
                            {
                                ans[i, j] = ' ';
                            }
                        }

                    }
                }
            }
            return ans;
        }

        public static bool IsShape(char[,] canvas, EShape shape)
        {
            if (canvas.GetLength(0) <= 4 || canvas.GetLength(1) <= 4)
            {
                return false;
            }

            uint row = (uint)canvas.GetLength(0);
            uint column = (uint)canvas.GetLength(1);

            char[,] compareShape = Draw(column - 4, row - 4, shape);

            if (row != (uint)compareShape.GetLength(0) || column != (uint)compareShape.GetLength(1))
            {
                return false;
            }

            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    if (compareShape[i, j] != canvas[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}