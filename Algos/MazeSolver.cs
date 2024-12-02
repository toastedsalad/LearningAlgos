using System.Collections.Generic;
using System.Drawing;

namespace LearningAlgos;

public static class MazeSolver {

    private static int[][] dir = new int[][] {
        new[] {-1, 0},
        new[] {1, 0},
        new[] {0, -1},
        new[] {0, 1}
    };

    public static bool Walk(string[][] maze, 
                            string wall, 
                            Point current, 
                            Point end, 
                            bool[][] seen,
                            Stack<Point> path) {
        
        // Base Case
        // 1. off the map
        if (current.X < 0 || current.X >= maze[0].Length ||
            current.Y < 0 || current.Y >= maze.Length) {

            return false;
        }

        // 2. it's a wall
        if (maze[current.Y][current.X] == wall) {
            return false;
        }

        // 3. it's the end
        if (current.X == end.X && current.Y == end.Y) {
            // push the ending tyle into the stack
            path.Push(end);
            return true;
        }

        // 4. we've seen it 
        if (seen[current.Y][current.X]) {
            return false;
        }

        // 3 recursion stages:
        // pre
        // every time we succesfully visit a spot we will add it to path as the pre condition
        seen[current.Y][current.X] = true;
        path.Push(current);

        // recurse
        for (var i = 0; i < dir.Length; i++) {
            var position = dir[i];
            var currentPos = new Point(current.X + position[0], current.Y + position[1]);
            var walkResult = Walk(maze, wall, currentPos, end, seen, path);

            if (walkResult) {
                return true;
            } 
        }

        // post
        // then we remove the spot in the post condition.
        // okay i get it now. 
        // recursions are dope.
        path.Pop();
        return false;
    }

    public static Stack<Point> Solve(string[][] maze, string wall, Point start, Point end) {
        var seen = new bool[maze.Length][];
        var path = new Stack<Point>();

        for (var i = 0; i < maze.Length; i++) {
            // This array should set everything to false automagically
            seen[i] = new bool[maze[i].Length];
        }

        Walk(maze, wall, start, end, seen, path);

        return path;
    }
}
