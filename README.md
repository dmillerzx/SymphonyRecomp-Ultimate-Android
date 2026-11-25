# SymphonyRecomp Ultimate — Android

**Castlevania: Symphony of the Night (Ultimate v1.4)**, statically recompiled from PlayStation MIPS machine code into C# and running natively on Android handhelds. Not an emulator — no BIOS required, native 60 FPS performance, and true 16:9 widescreen.

This repository (`dmillerzx/SymphonyRecomp-Ultimate-Android`) is an independent downstream fork maintained by **dmillerzx** (developed with AI assistance and verified on real Retroid Pocket 5 hardware) specifically for the **SOTN Ultimate v1.4** ROM hack.

---

## Credits & Upstream Notice

This project stands on the shoulders of three separate community efforts:

- **SOTN Ultimate v1.4 Hack**: All gameplay enhancements, balance changes, extra content, and ROM hack patches belong to the **Castlevania: Symphony of the Night Ultimate** creators and contributors.
- **Upstream Android Port & Runtime (`sergiomanzur`)**: Built on [sergiomanzur/SymphonyRecomp](https://github.com/sergiomanzur/SymphonyRecomp) and [sergiomanzur/RecompOne](https://github.com/sergiomanzur/RecompOne).
- **Desktop Recompilation (`BlackLabelHQ`)**: Built on the original `SymphonyRecomp` static recompilation architecture and mod ecosystem.
- **Original Game**: *Castlevania: Symphony of the Night* by Konami / KCET.

Please **do not** report bugs from this build to `BlackLabelHQ`, `sergiomanzur`, the SOTN Decomp project, or the SOTN Ultimate hack authors. Bugs and issues specific to this Ultimate Android recomp belong here on [dmillerzx/SymphonyRecomp-Ultimate-Android](https://github.com/dmillerzx/SymphonyRecomp-Ultimate-Android/issues).

---

## Download

**[Get the latest APK from Releases ->](https://github.com/dmillerzx/SymphonyRecomp-Ultimate-Android/releases/latest)**

Current release: **v0.12** (`versionCode 14`) — Android 5.0 (API 21)+, `arm64-v8a` / `x86_64`.

The APK contains **no game data**. You must supply your own legally obtained **Castlevania: Symphony of the Night (Ultimate v1.4)** `.bin`/`.cue` disc dump on first launch.

---

## What's Specific to This Ultimate Android Port

- **Ultimate v1.4 Recompiled Overlays & Symbol Remapping**:
  - Generated Ultimate v1.4 overlays (`main`, `dra`, `sel`, `st0`, `no3`, and stage overlays) using `config_ultimate/` funcmaps.
  - Remapped widescreen, fade, camera, tilemap, and QOL hooks (`CamCol`, `SetNextRoomToLoad`, `RenderTilemap`, `InitFade`, `SetFadeWidth`, `SetFadeMode`, `AllocPrimitives`, `DoGravityJump`, `Skip Prologue`) to their verified Ultimate v1.4 addresses.
- **True 16:9 Widescreen & FMV Fixes**:
  - Full-screen `16:9` (`1.778`) `DeviceAspect` detection using `MaximumWindowMetrics` / `GetRealMetrics` (no system-bar aspect distortion).
  - Edge-to-edge tilemap rendering with background edge clamping.
  - Cross-buffer `offY` fix in `GlCore.PresentDisplay` to eliminate vertical-stripe artifacts during FMVs and menu transitions.
- **60 FPS Handheld Performance**:
  - Release builds compiled with `PublishTrimmed=false` / `AndroidLinkMode=None` for full JIT stability without trimming crashes.
  - Removed per-flush diagnostic `logcat` spam and `glReadPixels` GPU stalls.
  - Tuned Android defaults (`RenderScale = 2`, `4.0ms` VBlank sleep margin) for locked 60 FPS on Snapdragon 865 / Adreno 650 handhelds (configurable in-game up to `4x`).
- **Adaptive App Icon**: Full-bleed pixel-art adaptive launcher icon (`mipmap-anydpi-v26/icon.xml`).
- **Full Android Feature Set**: Physical controller support (PlayStation / Xbox / Nintendo layouts), touch overlay, 5 save-state slots, `.mcr`/`.mcd`/`.sav` memory card import/export, QOL toggles, cheats/inventory editor, and on-device C# mod compilation.

---

## Building from Source

Building from source requires your own **SOTN Ultimate v1.4** disc image and the .NET 10 Android workload (`net10.0-android`):

```powershell
git clone --recursive https://github.com/dmillerzx/SymphonyRecomp-Ultimate-Android.git
cd SymphonyRecomp-Ultimate-Android
dotnet clean RecompOne.SoTN.Android.csproj -c Release
dotnet build RecompOne.SoTN.Android.csproj -c Release
```

> **Note (`net10.0-android` Release)**: Always run `dotnet clean -c Release` before `dotnet build -c Release` so Android JNI typemaps stay in sync.
