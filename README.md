# ♻️ Eco Recycling Kiosk

### C# WinForms 기반 친환경 플라스틱 분리배출 키오스크

플라스틱 분리배출에 **포인트 보상, 환경 퀴즈, 환경 기여도, Eco Shop, 쿠폰** 기능을 결합하여  
사용자의 지속적인 재활용 참여를 유도하도록 구현한 키오스크 시스템입니다.

---

## 💡 Project Background

본 프로젝트는 졸업작품인

**「라즈베리파이 5와 YOLOv8에 기반한 실시간 플라스틱 폐기물 분류 시스템」**

에서 착안하여 개발했습니다.

졸업작품에서는 **Raspberry Pi 5와 YOLOv8**을 활용해  
`PET · PE · PP · PS` 플라스틱 폐기물을 실시간으로 분류했습니다.

이를 단순한 **플라스틱 분류 기술**에서 끝내지 않고,

> **분리배출 → 보상 → 환경 교육 → 포인트 활용**

까지 이어지는 사용자 서비스로 확장하여  
**Eco Recycling Kiosk**를 구현했습니다.

### 🔗 Project Expansion

`YOLOv8 기반 PET · PE · PP · PS 분류`

⬇️

`사용자 참여형 서비스로 확장`

⬇️

`분리배출 → 포인트 → 환경 퀴즈 → Eco Shop → 쿠폰`

---

## 🛠 Tech Stack

| Category | Technology |
|---|---|
| **Language** | C# |
| **GUI** | Windows Forms (WinForms) |
| **Framework** | .NET Framework |
| **IDE** | Visual Studio |
| **Platform** | Windows |

---

## ✨ Main Features

| 기능 | 주요 내용 |
|---|---|
| 👤 **회원 관리** | 회원가입, 사용자 정보 수정 및 회원 탈퇴 |
| ♻️ **플라스틱 분리배출** | PET · PE · PP · PS 등 재질별 수량 선택 및 결과 처리 |
| 🔍 **재질 정보 제공** | 플라스틱별 특징, 용도 및 재활용 정보 제공 |
| 🧠 **환경 O/X 퀴즈** | 10초 제한 퀴즈 및 정답 시 보너스 포인트 지급 |
| 💰 **포인트 시스템** | 분리배출 수량과 재질에 따른 포인트 계산 및 적립 |
| 🌱 **환경 기여도** | CO₂ 감축량 및 환경 기여도 누적 확인 |
| 🧾 **영수증** | 분리배출 수량, 적립 포인트 및 결과 확인 |
| 🛒 **Eco Shop** | 적립한 포인트를 이용한 상품 구매 |
| 🎟️ **쿠폰 시스템** | 구매한 상품을 쿠폰 형태로 발급 및 관리 |
| 🙋 **마이페이지** | 사용자 정보, 포인트, 쿠폰 및 환경 기여도 확인 |

---

## 🔄 Service Flow

```text
회원가입
   ↓
플라스틱 재질 확인 및 분리배출
   ↓
환경 O/X 퀴즈
   ↓
포인트 · 환경 기여도 적립
   ↓
영수증 확인
   ↓
Eco Shop 포인트 사용
   ↓
쿠폰 발급
   ↓
마이페이지 확인
```

---

## 💻 Implementation Highlights

### 🔹 Multi-Form UI

WinForms의 여러 `Form`을 기능별로 분리하여  
회원 관리부터 Eco Shop까지 **키오스크 형태의 화면 흐름**을 구성했습니다.

### 🔹 사용자 데이터 연동

여러 Form에서 동일한 사용자 데이터를 공유하여

`회원정보 → 포인트 → 환경 기여도 → 상품 구매 → 쿠폰`

정보가 서로 연동되도록 구현했습니다.

### 🔹 포인트 계산 및 결제 검증

플라스틱의 **종류와 수량에 따라 포인트를 자동 계산**하고,  
Eco Shop에서는 보유 포인트와 결제 포인트를 비교하여 구매 가능 여부를 판단합니다.

```text
보유 포인트 ≥ 결제 포인트 → 결제 가능
보유 포인트 < 결제 포인트 → 결제 제한
```

### 🔹 Timer 기반 환경 퀴즈

WinForms `Timer`를 활용하여  
**10초 제한 O/X 퀴즈**와 정답에 따른 보너스 포인트 기능을 구현했습니다.

### 🔹 실시간 UI 업데이트

사용자의 입력에 따라 다음 정보가 즉시 갱신됩니다.

- 분리배출 수량
- 예상 적립 포인트
- 퀴즈 남은 시간
- Eco Shop 상품 수량
- 결제 필요 포인트
- 사용자 보유 포인트

### 🔹 결과 및 쿠폰 관리

분리배출 완료 후 결과를 **영수증 형태로 생성**하고,  
Eco Shop 결제가 완료되면 구매 상품을 **사용자 쿠폰으로 저장**하도록 구현했습니다.

---

## 🎯 Key Point

기존 졸업작품이

> **플라스틱을 어떻게 정확하게 분류할 것인가**

에 초점을 맞췄다면,

Eco Recycling Kiosk는

> **분류 기술을 실제 사용자 서비스로 어떻게 확장할 것인가**

에 초점을 맞췄습니다.

플라스틱 분리배출에 **보상, 환경 교육, 환경 기여도, 포인트 활용** 요소를 결합하여  
재활용 참여를 유도하는 하나의 키오스크 서비스 흐름으로 구현했습니다.

---

## 📂 Repository Structure

```text
Eco-Recycling-Kiosk
│
├── Eco/
│   ├── Properties/
│   ├── Program.cs
│   ├── MainForm.cs
│   ├── Sign_Up.cs
│   ├── Qize.cs
│   ├── Receipt.cs
│   ├── Cupon.cs
│   ├── UserInfo.cs
│   ├── Eco.csproj
│   └── Eco.sln
│
└── README.md
```

---

## 📌 Project Information

**Project** : Eco Recycling Kiosk  
**Language** : C#  
**GUI** : Windows Forms (WinForms)  
**Framework** : .NET Framework  
**IDE** : Visual Studio  
**Type** : Personal Project
