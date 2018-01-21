public class Kana
{
    private string romaji;
    private string hiragana;
    private string katakana;
    private int indexNumber;

    public QuestionType hrgnToRomMltpCh { get; private set; }
    public QuestionType ktknToRomMltpCh { get; private set; }
    public QuestionType romToHrgnMltpCh { get; private set; }
    public QuestionType romToKtknMltpCh { get; private set; }
    public QuestionType hrgnToRomKB { get; private set; }
    public QuestionType ktknToRomKB { get; private set; }
    public QuestionType romToHrgnKB { get; private set; }
    public QuestionType romToKtknKB { get; private set; }
    public QuestionType hiraganaDraw { get; private set; }
    public QuestionType katakanaDraw { get; private set; }

    //Include mixed kana questions. Total of 15 exercises for 10 variables.

    public bool isStrokePracticeDone { get; private set; } //stroke order practice done?

    public Kana(string r, string h, string k, int i) //4 argument constructor. Used for setting values and index number.
    {
        romaji = r;
        hiragana = h;
        katakana = k;

        indexNumber = i;
    }
}