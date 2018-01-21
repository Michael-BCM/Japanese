public class KanaVars
{
    //Version 1
    private string[] letter0, letter1;

    public readonly string typeHiragana = "Using the onscreen keyboard, type in the Hiragana for the syllable "; //romaji to hiragana keyboard
    public readonly string writeHiragana = "Write down the Hiragana for the syllable "; //romaji to hiragana draw
    public readonly string typeEngHiragana = "Using your keyboard, type in the romaji for the Hiragana "; //hiragana to romaji keyboard

    public readonly string typeKatakana = "Using the onscreen keyboard, type in the Katakana for the syllable "; //romaji to katakana keyboard
    public readonly string writeKatakana = "Write down the Katakana for the syllable "; //romaji to katakana draw
    public readonly string typeEngKatakana = "Using your keyboard, type in the romaji for the Hiragana "; //katakana to romaji keyboard

    public readonly string typeKana = "Using the onscreen keyboard, type in both Kana for the syllable "; //romaji to both kana keyboard
    public readonly string writeKana = "Write down both Kana for the syllable "; //romaji to both kana draw

    //Version 2?
    public readonly string hiragana = "Hiragana";
    public readonly string katakana = "Katakana";
    public readonly string romaji = "Romaji";
    public readonly string traceOnWorksheet = "Trace this 30 times using the worksheet.";
    public readonly string kanaToRomMltpCh = "Choose the romaji syllable that matches the given kana.";
    public readonly string romToKanaMltpCh = "Choose the kana that matches the given romaji syllable."; //romaji to kana multiple choice.
    public readonly string hrgnToRomKB = "Using the onscreen keyboard, type the romaji for the given hiragana syllable."; //hiragana to romaji keyboard
    public readonly string ktknToRomKB = "Using the onscreen keyboard, type the romaji for the given katakana syllable."; //katakana to romaji keyboard
    public readonly string romToHrgnKB = "Using the onscreen keyboard, type the hiragana for the given romaji syllable."; //romaji to hiragana keyboard 
    public readonly string romToKtknKB = "Using the onscreen keyboard, type the katakana for the given romaji syllable."; //romaji to katakana keyboard
    public readonly string romToHrgnDraw = "Write the hiragana for the given romaji syllable."; //romaji to hiragana draw
    public readonly string romToKtknDraw = "Write the katakana for the given romaji syllable."; //romaji to katakana draw

    public void Start()
    {
        letter0 = new string[] { "", "k", "s", "t", "n", "h", "m", "y", "r", "w", "n" }; //Array of first letters of syllable.
        letter1 = new string[] { "a", "i", "u", "e", "o", }; //Array of second letters of syllable.
    }
}
