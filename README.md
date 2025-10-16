# ApexArcade Test Project

## Gameplay
- **PlayerController**: moves left/right, jumps using `GroundChecker`.
- **Collectible**: items can be collected, add points, disappear with `Disappear` animation.
- **ScoreCounter / ScoreCounterUI**: shows how many items collected.

## Unique Feature
- **ScreenShaker**: camera shakes when player hits the ground.
- Intensity depends on player speed.
- Uses:
  - `AnimationCurve` for smooth shake
  - `FixedUpdate` + `Vector3.MoveTowards`
  - `Transform.localPosition`

## UI Flow
- **MenuController / InGameUIController**:
  - Play / Quit buttons
  - Fade-in / Fade-out via `ScreenFader` + Animator
  - Background Image + Title
- **ScreenFader**:
  - Executes an action after fade out finishes
  - Works via Animator, does not block physics or input

## Components
- `Rigidbody` – player physics
- `Collider / Trigger` – collectibles
- `Animator` – Collectible disappear + ScreenFader animations
- `CanvasGroup / UI Image / Text` – menu and UI
- `Input` – player control
