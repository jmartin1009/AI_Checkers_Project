using System;
using System.Collections.Generic;

namespace AICheckers {
    public class Node {
        public const char BLACK = '1';
        public const char WHITE = '2';
        public const char EMPTY = '0';

        public char[] Tiles { get; private set; }
        public int Depth { get; private set; }
        
        public Node(char[] tiles) {
            Tiles = tiles;
            Depth = 0;
        }
        public Node(Node n) {
            Tiles = new char[n.Tiles.Length];
            Array.Copy(n.Tiles, Tiles, n.Tiles.Length);
            Depth = n.Depth + 1;
        }

        // Simple heuristic for right now, just returns the difference in number of pieces.
        public int GetHeuristic(bool forBlack) {
            int numBlackPieces = getCoordsOfFilledSpots(BLACK).Length;
            int numWhitePieces = getCoordsOfFilledSpots(WHITE).Length;

            if (forBlack) {
                if (numWhitePieces == 0) {
                    return int.MaxValue;
                }
                if (numBlackPieces == 0) {
                    return int.MinValue;
                }
            } else {
                if (numWhitePieces == 0) {
                    return int.MinValue;
                }
                if (numBlackPieces == 0) {
                    return int.MaxValue;
                }
            }

            if (forBlack) return numBlackPieces - numWhitePieces;
            else return numWhitePieces - numBlackPieces;
        }

        public List<Node> GetChildren(bool isBlackTurn) {
            List<Node> children = new List<Node>();

            foreach (var coord in getCoordsOfFilledSpots(isBlackTurn ? BLACK : WHITE)) {
                if (isBlackTurn) {
                    Node child1 = new Node(this);
                    if (child1.Move(MoveDirection.NORTH_EAST, coord.Item1, coord.Item2)) {
                        children.Add(child1);
                    }
                    Node child2 = new Node(this);
                    if (child2.Move(MoveDirection.NORTH_WEST, coord.Item1, coord.Item2)) {
                        children.Add(child2);
                    }
                }
                else {
                    Node child1 = new Node(this);
                    if (child1.Move(MoveDirection.SOUTH_EAST, coord.Item1, coord.Item2)) {
                        children.Add(child1);
                    }
                    Node child2 = new Node(this);
                    if (child2.Move(MoveDirection.SOUTH_WEST, coord.Item1, coord.Item2)) {
                        children.Add(child2);
                    }
                }
            }

            return children;
        }

        private (int, int)[] getCoordsOfFilledSpots(char marker) {
            List<(int, int)> res = new List<(int, int)>();

            for (int x = 1; x <= 8; x++)
                for (int y = 1; y <= 8; y++)
                    if (tile(x, y) == marker)
                        res.Add((x, y));

            return res.ToArray();
        }

        public bool Move(MoveDirection direction, int x, int y, bool allowedToMoveOnce = true) {
            char marker = tile(x, y);
            List<(int, int)> enemiesJumped = new List<(int, int)>();

            int originalX = x;
            int originalY = y;

            while (moveCondition(direction, ref x, ref y)) {
                // Once we've moved to an empty space this move is basically over.
                if (tile(x, y) == EMPTY) {
                    if (!allowedToMoveOnce && enemiesJumped.Count == 0) return false;
                    tile(x, y, marker);
                    // Actually capture the enemies.
                    foreach (var coord in enemiesJumped) {
                        tile(coord.Item1, coord.Item2, EMPTY);
                    }

                    if (enemiesJumped.Count > 0) {
                        // Try to get a killstreak in every direction
                        if (!Move(MoveDirection.NORTH_EAST, x, y, false))
                            if (!Move(MoveDirection.NORTH_WEST, x, y, false))
                                if (!Move(MoveDirection.SOUTH_EAST, x, y, false))
                                    Move(MoveDirection.SOUTH_WEST, x, y, false);
                    }

                    // clear the original tile
                    tile(originalX, originalY, EMPTY);
                    return true;
                } 
                // If we run into one of our own pieces this move is invalid.
                else if (tile(x, y) == marker) return false;
                // enemy piece, add it to the list.
                else enemiesJumped.Add((x, y));
            }
            // Exceeded the bounds of the board, invalid move.
            return false;
        }

        private bool moveCondition(MoveDirection direction, ref int x, ref int y) {
            switch (direction) {
                case MoveDirection.NORTH_EAST:
                    return ++x <= 8 && --y >= 1;
                case MoveDirection.NORTH_WEST:
                    return --x >= 1 && --y >= 1;
                case MoveDirection.SOUTH_EAST:
                    return ++x <= 8 && ++y <= 8;
                case MoveDirection.SOUTH_WEST:
                    return --x >= 1 && ++y <= 8;
            }

            return false;
        }

        private char tile(int x, int y) {
            x -= 1;
            y -= 1;

            return Tiles[(y * 8) + x];
        }

        private void tile(int x, int y, char v) {
            x -= 1;
            y -= 1;

            Tiles[(y * 8) + x] = v;
        }
    }
}
