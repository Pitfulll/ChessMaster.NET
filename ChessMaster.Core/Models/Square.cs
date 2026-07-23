public readonly record struct Square(int File, int Rank)
{
    // convert 'e4' into 5,3 for instance
    public static Square FromAlgebraic(string s) => new Square((char)s[0], (int)s[1]-1);
    public string ToString(Square s) => $"{(char)('a'+ s.File)}{s.Rank+1}";
    
}