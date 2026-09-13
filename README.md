# ♻️ Eco Recycling Kiosk

### C# WinForms 기반 친환경 플라스틱 분리배출 키오스크

플라스틱 분리배출에 **포인트 적립, 환경 퀴즈, 환경 기여도, Eco Shop, 쿠폰** 기능을 결합하여  
사용자의 재활용 참여를 유도하도록 구현한 **C# WinForms 기반 키오스크 시스템**입니다.

---

## 💡 Project Background

본 프로젝트는 졸업작품인

**「라즈베리파이 5와 YOLOv8에 기반한 실시간 플라스틱 폐기물 분류 시스템」**

에서 착안하여 제작했습니다.

졸업작품에서는 **Raspberry Pi 5와 YOLOv8**을 활용하여  
`PET · PE · PP · PS` 플라스틱 폐기물을 실시간으로 분류하는 시스템을 구현했습니다.

이를 단순한 플라스틱 분류 시스템에서 확장하여,

> **분리배출 → 보상 → 환경 교육 → 포인트 활용**

까지 하나의 사용자 서비스로 연결하고자  
**Eco Recycling Kiosk**를 개발했습니다.

### 🔗 Graduation Project → Kiosk Project

**YOLOv8 기반 실시간 플라스틱 분류**

`PET · PE · PP · PS`

⬇️

**서비스 아이디어 확장**

⬇️

**Eco Recycling Kiosk**

`분리배출 → 포인트 적립 → 환경 교육 → Eco Shop → 쿠폰`

---

## 🛠 Tech Stack

`C#` `WinForms` `.NET Framework` `Visual Studio`

| Category | Technology |
|---|---|
| Language | C# |
| GUI | Windows Forms (WinForms) |
| Framework | .NET Framework |
| IDE | Visual Studio |
| Platform | Windows |

---

## ✨ Main Features

| 기능 | 설명 |
|---|---|
| 👤 **회원 관리** | 회원가입, 로그인, 회원정보 수정 및 회원 탈퇴 |
| ♻️ **플라스틱 분리배출** | PET · PE · PP · PS 등 재질별 수량 및 포인트 계산 |
| 🔍 **재질 정보 제공** | 플라스틱별 특징, 사용 용도 및 재활용 정보 제공 |
| 🧠 **환경 O/X 퀴즈** | 10초 제한시간 퀴즈 및 정답 시 보너스 포인트 지급 |
| 💰 **포인트 시스템** | 분리배출 결과에 따른 포인트 적립 및 사용 |
| 🌱 **환경 기여도** | CO₂ 감축량 및 환경 기여도 확인 |
| 🧾 **영수증** | 분리배출 수량, 적립 포인트 및 결과 확인 |
| 🛒 **Eco Shop** | 적립한 포인트를 활용한 상품 구매 |
| 🎟️ **쿠폰 시스템** | 구매한 상품을 쿠폰 형태로 관리 |
| 🙋 **마이페이지** | 보유 포인트, 쿠폰 및 개인 이용 정보 확인 |

---

## 🔄 System Flow

```text
회원가입 / 로그인
        ↓
플라스틱 재질 정보 확인
        ↓
플라스틱 분리배출
        ↓
환경 O/X 퀴즈
        ↓
포인트 및 환경 기여도 적립
        ↓
영수증 확인
        ↓
Eco Shop 포인트 사용
        ↓
쿠폰 발급 / 마이페이지 확인
```

---

## 💻 Implementation Points

- **Multi-Form 구조**를 이용한 키오스크 화면 구성
- 여러 Form 간 **사용자 정보 및 포인트 데이터 연동**
- 플라스틱 종류와 수량에 따른 **포인트 계산 로직**
- `Timer`를 활용한 **10초 제한 환경 퀴즈**
- 상품 수량 변경에 따른 **Eco Shop 포인트 실시간 계산**
- 보유 포인트와 결제 포인트를 비교하는 **결제 검증**
- 분리배출 결과에 따른 **영수증 동적 생성**
- 사용자 동작에 따른 **UI 실시간 업데이트**

---

## 🎯 Project Purpose

기존 졸업작품이

> **플라스틱을 어떻게 분류할 것인가**

에 초점을 맞췄다면,

Eco Recycling Kiosk는

> **사용자가 어떻게 재활용에 지속적으로 참여하도록 할 것인가**

에 초점을 맞춰 서비스를 확장했습니다.

분리배출에 **보상, 환경 교육, 환경 기여도, 포인트 활용** 요소를 결합하여  
하나의 친환경 키오스크 서비스 흐름을 구현했습니다.

---

## 📌 Project Summary

**Eco Recycling Kiosk**는  
C# WinForms를 활용하여 제작한 친환경 플라스틱 분리배출 키오스크 프로젝트입니다.

졸업작품인

**「라즈베리파이 5와 YOLOv8에 기반한 실시간 플라스틱 폐기물 분류 시스템」**

에서 아이디어를 확장하여 제작했습니다.

졸업작품에서 다룬 `PET · PE · PP · PS` 플라스틱 분류 개념을 기반으로

**분리배출 → 포인트 적립 → 환경 퀴즈 → 환경 기여도 → Eco Shop → 쿠폰**

과정을 하나의 사용자 서비스로 연결했습니다.

---

## 📂 Project Information

| 항목 | 내용 |
|---|---|
| Project | Eco Recycling Kiosk |
| Language | C# |
| GUI | Windows Forms (WinForms) |
| Framework | .NET Framework |
| IDE | Visual Studio |
| Platform | Windows |
| Type | Personal Project |
| Inspiration | YOLOv8 기반 플라스틱 폐기물 분류 졸업작품 |

---

### ♻️ Eco Recycling Kiosk

`C#` `WinForms` `.NET Framework` `Visual Studio` `Recycling` `Kiosk`
