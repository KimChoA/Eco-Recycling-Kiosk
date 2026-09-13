using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eco
{
    public partial class MainForm : Form
    {
        // 초기 픽쳐박스 이미지 복사본 저장용(초기화 및 되돌리기 용)
        private Image defaultImg1;
        private Image defaultImg2;
        private Image defaultImg3;
        private Image defaultImg4;
        private UserInfo currentUser; /// 로그인한 현재 사용자 정보
        private main mainForm1; // form1 참조 객체(홈 이동 및 회원 데이터 동기화)

        // 기본 이미지들을 백업하여 나중에 선택해제 시 복구할 수 있도록 설정
        private void InitDefaultImages()
        {
            if (pictureBox1.Image != null) defaultImg1 = (Image)pictureBox1.Image.Clone();
            if (pictureBox2.Image != null) defaultImg2 = (Image)pictureBox2.Image.Clone();
            if (pictureBox3.Image != null) defaultImg3 = (Image)pictureBox3.Image.Clone();
            if (pictureBox4.Image != null) defaultImg4 = (Image)pictureBox4.Image.Clone();
        }

        // 기본 생성자(디자이너 및 테스트용)
        public MainForm()
        {
            InitializeComponent();
            EnableDoubleBuffering(); // 화면 깜빡임 방지
            InitDefaultImages();
            SetDoubleBuffered(tabControl1);
            SetAllControlsDoubleBuffered(this.tabControl1);
        }


        // 사용자 정보를 전달 받는 생성자
        public MainForm(UserInfo user)
        {
            InitializeComponent();
            this.currentUser = user;

            InitDefaultImages();
            RegisterShopEvents(); //에코샵 이벤트 등록
            ShowWelcomeMessage(); // 로그인 환영 메세지
            DisplayUserInfo(); // 화면에 사용자 정보 표시
        }

        // 사용자 정보와 이전 from1 객체를 함께 전달 받는 생성자
        public MainForm(UserInfo user, main form1)
        {
            InitializeComponent();
            this.currentUser = user;
            this.mainForm1 = form1; // 전달받은 Form1을 저장(이전 화면 객체 저장)

            InitDefaultImages();
            RegisterShopEvents();
            ShowWelcomeMessage();
            DisplayUserInfo();
        }

        // 폼 자체의 화면 깜빡임 현상을 줄여주는 더블 버퍼링 설정
        private void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }


        // 로그인 성공 시 사용자 포인트 현황 팝업 출력
        private void ShowWelcomeMessage()
        {
            if (currentUser != null)
            {
                MessageBox.Show($"환영합니다! {currentUser.Name}님\n" +
                                $"현재 포인트: {currentUser.Point:N0}p\n" +
                                $"누적사용 포인트: {currentUser.UsedPoint:N0}p", "로그인 성공");
            }
        }


        // 마이페이지 및 상단 라벨에 현재 사용자 정보(이름, 전화번호, 포인트, CO2 감축량 등) 갱신
        private void DisplayUserInfo()
        {
            if (currentUser != null)
            {
                lbName.Text = currentUser.Name;
                lbTel.Text = currentUser.PhoneNumber;
                lbNowPoint.Text = currentUser.Point.ToString();
                lbUsedPoint.Text = currentUser.UsedPoint.ToString();
                lbCO2.Text = $"{currentUser.Co2Saved:F2} kg CO₂";
                lbTree2.Text = $"약 {currentUser.TreeCount:F2} 그루 🌲";
            }
        }

        // 에코 샵 수량 변경 이벤트 등록
        private void RegisterShopEvents()
        {
            numericT.ValueChanged += ShopItem_ValueChanged;
            numericBus.ValueChanged += ShopItem_ValueChanged;
            numericBike.ValueChanged += ShopItem_ValueChanged;
            numericMarket.ValueChanged += ShopItem_ValueChanged;
            numericOcean.ValueChanged += ShopItem_ValueChanged;
            numericTree.ValueChanged += ShopItem_ValueChanged;
        }

        //에코샵 수량 변경 시 총 금액 실시간 계산
        private void ShopItem_ValueChanged(object sender, EventArgs e)
        {
            int totalCost = CalculateTotalShopCost();
            tb_TotalUsingPoint.Text = $"{totalCost:N0} p"; // 텍스트박스에 실시간 표시
        }

        // 에코샵 선택 상품의 총 포인트 계산
        private int CalculateTotalShopCost()
        {
            int bagCost = (int)numericT.Value * int.Parse(lbT.Text);
            int transitCost = (int)numericBus.Value * int.Parse(lbBus.Text);
            int bikeCost = (int)numericBike.Value * int.Parse(lbbike.Text);
            int onnuriCost = (int)numericMarket.Value * int.Parse(lbMarket.Text);
            int oceanCost = (int)numericOcean.Value * int.Parse(lbOcean.Text);
            int treeCost = (int)numericTree.Value * int.Parse(lbTree.Text);

            return bagCost + transitCost + bikeCost + onnuriCost + oceanCost + treeCost;
        }

        // 에코 샵 입력 수량 초기화
        private void ResetShopInputs()
        {
            numericT.Value = 0;
            numericBus.Value = 0;
            numericBike.Value = 0;
            numericMarket.Value = 0;
            numericOcean.Value = 0;
            numericTree.Value = 0;

            tb_TotalUsingPoint.Text = "0 p";
        }


        // 특정 컨트롤 내부 자식들까지 더블 버퍼링 설정
        public static void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });

            foreach (Control child in control.Controls)
            {
                SetDoubleBuffered(child);
            }
        }

        // 하위 모든 컨트롤에 더블 버퍼링 적용
        private void SetAllControlsDoubleBuffered(Control parentControl)
        {
            foreach (Control c in parentControl.Controls)
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    System.Reflection.BindingFlags.SetProperty |
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic,
                    null, c, new object[] { true });

                if (c.Controls.Count > 0)
                {
                    SetAllControlsDoubleBuffered(c);
                }
            }
        }

        //플라스틱 상세 설명 및 이미지 초기화
        public void ResetToDefault()
        {
            label5.Text = "플라스틱 재질을 선택해주세요.";
            label8.Text = "-.";
            label9.Text = "-";

            pictureBox1.Image = defaultImg1;
            pictureBox2.Image = defaultImg2;
            pictureBox3.Image = defaultImg3;
            pictureBox4.Image = defaultImg4;
        }

        //pet 선택 시 정보 출력 및 이미지 변경
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ResetToDefault();
            label5.Text = "명칭: 폴리에틸렌테레프탈레이트\n(Polyethylene Terephthalate)";
            label8.Text = "투명도가 우수하며, 기체(산소, 이산화탄소) 차단성이 뛰어납니다.\n국내 분리배출 기준에서는 무색 페트병(음료/생수)과 \n일반 플라스틱(유색 PET, 샐러드 용기 등)으로 구분하여 배출합니다. ";
            label9.Text = "리사이클 장섬유(의류, 가방, 신발용 장섬유 실),\n\t단섬유(부직포, 충전재), 시트/트레이, 펠릿(Pellet) 기반 재활용 용기";

            if (File.Exists("PET_4.png"))
                pictureBox2.Image = Image.FromFile("PET_4.png");
        }

        //pe 선택 시 정보 출력 및 이미지 변경
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ResetToDefault();
            label5.Text = "명칭: 폴리에틸렌\n(Polyethylene)";
            label8.Text = "에틸렌 단량체를 중합한 대표적인 범용 열가소성 수지입니다.\n밀도에 따라 HDPE/LDPE로 나뉘며, 화학적 안정성이 뛰어납니다.\n환경호르몬 유출 우려가 적고 유연성과 내충격성이 우수합니다.";
            label9.Text = "HDPE: 파이프, 배수관, 운반용 파렛트, 하수도 관로, 용기류\nLDPE: 농업용 비닐, 재활용 쓰레기봉투, 운반용 랩(Stretch Film)";

            if (File.Exists("PE_3.png"))
                pictureBox1.Image = Image.FromFile("PE_3.png");
        }

        //pp 선택 시 정보 출력 및 이미지 변경
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ResetToDefault();
            label5.Text = "명칭: 폴리프로필렌\n(Polypropylene)";
            label8.Text = "플라스틱 중 밀도가 가장 낮아 가벼우면서도 내열성이 높습니다(120~160°C).\n전자레인지 사용이 가능하며, 반복적인 굽힘에도 쉽게 부러지지 않는\n우수한 기계적 특성을 가지고 있습니다.";
            label9.Text = "자동차 내/외장재(범퍼, 대시보드), 배터리 케이스,\n물류용 펠릿, 파렛트, 플라스틱 끈(PP 밴드), 건축용 자재";

            if (File.Exists("PP_2.png"))
                pictureBox3.Image = Image.FromFile("PP_2.png");
        }

        //ps 선택 시 정보 출력 및 이미지 변경
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ResetToDefault();
            label5.Text = "명칭: 폴리스티렌\n(Polystyrene)";
            label8.Text = "가공성이 우수하고 성형이 쉬우며, 성형 축소율이 작아 정밀 성형에 적합합니다.\n투명하고 무색인 상태로 제작이 용이합니다.";
            label9.Text = "일회용 용기, 발포 스티로폼, 전자제품 외장재, 단열재";

            if (File.Exists("PS_2.png"))
                pictureBox4.Image = Image.FromFile("PS_2.png");
        }

        // 선택 초기화 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }


        // 분류하기 버튼 클릭
        private void btnEco_Click(object sender, EventArgs e)
        {
            try
            {
                int petQty = int.Parse(numericPET.Text);
                int peQty = int.Parse(numericPE.Text);
                int ppQty = int.Parse(numericPP.Text);
                int psQty = int.Parse(numericPS.Text);
                int nonQty = int.Parse(numericNon.Text);

                int totalCount = petQty + peQty + ppQty + psQty + nonQty;

                // 1. 수량이 0이면 메시지 출력 후 중단
                if (totalCount == 0)
                {
                    MessageBox.Show("분류할 항목의 수량을 1개 이상 선택해 주세요.", "알림");
                    return;
                }

                int quizBonusPoint = 0;

                // 2. 수량이 1개 이상이면 무조건 퀴즈 실행
                if (totalCount > 0)
                {
                    MessageBox.Show("AI가 해당 플라스틱의 재질을 분석 중입니다.\n분석되는 동안 10초 퀴즈를 풀어보세요!", "AI 분석 중", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Qize quizForm = new Qize();
                    quizForm.ShowDialog();

                    if (quizForm.IsCorrect)
                    {
                        quizBonusPoint = 50;
                    }

                    MessageBox.Show("✅ AI 재질 분석 및 분류가 완료되었습니다!", "분류 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int pet = int.Parse(lbPET.Text) * petQty;
                int pe = int.Parse(lbPE.Text) * peQty;
                int pp = int.Parse(lbPP.Text) * ppQty;
                int ps = int.Parse(lbPS.Text) * psQty;
                int non = int.Parse(lbnon.Text) * nonQty;

                int earnedPoints = pet + pe + pp + ps + non + quizBonusPoint;

                double totalWeightKg = totalCount * 0.03;
                double co2Saved = totalWeightKg * 1.5;
                double treeEffect = co2Saved / 6.6;

                // 사용자 포인트 및 실적 적립 (중복 제거됨)
                if (currentUser != null)
                {
                    currentUser.Point += earnedPoints;
                    currentUser.Co2Saved += co2Saved;
                    currentUser.TreeCount += treeEffect;

                    DisplayUserInfo();
                }

                // 영수증 발행 코드
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("=================================");
                sb.AppendLine("         ♻️ ECO 영수증 ♻️");
                sb.AppendLine("=================================");
                sb.AppendLine($" 일시: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                sb.AppendLine("---------------------------------");
                sb.AppendLine(" 품목          수량          포인트");
                sb.AppendLine("---------------------------------");

                if (petQty > 0) sb.AppendLine($" PET          {petQty,3}개        {pet,6}p");
                if (peQty > 0) sb.AppendLine($" PE           {peQty,3}개        {pe,6}p");
                if (ppQty > 0) sb.AppendLine($" PP           {ppQty,3}개        {pp,6}p");
                if (psQty > 0) sb.AppendLine($" PS           {psQty,3}개        {ps,6}p");
                if (nonQty > 0) sb.AppendLine($" 기타         {nonQty,3}개        {non,6}p");

                if (quizBonusPoint > 0)
                {
                    sb.AppendLine("---------------------------------");
                    sb.AppendLine($" 🎁 퀴즈 보너스 적립        +{quizBonusPoint}p");
                }

                sb.AppendLine("---------------------------------");
                sb.AppendLine($" 총 수량 : {totalCount}개");
                sb.AppendLine($" 총 적립 포인트 : {earnedPoints} p");
                sb.AppendLine("---------------------------------");
                sb.AppendLine(" 🌿 환경 기여 효과");
                sb.AppendLine($" - 탄소 감축량 : {co2Saved:F2} kg CO₂");
                sb.AppendLine($" - 나무 심기   : 소나무 약 {treeEffect:F2} 그루 🌲");
                sb.AppendLine("=================================");
                sb.AppendLine("  지구를 지키는 작은 실천, 감사합니다.!");

                Receipt receiptForm = new Receipt(sb.ToString());
                receiptForm.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("수량 및 라벨 단가 입력을 확인해 주세요.", "오류");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (mainForm1 != null)
            {
                mainForm1.Show();
            }
            this.Close();
        }

        private void btnPointUsing_Click(object sender, EventArgs e)
        {
            if (currentUser == null) return;

            int totalCost = CalculateTotalShopCost();

            if (totalCost == 0)
            {
                MessageBox.Show("구매할 상품의 수량을 1개 이상 선택해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (totalCost > currentUser.Point)
            {
                MessageBox.Show($"포인트가 부족하여 결제할 수 없습니다.\n\n" +
                                $"현재 보유 포인트: {currentUser.Point:N0} p\n" +
                                $"필요 결제 포인트: {totalCost:N0} p", "결제 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ResetShopInputs();
                return;
            }

            DialogResult dr = MessageBox.Show($"총 {totalCost:N0} p를 결제하시겠습니까?", "포인트 결제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                currentUser.Point -= totalCost;
                currentUser.UsedPoint += totalCost;

                if (numericT.Value > 0) currentUser.Coupons.Add($"종량제 교환권 x {numericT.Value}개");
                if (numericBus.Value > 0) currentUser.Coupons.Add($"대중교통 이용권 x {numericBus.Value}개");
                if (numericBike.Value > 0) currentUser.Coupons.Add($"따릉이/자전거 1시간 이용권 x {numericBike.Value}개");
                if (numericMarket.Value > 0) currentUser.Coupons.Add($"온누리 상품권 x {numericMarket.Value}개");
                if (numericOcean.Value > 0) currentUser.Coupons.Add($"해양 환경 기부권 x {numericOcean.Value}개");
                if (numericTree.Value > 0) currentUser.Coupons.Add($"나무 심기 기부권 x {numericTree.Value}개");

                DisplayUserInfo();

                MessageBox.Show("결제가 성공적으로 완료되었습니다!\n마이페이지에서 쿠폰을 확인하세요.", "결제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetShopInputs();
            }
        }

        private void btnChange2_Click(object sender, EventArgs e)
        {
            if (currentUser == null) return;

            Revise editForm = new Revise();
            editForm.CurrentUser = this.currentUser;

            if (mainForm1 != null)
            {
                editForm.MainUserList = mainForm1.userList;
            }

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                DisplayUserInfo();
            }
        }

        private void btnOut2_Click(object sender, EventArgs e)
        {
            if (currentUser == null) return;

            DialogResult result = MessageBox.Show(
                $"{currentUser.Name}님, 정말로 회원 탈퇴하시겠습니까?\n모든 포인트와 기록이 삭제됩니다.",
                "회원 탈퇴 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (mainForm1 != null && mainForm1.userList != null)
                {
                    if (mainForm1.userList.ContainsKey(currentUser.PhoneNumber))
                    {
                        mainForm1.userList.Remove(currentUser.PhoneNumber);
                    }
                }

                MessageBox.Show("회원 탈퇴가 완료되었습니다. 이용해 주셔서 감사합니다.", "탈퇴 완료");

                if (mainForm1 != null)
                {
                    mainForm1.Show();
                }
                this.Close();
            }
        }

        private void btnCupon_Click(object sender, EventArgs e)
        {
            if (currentUser == null) return;

            Cupon couponForm = new Cupon(currentUser.Coupons);
            couponForm.ShowDialog();
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            if (mainForm1 != null)
            {
                mainForm1.Show();
            }
            this.Close();
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            if (mainForm1 != null)
            {
                mainForm1.Show();
            }
            this.Close();
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            if (mainForm1 != null)
            {
                mainForm1.Show();
            }
            this.Close();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = sender as TabControl;
            TabPage page = tab.TabPages[e.Index];
            bool isSelected = (tab.SelectedIndex == e.Index);

            
            Color backColor = isSelected ? Color.SeaGreen : Color.FromArgb(220, 235, 225);
            Color textColor = isSelected ? Color.White : Color.DarkOliveGreen;

            // 배경 & 글자 그리기
            using (SolidBrush bgBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            using (Font font = new Font(e.Font, isSelected ? FontStyle.Bold : FontStyle.Regular))
            {
                TextRenderer.DrawText(e.Graphics, page.Text, font, e.Bounds, textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}