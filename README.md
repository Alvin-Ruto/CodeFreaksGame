# 🐠 Code Rush: Match, Splash, and Win!

**Code Rush** is a vibrant 2D puzzle game where players swap animated fish on a colorful underwater grid to align matches, score points, and progress through immersive oceanic levels. Built in Unity, this casual yet strategic game offers responsive audio, relaxing visuals, and fun level progression.

---

## 🎮 Game Concept

Dive into a coral reef under threat and restore balance by matching fish! Players form lines of three or more identical fish, triggering satisfying combos and cascading effects. With every successful match, the reef revives and the challenge rises.

---

## 👥 Team – CodeFreaks Studio

- **117795** – Alvin Ruto (Programmer)  
- **126526** – Larry Ngugi (Product Manager/Tester)  
- **121438** – Gitau Ivy (Level Designer)  
- **131384** – Eddie Maina (Sound Engineer)

---

## 🚀 Getting Started

**Controls**    
- 🖱️ Mouse: Swap pieces  
- 🔇 `Toggle`: Enable/disable game audio

**How to Play**  
1. Swap adjacent fish to match 3+ of the same kind.  
2. Matched fish disappear, new ones drop in.  
3. Complete score objectives within a move limit to win!

---

## 🧠 Core Systems

- **Game Grid** – Controlled via `GameGrid.cs`, enables piece logic.  
- **Match Clearing** – Managed by `ClearablePiece.cs`.  
- **Audio Manager** – Dynamic BGM + SFX toggle (`AudioManager.cs`).  
- **Scene Management** – Menu, gameplay, transitions.  
- **UI Elements** – Score tracker, move counter, star ratings.

---

## 🎨 Visual & Audio Style

- **Visuals** – Bright, cartoon-style fish with smooth animations.  
- **UI** – Simple and intuitive (top-left counters).  
- **Audio** – Responsive feedback:  
  - Button clicks  
  - Match sound effects  
  - Dynamic music (`IntroSound.wav`, `Gameplay.wav`)  
  - Global mute toggle

---

## 🌍 Game World & Progression

- No heavy storyline—just help rebuild a reef through skilled matching.  
- Progress through increasingly deep ocean levels.  
- Unlock up to 3 stars per level based on performance.

---

## 📱 Platforms & Technology

- **Engine**: Unity (URP)  
- **Target Platforms**: PC (initial), Mobile (planned)  
- **Language**: C#  
- **Team Size**: 4  
- **Development Period**: ~6–8 weeks

---

## 🔧 Development Status

- ✅ 3 playable levels  
- ✅ Core matching + audio + UI system  
- 🔜 Future plans:
  - Power-ups (Bomb Fish, Rainbow Fish)
  - Timed challenges and boosters  
  - Animated story mode  
  - Save/load system and achievements

---

## 🧪 Post-Mortem Highlights

- ✅ Fixed audio null reference bugs  
- ✅ Improved BGM handling per scene  
- ✅ Flexible audio toggle button  
- ✅ Balanced level difficulty  
- ✅ Enhanced visual feedback

---

## 📹 Media & Links

- 🎞️ [Post-Mortem Video](https://youtube.com/shorts/bQs76UM2wzg?si=hbiTK58R-1PJxLeM)  
- 💻 GitHub Repository: [CodeFreaksGame](https://github.com/Alvin-Ruto/CodeFreaksGame)

---

> _"Revive the reef, one match at a time."_ – The CodeFreaks Dev Team
