public enum PieceType {Knight, Queen, Bishop, Pawn, King, Rook}
public enum Colour {White, Black}

public readonly record struct Piece (PieceType Type, Colour Colour)
{
    public char ToFenChar() 
    { 
        switch(Type){
            case PieceType.Queen:
                if (Colour == Colour.White)
                {
                    return 'Q';
                }
                return 'q';
            case PieceType.King:
                if (Colour == Colour.White)
                {
                    return 'K';
                }
                return 'k';
            case PieceType.Bishop:
                if (Colour == Colour.White)
                {
                    return 'B';
                }
                return 'b';
            case PieceType.Rook:
                if (Colour == Colour.White)
                {
                    return 'R';
                }
                return 'r';
            case PieceType.Knight:
                if (Colour == Colour.White)
                {
                    return 'N';
                }
                return 'n';
            case PieceType.Pawn:
                if (Colour == Colour.White)
                {
                    return 'P';
                }
                return 'p';
        }
        return ' ';
    }
    public static Piece FromFenChar(char c) 
    { 
        char letter = char.ToUpper(c);
        switch(letter){
            case 'Q':
                if (char.IsUpper(c))
                {
                    return new Piece(PieceType.Queen, Colour.White);
                }
                return new Piece(PieceType.Queen, Colour.Black);
            case 'K':
                if (char.IsUpper(c))
                {
                    return new Piece(PieceType.King, Colour.White);
                }
                return new Piece(PieceType.King, Colour.Black);
            case 'B':
                if (char.IsUpper(c))
                {
                    return new Piece(PieceType.Bishop, Colour.White);
                }
                return new Piece(PieceType.Bishop, Colour.Black);
            case 'R':
                if (char.IsUpper(c))
                {
                    return new Piece(PieceType.Rook, Colour.White);
                }
                return new Piece(PieceType.Rook, Colour.Black);
            case 'N':
                if (char.IsUpper(c))
                {
                    return new Piece(PieceType.Knight, Colour.White);
                }
                return new Piece(PieceType.Knight, Colour.Black);
            case 'P':
                if (char.IsUpper(c))
                {
                    return new Piece(PieceType.Pawn, Colour.White);
                }
                return new Piece(PieceType.Pawn, Colour.Black);
        }
        return new Piece();
    }
}