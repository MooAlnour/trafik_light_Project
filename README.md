# 🚦 Traffic Light Simulation (WinForms - C#)

A simple and clean traffic light simulation built using **C# WinForms**.
This project demonstrates the concept of **State Machine** and **Event-driven programming** in a practical way.

## 🎯 Features

* Simulates real-world traffic light behavior:

  * 🔴 Red → 🟢 Green → 🟠 Orange → 🔴 Red
* Configurable timing for each light:

  * Red, Green, and Orange durations
* Countdown timer for each state
* Event-based design:

  * `RedLightOn`
  * `GreenLightOn`
  * `OrangeLightOn`
* Reusable `UserControl` component

## 🧠 Concepts Used

* State Machine (Finite State Logic)
* Events & Delegates
* Timer in WinForms
* Separation of concerns (clean logic design)

## ⚙️ How It Works

The system cycles through traffic light states using a timer:

1. Each state has a specific duration
2. Countdown decreases every second
3. When time reaches zero → state changes automatically
4. Corresponding event is triggered

## 🧩 Project Structure

* `ucTrafficLight` → Main UserControl handling logic and UI
* Timer → Controls the countdown and transitions
* Events → Notify when a light is active

## 🚀 Future Improvements

* Add pedestrian crossing system
* Add sound or alerts
* Support multiple traffic lights (intersection simulation)
* Convert to async/await instead of Timer

## 📌 Notes

This project focuses on writing **clean and maintainable logic** rather than complex UI.

---

💡 Built as a practice project to improve understanding of real-world system design in C#.
