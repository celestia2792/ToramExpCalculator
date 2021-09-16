using System;
using System.Collections.Generic;
using System.Windows;

namespace ToramExpCalculator
{
    public class CItem
    {
        public string Value { get; set; }
        public string Option { get; set; }
        public bool IsEnabled { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<CItem> Items { get; } = new()
        {
            new CItem() { Value = "0", Option = ">==제 1장: 혼돈의 개막==<", IsEnabled = false },
            new CItem() { Value = "30", Option = "1화 처음 간 마을, 처음 만난 사람들", IsEnabled = true },
            new CItem() { Value = "80", Option = "2화 스트레이에 남매", IsEnabled = true },
            new CItem() { Value = "730", Option = "3화 골렘의 폭주", IsEnabled = true },
            new CItem() { Value = "2060", Option = "4화 지식의 여신", IsEnabled = true },
            new CItem() { Value = "4700", Option = "5화 용이 솟아난 구멍", IsEnabled = true },
            new CItem() { Value = "9330", Option = "6화 멸망의 사원거리", IsEnabled = true },
            new CItem() { Value = "16700", Option = "7화 최초의 마석", IsEnabled = true },
            new CItem() { Value = "27900", Option = "8화 감장향", IsEnabled = true },
            new CItem() { Value = "43000", Option = "9화 용과 검은 결정", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 2장: 홀리젬 소동기==<", IsEnabled = false },
            new CItem() { Value = "64000", Option = "10화 따라온 상인 아가씨", IsEnabled = true },
            new CItem() { Value = "92000", Option = "11화 홀리젬을 찾아서", IsEnabled = true },
            new CItem() { Value = "118200", Option = "12화 수수께끼!? 흑기사", IsEnabled = true },
            new CItem() { Value = "149000", Option = "13화 신월의 귀전의 시련", IsEnabled = true },
            new CItem() { Value = "172000", Option = "14화 달의 마도사", IsEnabled = true },
            new CItem() { Value = "227000", Option = "15화 존경하는자, 미워하는자", IsEnabled = true },
            new CItem() { Value = "240000", Option = "16화 마도사의 동굴", IsEnabled = true },
            new CItem() { Value = "255000", Option = "17화 별의 마도사", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 3장: 고대 신과의 전쟁==<", IsEnabled = false },
            new CItem() { Value = "270000", Option = "18화 최강의 난적??", IsEnabled = true },
            new CItem() { Value = "284000", Option = "19화 고대의 여제", IsEnabled = true },
            new CItem() { Value = "319000", Option = "20화 습격범의 정체", IsEnabled = true },
            new CItem() { Value = "335000", Option = "21화 성채의 운명", IsEnabled = true },
            new CItem() { Value = "398000", Option = "22화 사라진 거리의 기억", IsEnabled = true },
            new CItem() { Value = "417000", Option = "23화 빼앗긴 소서러 젬", IsEnabled = true },
            new CItem() { Value = "462300", Option = "24화 용과 생활하는 사람들", IsEnabled = true },
            new CItem() { Value = "540000", Option = "25화 이계로부터의 이형", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 4장: 새로운 검은 그림자==<", IsEnabled = false },
            new CItem() { Value = "562000", Option = "26화 마법을 쓰는 딜", IsEnabled = true },
            new CItem() { Value = "585000", Option = "27화 부흥을 위한 이동", IsEnabled = true },
            new CItem() { Value = "710000", Option = "28화 아카크의 성스러운 보석", IsEnabled = true },
            new CItem() { Value = "740000", Option = "29화 다르칸의 왕", IsEnabled = true },
            new CItem() { Value = "803000", Option = "30화 처리장에서 꿈틀거리는 것", IsEnabled = true },
            new CItem() { Value = "913000", Option = "31화 가짜 흑기사를 쫒아라!", IsEnabled = true },
            new CItem() { Value = "1000000", Option = "32화 테크니스타의 태동", IsEnabled = true },
            new CItem() { Value = "1100000", Option = "33화 춤추며 내려온 죽음의 깃털", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 5장: 어둠속에서 거칠게 부는 폭풍==<", IsEnabled = false },
            new CItem() { Value = "1150000", Option = "34화 미지의 어둠 속에서", IsEnabled = true },
            new CItem() { Value = "1310000", Option = "35화 부적의 소재", IsEnabled = true },
            new CItem() { Value = "1370000", Option = "36화 바싹 마른 어둠의 거울", IsEnabled = true },
            new CItem() { Value = "1550000", Option = "37화 승화의 정원의 격투", IsEnabled = true },
            new CItem() { Value = "1750000", Option = "38화 어둠에 드리우는 빛", IsEnabled = true },
            new CItem() { Value = "1970000", Option = "39화 저택에 둥지를 튼 자", IsEnabled = true },
            new CItem() { Value = "2210000", Option = "40화 어둠의 성", IsEnabled = true },
            new CItem() { Value = "2220000", Option = "41화 생의 세계로", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 6장: 두개의 테크니스타==<", IsEnabled = false },
            new CItem() { Value = "2600000", Option = "42화 데미마키나", IsEnabled = true },
            new CItem() { Value = "2700000", Option = "43화 팍스 파의 마을", IsEnabled = true },
            new CItem() { Value = "2800000", Option = "44화 기계 장치의 마음", IsEnabled = true },
            new CItem() { Value = "2820000", Option = "45화 류아크의 흑기사", IsEnabled = true },
            new CItem() { Value = "3030000", Option = "46화 수수께끼의 유물", IsEnabled = true },
            new CItem() { Value = "3099000", Option = "47화 유물의 정체", IsEnabled = true },
            new CItem() { Value = "3320000", Option = "48화 배신의 대가", IsEnabled = true },
            new CItem() { Value = "3640000", Option = "49화 생명모독 공장", IsEnabled = true },
            new CItem() { Value = "4020000", Option = "50화 흑기사의 수수께끼", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 7장: 동란의 아르티메아==<", IsEnabled = false },
            new CItem() { Value = "4730000", Option = "51화 괴물의 숲", IsEnabled = true },
            new CItem() { Value = "4820000", Option = "52화 파르티잔의 지하도시", IsEnabled = true },
            new CItem() { Value = "5070000", Option = "53화 류아크 영내의 엘프", IsEnabled = true },
            new CItem() { Value = "5500000", Option = "54화 광기의 연구소", IsEnabled = true },
            new CItem() { Value = "6000000", Option = "55화 참상의 감옥", IsEnabled = true },
            new CItem() { Value = "6400000", Option = "56화 드로마 광장의 참극", IsEnabled = true },
            new CItem() { Value = "6900000", Option = "57화 아르티메아 궁전으로", IsEnabled = true },
            new CItem() { Value = "7400000", Option = "58화 혼돈의 진실", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 8장: 엘덴바움으로의 길==<", IsEnabled = false },
            new CItem() { Value = "8400000", Option = "59화 몬스터가 서식하는 갱도", IsEnabled = true },
            new CItem() { Value = "8500000", Option = "60화 수수깨끼의 사람 그림자", IsEnabled = true },
            new CItem() { Value = "8600000", Option = "61화 딜의 새로운 나라", IsEnabled = true },
            new CItem() { Value = "8800000", Option = "62화 신들의 유적이 있는 곳", IsEnabled = true },
            new CItem() { Value = "9100000", Option = "63화 선대 정의의 신", IsEnabled = true },
            new CItem() { Value = "9700000", Option = "64화 신전에 남은 옥좌", IsEnabled = true },
            new CItem() { Value = "10400000", Option = "65화 신들이 있는 곳", IsEnabled = true },
            new CItem() { Value = "11100000", Option = "66화 종의 신전에서 기다리는 자", IsEnabled = true },
            new CItem() { Value = "11800000", Option = "67화 빙설의 문지기", IsEnabled = true },
            new CItem() { Value = "12500000", Option = "68화 산맥의 끝에서", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 9장: 엘덴바움 탈환전==<", IsEnabled = false },
            new CItem() { Value = "15800000", Option = "69화 엘덴바움으로 가는 험난한 길", IsEnabled = true },
            new CItem() { Value = "17100000", Option = "70화 뜻밖의 함정", IsEnabled = true },
            new CItem() { Value = "18200000", Option = "71화 진보의 유적", IsEnabled = true },
            new CItem() { Value = "19200000", Option = "72화 예상 외의 지인", IsEnabled = true },
            new CItem() { Value = "20300000", Option = "73화 전선 기지 가동", IsEnabled = true },
            new CItem() { Value = "21500000", Option = "74화 나무 위의 항구 탈환 작전", IsEnabled = true },
            new CItem() { Value = "22700000", Option = "75화 전이 장치라는 유산", IsEnabled = true },
            new CItem() { Value = "23900000", Option = "76화 죽을 곳을 찾는 남자", IsEnabled = true },
            new CItem() { Value = "25000000", Option = "77화 엘덴바움 탈환전", IsEnabled = true },
            new CItem() { Value = "13000000", Option = "78화 새로운 시작", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 10장: 잃어버린 신의 배==<", IsEnabled = false },
            new CItem() { Value = "26000000", Option = "79화 인연 깊은 땅으로", IsEnabled = true },
            new CItem() { Value = "27400000", Option = "80화 절벽 밑의 점거자", IsEnabled = true },
            new CItem() { Value = "28800000", Option = "81화 악몽과의 재회", IsEnabled = true },
            new CItem() { Value = "30200000", Option = "82화 사라진 수행승의 행방", IsEnabled = true },
            new CItem() { Value = "31600000", Option = "83화 용기의 여신과 불법 점거자", IsEnabled = true },
            new CItem() { Value = "33100000", Option = "84화 방주의 키잡이", IsEnabled = true },
            new CItem() { Value = "34600000", Option = "85화 숲속의 마녀", IsEnabled = true },
            new CItem() { Value = "36200000", Option = "86화 노브 딜러의 결투", IsEnabled = true },
            new CItem() { Value = "0", Option = ">==제 11장: 토람으로==<", IsEnabled = false },
            new CItem() { Value = "37800000", Option = "87화 날아오른 방주", IsEnabled = true },
            new CItem() { Value = "49000000", Option = "88화 낯선 땅에서", IsEnabled = true },
            new CItem() { Value = "51000000", Option = "89화 산책하는 숲", IsEnabled = true }
        };
        public MainWindow()
        {
            InitializeComponent();
            ADestMqBox.SelectedIndex = BDestMqBox.SelectedIndex = CDestMqBox.SelectedIndex = 99;
            BStartMqBox.SelectedIndex = CStartMqBox.SelectedIndex = 1;
            AStartLVval.Text = ADestLVval.Text = BStartLVval.Text = CDestLVval.Text = "0";
            AStartLevel.Text = BStartLevel.Text = "1";
            ADestLevel.Text = CDestLevel.Text = "230";
        }

        private void AConfirm(object sender, RoutedEventArgs e)
        {
            long SummaryQuestExp = 0;
            long StartExp, DestExp;
            StartExp = DestExp = 0;
            int n = ADestMqBox.SelectedIndex;
            long Mq_Exp = 0;
            try
            {
                int StartLevel = Convert.ToInt32(AStartLevel.Text);
                int StartVal = Convert.ToInt32(AStartLVval.Text);
                if (StartLevel <= 0 || StartLevel > 230 || StartVal < 0 || StartVal >= 100)
                    throw new Exception("유효한 값을 입력해주세요");
                for (int i = 1; i < StartLevel; i++)
                {
                    StartExp += Convert.ToInt32(Math.Pow(i, 4) / 40 + i * 2);
                }
                StartExp += Convert.ToInt32((Math.Pow(StartLevel, 4) / 40 + StartLevel * 2) * StartVal / 100);
                int DestLevel = Convert.ToInt32(ADestLevel.Text);
                int DestVal = Convert.ToInt32(ADestLVval.Text);
                if (DestLevel <= 0 || DestLevel > 230 || DestVal < 0 || DestVal >= 100)
                    throw new Exception("유효한 값을 입력해주세요");
                for (int i = 1; i < DestLevel; i++)
                {
                    DestExp += Convert.ToInt32(Math.Pow(i, 4) / 40 + i * 2);
                }
                DestExp += Convert.ToInt32((Math.Pow(DestLevel, 4) / 40 + DestLevel * 2) * DestVal / 100);
                if (StartExp >= DestExp) throw new Exception("시작레벨의 EXP값은 목표레벨의 EXP값보다 크거나 같을수 없습니다");
                if (ADestMqBox.SelectedIndex == 1) throw new Exception($"\"{Items[1].Option}\"은\n메인 시나리오의 종착점이 될 수 없습니다");
            }
            catch (FormatException)
            {
                MessageBox.Show("정수만 입력해주세요");
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Mq_Exp += Convert.ToInt32(Items[i].Value);
            }
            long Required_BookNum = 1;
            if (DestExp - StartExp <= Mq_Exp)
            {
                for (; DestExp - StartExp > SummaryQuestExp; n--)
                { SummaryQuestExp += Convert.ToInt64(Items[n].Value); }
            }
            else
            {
                long requiredExp = DestExp - StartExp;
                long temp = Mq_Exp;
                while (requiredExp > Mq_Exp)
                {
                    Mq_Exp += temp;
                    Required_BookNum++;
                }
                for (; requiredExp > SummaryQuestExp; n--)
                { SummaryQuestExp += Required_BookNum * Convert.ToInt64(Items[n].Value); }
            }
            if (!Items[n].IsEnabled) { n++; }
            AResultWindow.Content = $"모험가의 일기는 {Required_BookNum}개 필요하며\n" +
                $"\"{Items[n].Option}\"부터\n시나리오를 시작해야 목표레벨에 도달합니다";
        }

        private void BConfirm(object sender, RoutedEventArgs e)
        {
            long StartExp = 0;
            long SummaryQuestExp = 0;
            try
            {
                int StartLevel = Convert.ToInt32(BStartLevel.Text);
                int StartVal = Convert.ToInt32(BStartLVval.Text);
                if (StartLevel <= 0 || StartLevel > 230 || StartVal < 0 || StartVal >= 100)
                    throw new Exception("유효한 값을 입력해주세요");
                for (int i = 1; i < StartLevel; i++)
                {
                    StartExp += Convert.ToInt32(Math.Pow(i, 4) / 40 + i * 2);
                }
                StartExp += Convert.ToInt32((Math.Pow(StartLevel, 4) / 40 + StartLevel * 2) * StartVal / 100);
                if (BStartMqBox.SelectedIndex >= BDestMqBox.SelectedIndex) throw new Exception("시나리오 시작점이 시나리오 종착점 이후일수 없습니다");
            }
            catch (FormatException)
            {
                MessageBox.Show("정수만 입력해주세요");
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            int StartIndex = BStartMqBox.SelectedIndex;
            int DestIndex = BDestMqBox.SelectedIndex;
            while (StartIndex <= DestIndex)
            {
                SummaryQuestExp += Convert.ToInt32(Items[StartIndex].Value);
                StartIndex++;
            }
            StartExp += SummaryQuestExp;
            int ResultLevel = 1;
            long temp = 0;
            for (; StartExp > temp; ResultLevel++)
                temp += Convert.ToInt32(Math.Pow(ResultLevel, 4) / 40 + ResultLevel * 2);
            ResultLevel--;
            temp -= Convert.ToInt32(Math.Pow(ResultLevel, 4) / 40 + ResultLevel * 2);
            BResultWindow.Content = $"{ResultLevel} ({Math.Floor(100 * (StartExp - temp) / (Math.Pow(ResultLevel, 4) / 40 + ResultLevel * 2))}%) 에 도달합니다\n" +
                "(오차범위 ±1% 존재가능)";
        }

        private void CConfirm(object sender, RoutedEventArgs e)
        {
            long DestExp = 0;
            long SummaryQuestExp = 0;
            try
            {
                int DestLevel = Convert.ToInt32(CDestLevel.Text);
                int DestVal = Convert.ToInt32(CDestLVval.Text);
                if (DestLevel <= 0 || DestLevel > 230 || DestVal < 0 || DestVal >= 100)
                    throw new Exception("유효한 값을 입력해주세요");
                for (int i = 1; i < DestLevel; i++)
                {
                    DestExp += Convert.ToInt32(Math.Pow(i, 4) / 40 + i * 2);
                }
                DestExp += Convert.ToInt32((Math.Pow(DestLevel, 4) / 40 + DestLevel * 2) * DestVal / 100);
                if (CStartMqBox.SelectedIndex >= CDestMqBox.SelectedIndex) throw new Exception("시나리오 시작점이 시나리오 종착점 이후일수 없습니다");
            }
            catch (FormatException)
            {
                MessageBox.Show("정수만 입력해주세요");
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            int StartIndex = CStartMqBox.SelectedIndex;
            int DestIndex = CDestMqBox.SelectedIndex;
            while (StartIndex <= DestIndex)
            {
                SummaryQuestExp += Convert.ToInt32(Items[StartIndex].Value);
                StartIndex++;
            }
            long StartExp = DestExp - SummaryQuestExp;
            if (StartExp > 0)
            {
                int ResultLevel = 1;
                long temp = 0;
                for (; StartExp > temp; ResultLevel++)
                    temp += Convert.ToInt32(Math.Pow(ResultLevel, 4) / 40 + ResultLevel * 2);
                ResultLevel--;
                temp -= Convert.ToInt32(Math.Pow(ResultLevel, 4) / 40 + ResultLevel * 2);
                CResultWindow.Content = $"{ResultLevel} ({Math.Floor(100 * (StartExp - temp) / (Math.Pow(ResultLevel, 4) / 40 + ResultLevel * 2))}%) 에서 시작해야합니다\n" +
                    "(오차범위 ±1% 존재가능)";
            }
            else CResultWindow.Content = "1 (0%) 에서 시작해야합니다\n(오차범위 ±1% 존재가능)";
        }
    }
}
