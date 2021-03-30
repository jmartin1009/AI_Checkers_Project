namespace AICheckers {
    public class Piece {
        public PieceType Type { get; private set; }
        public bool IsKing { get { return Type == PieceType.BLACK_KING || Type == PieceType.WHITE_KING; } }

        public Piece(PieceType type) {
            Type = type;
        }

        public override bool Equals(object obj) {
            if (obj is PieceType) {
                PieceType type = (PieceType)obj;

                switch (type) {
                    case PieceType.BLACK:
                        return Type == PieceType.BLACK || Type == PieceType.BLACK_KING;
                    case PieceType.WHITE:
                        return Type == PieceType.WHITE || Type == PieceType.WHITE_KING;
                    case PieceType.BLACK_KING:
                        return Type == PieceType.BLACK_KING;
                    case PieceType.WHITE_KING:
                        return Type == PieceType.WHITE_KING;
                    case PieceType.EMPTY:
                        return Type == PieceType.EMPTY;
                }
            }

            return false;
        }
    }
}
