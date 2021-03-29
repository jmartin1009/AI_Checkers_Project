using System;
using System.Collections.Generic;

namespace AICheckers {
    public class Node {
        public const char BLACK = '1';
        public const char WHITE = '2';
        public const char EMPTY = '0';

        public char[] Tiles { get; private set; }
        
        public Node(char[] tiles) {
            this.Tiles = tiles;
        }
        public Node(Node n) {
            Tiles = new char[n.Tiles.Length];
            Array.Copy(n.Tiles, Tiles, n.Tiles.Length);
        }

        // Simple heuristic for right now, just returns the difference in number of pieces.
        public int GetHeuristic(bool forBlack) {
            int numBlackPieces = getCoordsOfFilledSpots(BLACK).Length;
            int numWhitePieces = getCoordsOfFilledSpots(WHITE).Length;

            if (forBlack) return numBlackPieces - numWhitePieces;
            else return numWhitePieces - numBlackPieces;
        }

        public List<Node> GetChildren(bool isBlackTurn) {
            List<Node> children = new List<Node>();

            foreach (var coord in getCoordsOfFilledSpots(isBlackTurn ? BLACK : WHITE)) {
                if (isBlackTurn) {
                    Node child1 = new Node(this);
                    if (child1.move(MoveDirection.SOUTH_EAST, coord.Item1, coord.Item2)) {
                        children.Add(child1);
                    }
                    Node child2 = new Node(this);
                    if (child2.move(MoveDirection.SOUTH_WEST, coord.Item1, coord.Item2)) {
                        children.Add(child2);
                    }
                }
                else {
                    Node child1 = new Node(this);
                    if (child1.move(MoveDirection.NORTH_EAST, coord.Item1, coord.Item2)) {
                        children.Add(child1);
                    }
                    Node child2 = new Node(this);
                    if (child2.move(MoveDirection.NORTH_WEST, coord.Item1, coord.Item2)) {
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

        private bool move(MoveDirection direction, int x, int y, bool allowedToMoveOnce = true) {
            char marker = tile(x, y);
            List<(int, int)> enemiesJumped = new List<(int, int)>();

            while (moveCondition(direction, ref x, ref y)) {
                if (tile(x, y) == EMPTY) {
                    tile(x, y, marker);
                    if (!allowedToMoveOnce && enemiesJumped.Count == 0) return false;
                    foreach (var coord in enemiesJumped) {
                        tile(coord.Item1, coord.Item2, EMPTY);
                    }
                    // Try to get a killstreak in every direction
                    if (!move(MoveDirection.NORTH_EAST, x, y, false))
                        if (!move(MoveDirection.NORTH_WEST, x, y, false))
                            if (!move(MoveDirection.SOUTH_EAST, x, y, false))
                                move(MoveDirection.SOUTH_WEST, x, y, false);
                    return true;
                } else if (tile(x, y) == marker) return false;
                else enemiesJumped.Add((x, y));
            }

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
