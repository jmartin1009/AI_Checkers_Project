using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AICheckers {
    public class Game {
        public Node Current { get; private set; }

        public Game() {
            Current = new Node(new char[] {
                Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE,
                Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY,
                Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE, Node.EMPTY, Node.WHITE,
                Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY,
                Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY, Node.EMPTY,
                Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY,
                Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK,
                Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY, Node.BLACK, Node.EMPTY,
            });
        }

        public bool IsWinForBlack() { return Current.GetHeuristic(true) == int.MaxValue; }
        public bool IsWinForWhite() { return Current.GetHeuristic(false) == int.MinValue; }

        public void HumanMakeMove(int x, int y, MoveDirection direction) {
            Current.Move(direction, x, y);
        }

        public void AIMakeMove() {
            Dictionary<int, Node> choices = new Dictionary<int, Node>();

            foreach (var child in Current.GetChildren(true)) {
                int minimaxScore = minimax(child, true, 5, int.MinValue, int.MaxValue);
                if (!choices.ContainsKey(minimaxScore)) {
                    choices.Add(minimaxScore, child);
                }
            }

            Current = choices[choices.Keys.Max()];
        }

        private int minimax(Node node, bool isBlackTurn, int targetDepth, int a, int b) {
            if (node.Depth == targetDepth) return node.GetHeuristic(isBlackTurn);

            if (isBlackTurn) {
                int value = int.MinValue;
                foreach (Node child in node.GetChildren(isBlackTurn)) {
                    value = Math.Max(value, minimax(child, false, targetDepth, a, b));
                    a = Math.Max(a, value);
                    if (a >= b) break;
                }
                return value;
            } else {
                int value = int.MinValue;
                foreach (Node child in node.GetChildren(isBlackTurn)) {
                    value = Math.Max(value, minimax(child, true, targetDepth, a, b));
                    b = Math.Min(b, value);
                    if (b <= a) break;
                }
                return value;
            }
        }
    }
}
