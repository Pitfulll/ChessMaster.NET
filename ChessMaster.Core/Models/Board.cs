public class Board
{
    private readonly Piece?[,] _squares = new Piece?[8, 8];
    public Piece? this[Square sq] => _squares[sq.File, sq.Rank];


}