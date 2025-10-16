# ApexArcade Test Project

## Gameplay
- **PlayerController**: рухає вліво/вправо, стрибок через `GroundChecker`.
- **Collectible**: предмети збираються, додають очки, зникають через анімацію `Disappear`.
- **ScoreCounter / ScoreCounterUI**: відображають кількість зібраних предметів.

## Unique Feature
- **ScreenShaker**: трясіння камери при зіткненні гравця із землею.
- Інтенсивність залежить від швидкості гравця.
- Використані:
  - `AnimationCurve` для плавності
  - `FixedUpdate` + `Vector3.MoveTowards`
  - `Transform.localPosition`

## UI Flow
- **MenuController / InGameUIController**:
  - Кнопки Play / Quit
  - Fade-in / Fade-out через `ScreenFader` + Animator
  - Background Image + Title
- **ScreenFader**:
  - Виконує подію після закінчення анімації (fade out)
  - Працює через Animator, без впливу на фізику або Input

## Компоненти
- `Rigidbody` – фізика гравця
- `Collider / Trigger` – для предметів
- `Animator` – анімації Collectible та ScreenFader
- `CanvasGroup / UI Image / Text` – меню і UI
- `Input` – керування гравцем