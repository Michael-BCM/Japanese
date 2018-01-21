using System.Collections.Generic;

public class KanaBank
{
    Kana a = new Kana("a", "あ", "ア", 1);
    Kana i = new Kana("i", "い", "イ", 2);
    Kana u = new Kana("u", "う", "ウ", 3);
    Kana e = new Kana("e", "え", "エ", 4);
    Kana o = new Kana("o", "お", "オ", 5);
    Kana ka = new Kana("ka", "か", "カ", 6);
    Kana ki = new Kana("ki", "き", "キ", 7);
    Kana ku = new Kana("ku", "く", "ク", 8);
    Kana ke = new Kana("ke", "け", "ケ", 9);
    Kana ko = new Kana("ko", "こ", "コ", 10);
    Kana sa = new Kana("sa", "さ", "サ", 11);
    Kana shi = new Kana("shi", "し", "シ", 12);
    Kana su = new Kana("su", "す", "ス", 13);
    Kana se = new Kana("se", "せ", "セ", 14);
    Kana so = new Kana("so", "そ", "ソ", 15);
    Kana ta = new Kana("ta", "た", "タ", 16);
    Kana chi = new Kana("chi", "ち", "チ", 17);
    Kana tsu = new Kana("tsu", "つ", "ツ", 18);
    Kana te = new Kana("te", "て", "テ", 19);
    Kana to = new Kana("to", "と", "ト", 20);
    Kana na = new Kana("na", "な", "ナ", 21);
    Kana ni = new Kana("ni", "に", "ニ", 22);
    Kana nu = new Kana("nu", "ぬ", "ヌ", 23);
    Kana ne = new Kana("ne", "ね", "ネ", 24);
    Kana no = new Kana("no", "の", "ノ", 25);
    Kana ha = new Kana("ha", "は", "ハ", 26);
    Kana hi = new Kana("hi", "ひ", "ヒ", 27);
    Kana fu = new Kana("fu", "ふ", "フ", 28);
    Kana he = new Kana("he", "へ", "ヘ", 29);
    Kana ho = new Kana("ho", "ほ", "ホ", 30);
    Kana ma = new Kana("ma", "ま", "マ", 31);
    Kana mi = new Kana("mi", "み", "ミ", 32);
    Kana mu = new Kana("mu", "む", "ム", 33);
    Kana me = new Kana("me", "め", "メ", 34);
    Kana mo = new Kana("mo", "も", "モ", 35);
    Kana ya = new Kana("ya", "や", "ヤ", 36);
    Kana yu = new Kana("yu", "ゆ", "ユ", 37);
    Kana yo = new Kana("yo", "よ", "ヨ", 38);
    Kana ra = new Kana("ra", "ら", "ラ", 39);
    Kana ri = new Kana("ri", "り", "リ", 40);
    Kana ru = new Kana("ru", "る", "ル", 41);
    Kana re = new Kana("re", "れ", "レ", 42);
    Kana ro = new Kana("ro", "ろ", "ロ", 43);
    Kana wa = new Kana("wa", "わ", "ワ", 44);
    Kana wi = new Kana("wi", "ゐ", "ヰ", 45);
    Kana we = new Kana("we", "ゑ", "ヱ", 46);
    Kana wo = new Kana("wo", "を", "ヲ", 47);
    Kana n = new Kana("n", "ん", "ン", 48);

    public List<Kana> allKana = new List<Kana>(); //Declares a new empty list, with the label 'allKana'. Holds all kana.
    public List<Kana> vowels = new List<Kana>(); //Holds all 5 vowel sounds.
    public List<Kana> kKana = new List<Kana>(); //All 'k' sounds.
    public List<Kana> sKana = new List<Kana>(); //All 's' sounds.
    public List<Kana> tKana = new List<Kana>(); //All 't' sounds.
    public List<Kana> nKana = new List<Kana>(); //All 'n' sounds.
    public List<Kana> hKana = new List<Kana>(); //All 'h' sounds.
    public List<Kana> mKana = new List<Kana>(); //All 'm' sounds.
    public List<Kana> yKana = new List<Kana>(); //All 'y' sounds.
    public List<Kana> rKana = new List<Kana>(); //All 'r' sounds.
    public List<Kana> wKana = new List<Kana>(); //All 'w' sounds and 'n'.

    public void AddAllKanaToList() //Adds all kana to 'allKana' list. 
    {
        allKana.Add(a);
        allKana.Add(i);
        allKana.Add(u);
        allKana.Add(e);
        allKana.Add(o);
        allKana.Add(ka);
        allKana.Add(ki);
        allKana.Add(ku);
        allKana.Add(ke);
        allKana.Add(ko);
        allKana.Add(sa);
        allKana.Add(shi);
        allKana.Add(su);
        allKana.Add(se);
        allKana.Add(so);
        allKana.Add(ta);
        allKana.Add(chi);
        allKana.Add(tsu);
        allKana.Add(te);
        allKana.Add(to);
        allKana.Add(na);
        allKana.Add(ni);
        allKana.Add(nu);
        allKana.Add(ne);
        allKana.Add(no);
        allKana.Add(ha);
        allKana.Add(hi);
        allKana.Add(fu);
        allKana.Add(he);
        allKana.Add(ho);
        allKana.Add(ma);
        allKana.Add(mi);
        allKana.Add(mu);
        allKana.Add(me);
        allKana.Add(mo);
        allKana.Add(ya);
        allKana.Add(yu);
        allKana.Add(yo);
        allKana.Add(ra);
        allKana.Add(ri);
        allKana.Add(ru);
        allKana.Add(re);
        allKana.Add(ro);
        allKana.Add(wa);
        allKana.Add(wi);
        allKana.Add(we);
        allKana.Add(wo);
        allKana.Add(n);
    }

    public void AddKanaToGroupLists() //Group lists. Adds each kana group to each individual list. 
    {
        vowels.Add(a);
        vowels.Add(i);
        vowels.Add(u);
        vowels.Add(e);
        vowels.Add(o);

        kKana.Add(ka);
        kKana.Add(ki);
        kKana.Add(ku);
        kKana.Add(ke);
        kKana.Add(ko);

        sKana.Add(sa);
        sKana.Add(shi);
        sKana.Add(su);
        sKana.Add(se);
        sKana.Add(so);

        tKana.Add(ta);
        tKana.Add(chi);
        tKana.Add(tsu);
        tKana.Add(te);
        tKana.Add(to);

        nKana.Add(na);
        nKana.Add(ni);
        nKana.Add(nu);
        nKana.Add(ne);
        nKana.Add(no);

        hKana.Add(ha);
        hKana.Add(hi);
        hKana.Add(fu);
        hKana.Add(he);
        hKana.Add(ho);

        mKana.Add(ma);
        mKana.Add(mi);
        mKana.Add(mu);
        mKana.Add(me);
        mKana.Add(mo);

        yKana.Add(ya);
        yKana.Add(yu);
        yKana.Add(yo);

        rKana.Add(ra);
        rKana.Add(ra);
        rKana.Add(ra);
        rKana.Add(ra);
        rKana.Add(ra);

        wKana.Add(wa);
        wKana.Add(wi);
        wKana.Add(we);
        wKana.Add(wo);
        wKana.Add(n);
    }   
}