using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPGame
{
    public partial class JpLearn : Form
    {
        private int good;
        private int bad;
        private int randomChoice;

        private string[,] hiragana = new string[,]
        {
            {"あ", "a"},
            {"か", "ka"},
            {"さ", "sa"},
            {"た", "ta"},
            {"な", "na"},
            {"は", "ha/wa"},
            {"ま", "ma"},
            {"や", "ya"},
            {"ら", "ra"},
            {"わ", "wa"},
            {"が", "ga"},
            {"ざ", "za"},
            {"だ", "da"},
            {"ば", "ba"},
            {"ぱ", "pa"},

            {"い", "i"},
            {"き", "ki"},
            {"し", "shi"},
            {"ち", "chi"},
            {"に", "ni"},
            {"ひ", "hi"},
            {"み", "mi"},
            {"り", "ri"},
            {"ぎ", "gi"},
            {"じ", "ji"},
            {"び", "bi"},
            {"ぴ", "pi"},

            {"う", "u"},
            {"く", "ku"},
            {"す", "su"},
            {"つ", "tsu"},
            {"ぬ", "nu"},
            {"ふ", "fu/hu"},
            {"む", "mu"},
            {"ゆ", "yu"},
            {"る", "ru"},
            {"ぐ", "gu"},
            {"ず", "zu"},
            {"ぶ", "bu"},
            {"ぷ", "pu"},

            {"え", "e"},
            {"け", "ke"},
            {"せ", "se"},
            {"て", "te"},
            {"ね", "ne"},
            {"へ", "he/e"},
            {"め", "me"},
            {"れ", "re"},
            {"げ", "ge"},
            {"ぜ", "ze"},
            {"で", "de"},
            {"べ", "be"},
            {"ぺ", "pe"},

            {"お", "o"},
            {"こ", "ko"},
            {"そ", "so"},
            {"と", "to"},
            {"の", "no"},
            {"ほ", "ho"},
            {"も", "mo"},
            {"よ", "yo"},
            {"ろ", "ro"},
            {"を", "wo/o"},
            {"ん", "n"},
            {"ご", "go"},
            {"ぞ", "zo"},
            {"ど", "do"},
            {"ぼ", "bo"},
            {"ぽ", "po"},

            {"や", "ya"},
            {"きゃ", "kya"},
            {"しゃ", "sha"},
            {"ちゃ", "cha"},
            {"にゃ", "nya"},
            {"ひゃ", "hya"},
            {"みゃ", "mya"},
            {"りゃ", "rya"},
            {"ぎゃ", "gya"},
            {"じゃ", "ja"},
            {"ぢゃ", "dja"},
            {"びゃ", "bya"},
            {"ぴゃ", "pya"},

            {"ゆ", "yu"},
            {"きゅ", "kyu"},
            {"しゅ", "shu"},
            {"ちゅ", "chu"},
            {"にゅ", "nyu"},
            {"ひゅ", "hyu"},
            {"みゅ", "myu"},
            {"りゅ", "ryu"},
            {"ぎゅ", "gyu"},
            {"じゅ", "ju"},
            {"ぢゅ", "dju"},
            {"びゅ", "byu"},
            {"ぴゅ", "pyu"},

            {"よ", "yo"},
            {"きょ", "kyo"},
            {"しょ", "sho"},
            {"ちょ", "cho"},
            {"にょ", "nyo"},
            {"ひょ", "hyo"},
            {"みょ", "myo"},
            {"りょ", "ryo"},
            {"ぎょ", "gyo"},
            {"じょ", "gyo"},
            {"ぢょ", "jo"},
            {"びょ", "byo"},
            {"ぴょ", "pyo"},

            {"わ", "wa"},
            {"くぁ", "kwa"},
            {"ぐぁ", "gwa"}
        };

        public JpLearn()
        {
            InitializeComponent();
            //MessageBox.Show($"{hiragana[5,0]} - {hiragana[5,1]}");
            
            assignValues();
        }

        private void assignValues()
        {
            randomChoice = rndSelect();
            lblHiragana.Text = hiragana[randomChoice, 0];

            lblBad.Text = $"Bad: {bad}";
            lblGood.Text = $"Good: {good}";
        }

        private int rndSelect()
        {
            Random rnd = new Random();
            return rnd.Next(hiragana.Length/2);
        }

        private void check(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;

                if (hiragana[randomChoice, 1].Contains(txtCheckSpell.Text)) good++;
                else bad++;

                txtCheckSpell.Text = null;

                assignValues();
            }
        }
    }
}
